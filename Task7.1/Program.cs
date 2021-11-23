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
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины сторон 2-го треугольника: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            double S1, P1, p1, S2, P2, p2;
            GetParam(a, b, c, out S1, out P1, out p1);
            GetParam1(a1, b1, c1, out S2, out P2, out p2);
            #endregion
            if (S1>S2)
            {
                Console.WriteLine("Площадь первого треугольника больше, чем площадь второго треугольника");
            }
            else
            {
                Console.WriteLine("Площадь второго треугольника больше, чем площадь первого треугольника");
            }
            Console.ReadKey();
        }
        static void GetParam(int a, int b, int c, out double P1, out double p1, out double S1)
        {
            P1 = a + b + c;
            p1 = P1 / 2;
            S1 = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - c));
            Console.WriteLine("Площадь первого прямоугольника равна: {0:f2}", S1);
            Console.WriteLine();
        }
        static void GetParam1(int a1, int b1, int c1, out double P2, out double p2, out double S2)
        {
            P2 = a1 + b1 + c1;
            p2 = P2 / 2;
            S2 = Math.Sqrt(p2 * (p2 - a1) * (p2 - b1) * (p2 - c1));
            Console.WriteLine("Площадь второго прямоугольника равна: {0:f2}", S2);
            Console.WriteLine();
        }
    }
}
