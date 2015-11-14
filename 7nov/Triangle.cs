namespace _7nov
{
    class Triangle
    {
        int[] _sides = new int[3];

        public int Side1
        {
            get { return _sides[0]; }
            private set { _sides[0] = value; }
        }
        public int Side2
        {
            get { return _sides[1]; }
            private set { _sides[1] = value; }
        }
        public int Side3
        {
            get { return _sides[2]; }
            private set { _sides[2] = value; }
        }

        public Triangle(int s1, int s2, int s3)
        {
            if (s1 <= 0 || s2 <= 0 || s3 <= 0)
                throw new TriangleException(new int[] { s1, s2, s3 }, "Отрицательная сторона треугольник");
            if (s1 >= s2 + s3 || s2 >= s1 + s3 || s3 >= s1 + s2)
                throw new TriangleException(new int[] { s1, s2, s3 }, "Сторона больше суммы двух других");
                
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }
    }
}
