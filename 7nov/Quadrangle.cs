using System;
using System.Linq;

namespace _7nov
{
    class Quadrangle
    {
        private Int32[] _sides = new int[4];

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

        public int Side4
        {
            get { return _sides[3]; }
            private set { _sides[3] = value; }
        }

        public Quadrangle(int s1, int s2, int s3, int s4)
        {
            int[] nSides = new[] {s1, s2, s3, s4};
            if (nSides.Any(x_ => x_ <= 0))
                throw new GeometryException(nSides, "Отрицательная сторона прямоугольника");
            for (int i = 0; i < 4; i++)
            {
                if (nSides[i] >= nSides.Skip(i).Sum())
                    throw new GeometryException(nSides, "Сторона больше суммы трёх других");
            }
            for (int i = 0; i < nSides.Length; i++)
            {
                _sides[i] = nSides[i];
            }
        }
    }
}
