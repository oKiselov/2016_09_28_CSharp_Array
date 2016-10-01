using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Задание1
 * Прочитать конспект один раз.
 * 
 * Задание2
 * Написать программу, которая просит пользователя ввести количество строк. 
 * Принимает, создает рванный массив с указанным количеством строк. 
 * Потом пользователя просит ввести размер каждой строки. 
 * Принимает и создает строки указанного размера. 
 * Заполняет случайными значениями и выводит на консоль. 
 * После просит ввести номер строки, которую необходимо отсортировать. 
 * Принимает и сортирует указанную строку. После этого снова выводится массив на косноль.
 *
 * Обязательные требования проверки и комментарии.
 * 
 */

namespace Kiselov_HW_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the quantity of strings: ");
                // counter of strings, which user wants to initialize  
                int iCounter;
                // initialization of counter 
                iCounter = ParserFunction();

                // creation of random variable for filling the array 
                Random rand = new Random();
                
                // creating of array 
                int[][] jaggedArray = new int[iCounter][];

                // loop for filling all gaps in jagged array 
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    Console.WriteLine("Enter the length of current({0}) string: ", i);
                    int iLengthString = ParserFunction();

                    // loop for filling with random integers 
                    jaggedArray[i] = new int[iLengthString];
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] = rand.Next(10);
                    }
                }
                // Demo
                Show(jaggedArray);

                Console.WriteLine("Enter the number of string to sort: ");
                iCounter = ParserFunction();

                // Sorting 
                Array.Sort(jaggedArray[iCounter]);

                Console.WriteLine("Array with sorted {0} string: ", iCounter);
                // Demo of sorted string 
                Show(jaggedArray);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch
            {
                Console.WriteLine("Unhandled Exception");
            }

            finally
            {
                Console.WriteLine();
            }
        }

        // Function which outputs all integers in array into desktop
        static void Show(int[][] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    Console.Write("{0} ", mas[i][j]);
                }
                Console.Write("\r\n");
            }
        }

        // Parsing from string to int
        static int ParserFunction()
        {
            int iCounter=int.Parse(Console.ReadLine());
            return iCounter;
        }
    }
}
