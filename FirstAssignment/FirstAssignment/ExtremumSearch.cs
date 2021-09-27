using System;

namespace FirstAssignment
{
    class ExtremumSearch
    {
        public static double Y(double x)
        {
            return Math.Pow(x + 1, 3) + 5 * Math.Pow(x, 2);
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Min [-2;2] = {0:0.000}", Y(GoldSectionMethod.GetMin(Y,-2, 2, 0.0001)));
            System.Console.WriteLine("Max [-2;2] = {0:0.000}", Y(GoldSectionMethod.GetMax(Y,-2, 2, 0.0001)));
            System.Console.WriteLine("Min [-8;0] = {0:0.000}", Y(GoldSectionMethod.GetMin(Y,-8, 0, 0.0001)));
            System.Console.WriteLine("Max [-8;0] = {0:0.000}\n", Y(GoldSectionMethod.GetMax(Y,-8, 0, 0.0001)));
            System.Console.WriteLine("Min [-2;2] = {0:0.000}", Y(DichotomyMethod.GetMin(Y, -2, 2, 0.0001)));
            System.Console.WriteLine("Max [-2;2] = {0:0.000}", Y(DichotomyMethod.GetMax(Y, -2, 2, 0.0001)));
            System.Console.WriteLine("Min [-8;0] = {0:0.000}", Y(DichotomyMethod.GetMin(Y, -8, 0, 0.0001)));
            System.Console.WriteLine("Max [-8;0] = {0:0.000}", Y(DichotomyMethod.GetMax(Y, -8, 0, 0.0001)));
        }
    }
}
