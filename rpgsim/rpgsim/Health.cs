namespace rpgsim
{
    using C3.XNA;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Health
    {
        private float maxHealth;
        private float currentHealth;

        public Health(float max)
        {
            maxHealth = currentHealth = max;
        }

        public float HP
        {
            get
            {
                return currentHealth;
            }
        }

        public float Percent
        {
            get
            {
                return (currentHealth / maxHealth) * 100f;
            }
        }

        public bool Alive
        {
            get
            {
                return HP > 0;
            }
        }

        public void TakeDamage(float damage)
        {
            if (Alive)
            {
                currentHealth -= damage;
            }
        }

        public void DrawHealthBar(Vector2 position, SpriteBatch b)
        {
            if (Alive)
            {
                Rectangle barBG = new Rectangle((int)position.X, (int)position.Y, 100, 15);
                Rectangle bar = new Rectangle((int)position.X, (int)position.Y, (int)(100 * (Percent / 100f)), 15);
                b.FillRectangle(barBG, Color.White);
                b.FillRectangle(bar, Color.Red);
            }
        }
    }
}
