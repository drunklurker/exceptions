namespace _7nov
{
    internal class Circle
    {
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            private set { _radius = value; }
        }

        public Circle(int nRadius)
        {
            if (nRadius <= 0)
                throw new GeometryException(new []{nRadius}, "отрицательный радиус");
            Radius = nRadius;
        }

    }
}
