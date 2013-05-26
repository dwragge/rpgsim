namespace rpgsim
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Xna.Framework;

    public class Team : IEquatable<Team>
    {
        public Team(Color color)
        {
            TeamColor = color;
        }

        public Color TeamColor { get; set; }

        public static bool operator ==(Team t1, Team t2)
        {
            return t1.Equals(t2);
        }

        public static bool operator !=(Team t1, Team t2)
        {
            return !t1.Equals(t2);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Team);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(Team other)
        {
            return TeamColor == other.TeamColor;
        }   
    }
}
