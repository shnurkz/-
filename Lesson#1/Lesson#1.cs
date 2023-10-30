using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Program1
    {
        static void Main1(string[] args)
        {
            float result;
            int x, y;
            x = 5;
            y = 2;
            result = Convert.ToSingle(x) / y;
            Console.WriteLine(result);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
