using System;

namespace FirstAssignment
{
    class Program
    {
        public static double Y(double x)
        {
            return Math.Pow(x + 1, 3) + 5 * Math.Pow(x, 2);
        }
        static void Main(string[] args)
        {
            double phi = (1 + Math.Sqrt(5.0)) / 2.0;
            double Min, Max;
            double A = -2.0;
            double B = 2.0;
            double E = 0.001;
            double X1;
            double X2;
            while(Math.Abs(B - A) > E)
            {
                X1 = B - (B - A) / phi;
                X2 = A + (B - A) / phi;
                if (Y(X1) >= Y(X2))
                {
                    A = X1;
                }
                else
                {
                    B = X2;
                }
            }
            Min = (A + B) / 2;
            System.Console.WriteLine("[-2;2]\nMin = {0:0.000}", Y(Min));
            A = -2.0;
            B = 2.0;
            while (Math.Abs(B - A) > E)
            {
                X1 = B - (B - A) / phi;
                X2 = A + (B - A) / phi;
                if (Y(X1) <= Y(X2))
                {
                    A = X1;
                }
                else
                {
                    B = X2;
                }
            }
            Max = (A + B) / 2;
            System.Console.WriteLine("Max = {0:0.000}", Y(Max));
            A = -8.0;
            B = 0.0;
            while (Math.Abs(B - A) > E)
            {
                X1 = B - (B - A) / phi;
                X2 = A + (B - A) / phi;
                if (Y(X1) >= Y(X2))
                {
                    A = X1;
                }
                else
                {
                    B = X2;
                }
            }
            Min = (A + B) / 2;
            System.Console.WriteLine("[-8;0]\nMin = {0:0.000}", Y(Min));
            A = -8.0;
            B = 0.0;
            while (Math.Abs(B - A) > E)
            {
                X1 = B - (B - A) / phi;
                X2 = A + (B - A) / phi;
                if (Y(X1) <= Y(X2))
                {
                    A = X1;
                }
                else
                {
                    B = X2;
                }
            }
            Max = (A + B) / 2;
            System.Console.WriteLine("Max = {0:0.000}", Y(Max));
        }
    }
}
