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
            Console.Write(a+"!=");

            double f = 1;
            while (a > 1) // нахождение факториала
            {
                f = a * f;
                a -= 1;
            }
            

            Console.Write(f);

        }
        static void Main(string[] args)
        {
            Console.Write("Введите число = ");
          
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Factorial(a);
            Console.ReadLine();

        }

    }
}
