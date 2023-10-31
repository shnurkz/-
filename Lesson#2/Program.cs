using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float result;
            int x, y;
            x = 5;
            y = 2;
            result = Convert.ToSingle (x) / y;
            Console.WriteLine (Math.PI);
            Console.WriteLine(result);
            Console.WriteLine("Жми капу уже любую! Скрипач не нужен, родной!");
            Console.ReadKey();
        }
    }
}
