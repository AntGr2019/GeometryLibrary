using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Figure
    {
        private double S;
        private double P;
        public double Square
        {
            get
            {
                return S;
            }
        }
        public double Perimetr
        {
            get
            {
                return P;
            }
        }
        public Figure(double R)
        {
            this.S = R * R * Math.PI;
            this.P = 2 * R * Math.PI;
            Console.WriteLine("\nYou're have created a round with a radius {0}", R);
            Console.WriteLine("The Square of this round = " + S);
        }
        public Figure(double a, double b, double c)
        {
            TriangleProperty tri = new TriangleProperty(a, b, c);
            Console.WriteLine("\nYou're have try created a triangle with a sides {0}, {1}, {2}...", a, b, c);
            this.P = a + b + c;
            double hP = P / 2;
            if (c <= 0 || b <= 0 || a <= 0)
            {
                tri.isExist = false;
                Console.WriteLine("The value of the side can not be negative!");// Press any key to continue... ");
                //Console.ReadLine();
            }
            else if (hP <= c || hP <= b || hP <= a)
            {
                tri.isExist = false;
                Console.WriteLine("The triangle with the ratio of sides does not exist!");// Press any key to continue... ");
                //Console.ReadLine();
            }
            else
            {
                this.S = Math.Sqrt(hP * (hP - a) * (hP - b) * (hP - c));
                Console.WriteLine("-Successfully. The Square of this thiangle = " + S);
                if (tri.isRightAngleTriangle() == true) Console.WriteLine("It is a right angle triangle.");
            }
        }

        public class TriangleProperty 
        {
            private bool triangleIsExists = true;
            private double A, B, C;
            public TriangleProperty(double a, double b, double c)
            {
                A = a; B = b; C = c;
            }
            public Boolean isRightAngleTriangle()
            {
                bool result = false;
                double k1 = Math.Min(A, B);
                double k2 = Math.Min(Math.Max(A, B), C);
                double hypotenuse = Math.Max(Math.Max(A, B), C);
                if (k1 * k1 + k2 * k2 == hypotenuse * hypotenuse) result = true;
                return result;
            }
            public bool isExist
            {
                get { return triangleIsExists; }
                set { triangleIsExists = value; }
            }
        }
    }

}
