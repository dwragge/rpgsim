namespace rpgsim
{
    public class Range
    {
        public readonly int Lower;
        public readonly int Upper;

        public Range()
        {
        }

        public Range(int first, int second)
        {
            Lower = first;
            Upper = second;
        }
    }
}
