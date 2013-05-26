namespace rpgsim
{
    using System;
    using C3.XNA;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Unit
    {
        public Unit Target = null;
        public Vector2 AmountToMove = Vector2.Zero;
        private Vector2 targetPositionOfTurn;

        public Unit(float x, float y, Team t, float strength, float hp, float range, float speed)
        {
            Position = new Vector2(x, y);
            Team = t;
            Speed = speed * 25;
            Weapon = new Weapon(strength);
            Range = range;
            Health = new Health(hp);
        }

        public Health Health { get; set; }
        public Team Team { get; set; }
        public Weapon Weapon { get; set; }

        public Vector2 Position { get; set; }
        public float Speed { get; set; }
        public float Range { get; set; }

        public bool FinishedMoving
        {
            get
            {
                return Position.IsNearEnoughTo(targetPositionOfTurn);
            }
        }

        // Called ONCE per turn (hopefully)
        public void Move()
        {
            if (!IsInRange())
            {
                Vector2 delta = Target.Position - Position;
                float length = (float)Math.Sqrt((delta.X * delta.X) + (delta.Y * delta.Y));
                Vector2 unit = new Vector2(delta.X / length, delta.Y / length);
                AmountToMove = unit * Speed;
                targetPositionOfTurn = Position + AmountToMove;
            }
            else
            {
                targetPositionOfTurn = Position;
                AmountToMove = Vector2.Zero;
                if (Target != null && Target.Team != this.Team)
                {
                    Weapon.Attack(Target);
                }
            }
        }

        public void Update(float dt)
        {
            Position += AmountToMove * dt;
            if (IsInRange())
            {
                AmountToMove = Vector2.Zero;
                targetPositionOfTurn = Position;
            }
        }

        public void Render(SpriteBatch b)
        {
            b.DrawCircle(Position, 5f, 200, Team.TeamColor);
            b.DrawCircle(Position, Range, 300, Team.TeamColor);
            Health.DrawHealthBar(new Vector2(Position.X - 25, Position.Y - 20), b);
        }

        private bool IsInRange()
        {
            if (Target != null)
            {
                return Vector2.Distance(Position, Target.Position) + 2.5f < Range;
            }
            else
            {
                return true;
            }
        }
    }
}
