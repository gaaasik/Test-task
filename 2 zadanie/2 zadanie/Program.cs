using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zadanie
{
    class Program
    {
        static void Sort(int[] A) // сортировка методом пузырька
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int z = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = z;
                    }
                }
            }

        }
        
        static void Print(int[] A) // вывод массива на экран 
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }

        static void Find(int[] A, int  findNumber ) // функция поиска поэлементно 
        {
            int n = A.Length; 
            for (int i = 0; i < n; i++)
            {
                if (A[i] == findNumber) 
                {
                    Console.Write("В этом масииве есть это число ! Индекс этого числа =");
                    Console.WriteLine(i);
                    n = 0;   // обнуляем n для выхода из массива

                }
                else
                {
                    if (A[i] > findNumber) // если искомое число меньше чем элемент СОРТИРОВАННОГО массива то дальше идти нет смысла
                    {
                        Console.WriteLine("Мы ничего не нашли!");
                        n = 0; // обнуляем для своевремненного выхода из массива
                    }
                }
            }
            if (n > 1 ) // если после цикла мы ничего не нашли то выведем это на экран  
            {
                Console.WriteLine("Мы ничего не нашли! Cлишком большое число, попробуй поменьше :)");
                
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] arr = new int[n];
            Random rand = new Random(); // рандомный массив от - 100 до 100

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
               
            }
           


            Sort(arr); // вызов функции
            
            Console.WriteLine("Отсортированный масиив:");
            Console.WriteLine();
            Print(arr);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Введите искомое число=");
            int findNumber = int.Parse(Console.ReadLine());
            Find(arr, findNumber);
            Console.ReadKey();

        }
    }
}