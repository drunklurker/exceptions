namespace _7nov
{
    class GeometryException : System.Exception
    {
        public int[] Parameters { get; private set; }

        public GeometryException(int[] sides, string message) : base(message)
        {
            Parameters = (int[])sides.Clone();
        }

        public GeometryException(int[] sides)
        {
            Parameters = (int[])sides.Clone();
        }


    }
}
