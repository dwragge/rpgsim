namespace rpgsim
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Map
    {
        private List<Unit> units = new List<Unit>();
        private List<Unit> deadUnits = new List<Unit>();
        private Stopwatch turnTimer = new Stopwatch();
        private int lastUnitToMoveIndex = -1;
        private Unit currentUnitTurn;
        private bool alreadyMovedThisTurn = false;
        private bool turnJustFinished = false;

        public Map()
        {
        }

        public bool HasUnitsAlive()
        {
            int unitsAlive = 0;
            foreach (Unit u in units)
            {
                if (u.Health.Alive)
                {
                    unitsAlive++;
                }
            }

            return unitsAlive > 1;
        }

        public void TryMove()
        {
            if (!alreadyMovedThisTurn)
            {
                int moveIndex = lastUnitToMoveIndex;
                int nextUnitIndex = lastUnitToMoveIndex >= units.Count - 1 ? 0 : ++moveIndex;
                currentUnitTurn = units[nextUnitIndex];
                currentUnitTurn.Move();
                alreadyMovedThisTurn = true;
            }
        }

        public void Update(float dt)
        {
            if (turnTimer.ElapsedMilliseconds < 1000 && turnJustFinished)
            {
                return;
            }

            if (!HasUnitsAlive())
            {
                return;
            }

            TryMove();

            if (currentUnitTurn.Target == null || !currentUnitTurn.Target.Health.Alive)
            {
                currentUnitTurn.Target = GetClosestEnemy(currentUnitTurn);
            }

            currentUnitTurn.Update(dt);

            if (currentUnitTurn.FinishedMoving)
            {
                lastUnitToMoveIndex = units.FindIndex(x => x == currentUnitTurn);
                alreadyMovedThisTurn = false;
                turnJustFinished = true;
                turnTimer.Restart();
            }

            CullDeadUnits();
        }

        public void Draw(SpriteBatch b)
        {
            foreach (Unit u in units)
            {
                u.Render(b);
            }

            foreach (Unit u in deadUnits)
            {
                // u.Render(b);
            }
        }

        public void Add(Unit u)
        {
            units.Add(u);
        }

        public void GenerateTargets()
        {
            foreach (Unit unit in units)
            {
                unit.Target = GetClosestEnemy(unit);
            }
        }

        private Unit GetClosestEnemy(Unit u)
        {
            var hostiles = from c in units
                           where c.Team != u.Team && c.Health.Alive
                           select c;

            var distances = new List<KeyValuePair<float, Unit>>();
            foreach (Unit h in hostiles)
            {
                float distance = Vector2.Distance(h.Position, u.Position);
                distances.Add(new KeyValuePair<float, Unit>(distance, h));
            }

            distances.Sort((x, y) => x.Key.CompareTo(y.Key));

            try
            {
                return distances.First().Value;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        private void CullDeadUnits()
        {
            var deadThisRound = (from u in units
                                 where u.Health.Alive == false
                                 select u).ToList();

            deadUnits.AddRange(deadThisRound);

            units = units.Except(deadUnits).ToList();
        }
    }
}
