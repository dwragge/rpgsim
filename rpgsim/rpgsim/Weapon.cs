namespace rpgsim
{
    using System.Diagnostics;

    public class Weapon
    {
        private Stopwatch attackingTimer = new Stopwatch();

        public Weapon(float str)
        {
            Strength = str;
            attackingTimer.Start();
        }

        public float Strength { get; set; }

        public void Attack(Unit toAttack)
        {
            if (attackingTimer.ElapsedMilliseconds < 1000)
            {
                return;
            }

            toAttack.Health.TakeDamage(Strength);
            attackingTimer.Restart();
        }
    }
}
