using System;

namespace FirstAssignment
{
    class GoldSectionMethod
    { 
        const double phi = 1.618033988749895;
        /// <summary>
        /// Метод поиска минимума функции на отрезке [A;B], с точностью E
        /// </summary>
        /// <param name="func">Заданная функция</param>
        /// <param name="A">Начало отрезка</param>
        /// <param name="B">Конец отрезка</param>
        /// <param name="E">Точность</param>
        /// <returns></returns>
        public static double GetMin(Func<double,double> func,double A, double B, double E)
        {
            double X1;
            double X2;
            while (Math.Abs(B - A) > E)
            {
                X1 = B - (B - A) / phi;
                X2 = A + (B - A) / phi;
                if (func(X1) >= func(X2))
                {
                    A = X1;
                }
                else
                {
                    B = X2;
                }
            }
            return (A + B) / 2.0;
        }
        /// <summary>
        /// Метод поиска максимума функции на отрезке [A;B], с точностью E
        /// </summary>
        /// <param name="func"></param>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="E"></param>
        /// <returns></returns>
        public static double GetMax(Func<double,double> func,double A, double B, double E)
        {
            double X1;
            double X2;
            while (Math.Abs(B - A) > E)
            {
                X1 = B - (B - A) / phi;
                X2 = A + (B - A) / phi;
                if (func(X1) <= func(X2))
                {
                    A = X1;
                }
                else
                {
                    B = X2;
                }
            }
            return (A + B) / 2.0;
        }
    }
}
