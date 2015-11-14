namespace _7nov
{
    class CircleException : GeometryException
    {
        public CircleException(int[] radius, string message) : base(radius, message)
        { }
        public CircleException(int[] radius) : base(radius)
        { }
    }
}
