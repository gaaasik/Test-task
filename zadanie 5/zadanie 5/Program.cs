using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace zadanie_5
{
    class Program
    {
        
public class KeyEventArgs : EventArgs
        {

        }

        static void CheckStr(string[] str)


        {

            char[] symbol = new char[100];
            int k = 0;
            int brackets = 0;
            int brackets1 = 0;
            int brackets2 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                foreach (char c in str[i])
                {
                    symbol[i] = c;



                    if (symbol[i] == '(')
                        brackets += 1;

                    if (symbol[i] == '{')
                        brackets1 += 1;

                    if (symbol[i] == '[')
                        brackets2 += 1;

                    if (symbol[i] == ')' )
                        brackets -= 1;

                    if (symbol[i] == '}')
                        brackets1 -=1;

                    if (symbol[i] == ']')
                        brackets2 -= 1;

                    
                }


            
            }
            if (brackets == 0 && brackets1 == 0 && brackets2 == 0)
            {
                Console.WriteLine("Строка является правильной скобочной последовательностью!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("НЕПРАВИЛЬНО");
                Console.WriteLine();
            }

        }    
        static void Main(string[] args)
        {
            int t = 3;
            
            again:

            Console.WriteLine("Введите скобочную последовательность ");
            string[] str = Console.ReadLine().Split(',',' ');
            CheckStr(str);




            if (t != 1)
            {
                t -= 1;
                goto again;
            }
        }
    }
}
