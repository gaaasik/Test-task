using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {       static void FindWorld(string[] str)
            {
                int counter = 0;
                string temp = "";
                     for (int i = 0; i < str.Length; i++)
                     {  temp = str[i]; //Первый элемент массива присваиваем temp

                            for (int j = 0; j < str.Length; j++)
                            {     if (temp == str[j]) //Проверяем с каждым элементом массива
                                     counter++; //Увеличиваем счетчик при повторении
                            }
                                  if (counter == 1) //Если счётчик равен 1, т.е. слово наткнулось лишь само на себя
                          Console.WriteLine( str[i]); //выводим слово
                          counter = 0; //обнуляем счётчик
                     }       
             }

        static void Main(string[] args)
        {
            again:

            Console.WriteLine("Введите текст");

            string[] str = Console.ReadLine().Split(' ');

            FindWorld(str);   // вызов функции

            Console.WriteLine("Если хотите еще нажмите 1");
            Console.WriteLine("Для выхода из программы нажмите 2");

            int t = int.Parse(Console.ReadLine());
            if (t == 1)
                goto again;

         
        }
    }
}
