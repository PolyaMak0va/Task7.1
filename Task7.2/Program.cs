using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._1
{
    class Program
    {
        // Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба в метрах: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double V, S;
            GetParam(a, out V, out S);
            Console.WriteLine("Тогда объём куба равен {0} м3", V);
            Console.WriteLine("А площадь куба равна {0} м2", S);
            Console.ReadKey();
        }
        static void GetParam(int a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = (double)a * a;
        }
    }
}
