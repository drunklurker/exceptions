namespace _7nov
{
    class TriangleException : GeometryException
    {
        public TriangleException(int[] sides, string message) : base(sides, message)
        {
        }

        public TriangleException(int[] sides) : base(sides)
        {
        }
    }
}
