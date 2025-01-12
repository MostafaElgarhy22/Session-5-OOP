using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_OOP.Static
{
    internal class Utility
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Utility(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override string ToString()
        {
            return $"({X},  {Y})";
        }

        // object Member Method

        public double CmToInch(double Cm)
        {
            return Cm / 2.54;
        }

        private static readonly double pi = 3.14;

        public static double PI
        {
            get { return pi; }
        }

        public static double CalcCircleArea(double Radius)
        {
            return pi * Radius * Radius;
        }
    }
}
