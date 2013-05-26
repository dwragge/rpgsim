namespace rpgsim
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Xna.Framework;

    public static class Extensions
    {
        public const float Epsilon = 1f;

        public static bool IsNearEnoughTo(this Vector2 src, Vector2 dest)
        {
            float dx = Math.Abs(src.X - dest.X);
            float dy = Math.Abs(src.Y - dest.Y);

            return dx < Epsilon || dy < Epsilon;
        }

        public static int Next(this Random random, Range r)
        {
            return random.Next(r.Lower, r.Upper);
        }

        public static int Next(this Random random, Range r, int value, int plusminus)
        {
            int lower = Math.Max(value - plusminus, r.Lower);
            int upper = Math.Min(value + plusminus, r.Upper);

            return random.Next(lower, upper);
        }
    }
}
