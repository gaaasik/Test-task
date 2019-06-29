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
        static void Print(int[] A)// вывод массива на экран 
        
            {
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write(A[i] + " ");
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
                    Console.Write(arr[i] + " ");
                }

                Sort(arr);  // вызов функции
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Отсортированный масиив:");
                Console.WriteLine();
                Print(arr);
                Console.ReadKey();

            }
        }
    }

