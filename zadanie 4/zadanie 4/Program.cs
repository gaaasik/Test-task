using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    class Program
    {   static void Factorial(int a)
        {
            double f = 1;
            while (a > 1) // нахождение факториала
            {
                f = a * f;
                a -= 1;
            }
            Console.WriteLine(f);

        }
        static void Main(string[] args)
        {
           
            int a = int.Parse(Console.ReadLine());
            Factorial(a);
            Console.ReadLine();

        }

    }
}
