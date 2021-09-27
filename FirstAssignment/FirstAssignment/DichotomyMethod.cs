using System;

namespace FirstAssignment
{
    class DichotomyMethod
    {
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
            double X;
            while (Math.Abs(B - A) > E)
            {
                X = (A + B) / 2;
                if (func(X - E) < func(X + E))
                {
                    B = X;
                }
                else
                {
                    A = X;
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
        public static double GetMax(Func<double, double> func, double A, double B, double E)
        {
            double X;
            while (Math.Abs(B - A) > E)
            {
                X = (A + B) / 2;
                if (func(X - E) > func(X + E))
                {
                    B = X;
                }
                else
                {
                    A = X;
                }
            }
            return (A + B) / 2.0;
        }
    }
}
