using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._1
{
    class Program
    {
        /* Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод для вычисления  
         * площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона
        */
        static void Main(string[] args)
        {
            #region Инициализация переменных
            Console.WriteLine("Введите длины сторон 1-го треугольника: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины сторон 2-го треугольника: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());

            double S1 = GetParam(a1, b1, c1); // запрос у метода вычисления площади для треугольника 1
            double S2 = GetParam(a2, b2, c2); // запрос у метода вычисления площади для треугольника 2
            if (S1 > S2) // сравнение площадей двух треугольников
            {
                Console.WriteLine("Площадь первого треугольника больше, чем площадь второго треугольника");
            }
            else
            {
                Console.WriteLine("Площадь второго треугольника больше, чем площадь первого треугольника");
            }
            #endregion
            Console.ReadKey();
        }
        static double GetParam(int a, int b, int c)
        {
            double result = 0;
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));  
            return result;
        }
    }
}
