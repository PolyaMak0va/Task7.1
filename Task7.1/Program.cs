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
            Console.WriteLine("Введите длины сторон 1-го треугольника: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            ExistTriangle(a1, b1, c1);
            Console.WriteLine("Введите длины сторон 2-го треугольника: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            ExistTriangle(a2, b2, c2);

            double S1 = GetParam(a1, b1, c1); // запрос у метода вычисления площади для треугольника 1
            double S2 = GetParam(a2, b2, c2); // запрос у метода вычисления площади для треугольника 2
            if (S1 == S2)
            {
                Console.WriteLine("Площади первого и второго треугольника равны");
            }
            else
            {
                if (S1 < S2)
                {
                    Console.WriteLine("Площадь второго треугольника больше, чем площадь первого треугольника");
                }
                else
                {
                    Console.WriteLine("Площадь первого треугольника больше, чем площадь второго треугольника");
                }
            }
            Console.ReadKey();
        }

        static bool ExistTriangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (((a + b) >= c) && ((b + c) >= a) && ((a + c) >= b))
                {
                    Console.WriteLine("Треугольник существует");
                }
                return true;
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
                return false;
            }
        }
        static double GetParam(double a, double b, double c)
        {
            double result = 0;
            double p = (a + b + c) / 2;
            result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine();
            return result;
        }
    }
}
