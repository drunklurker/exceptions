namespace _7nov
{
    class QuadrangleException : GeometryException
    {
        public QuadrangleException(int[] sides, string message) : base(sides, message)
        {
        }
        public QuadrangleException(int[]sides) : base(sides)
        { }
    }
}
