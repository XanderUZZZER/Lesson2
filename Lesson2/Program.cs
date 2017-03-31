using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = AskForChoice();

            

            while (answer != "q")
            {
                switch (answer)
                {
                    case "8":
                        Task8();
                        answer = AskForChoice();
                        break;
                    case "9":
                        Task9();
                        answer = AskForChoice();
                        break;
                    case "10":
                        Task10();
                        answer = AskForChoice();
                        break;
                    case "11":
                        Task11();
                        answer = AskForChoice();
                        break;
                    case "12":
                        Task12();
                        answer = AskForChoice();
                        break;
                    default:
                        Console.Write("INPUT ERROR!!!\nTry again\n\n");
                        answer = AskForChoice();
                        break;
                }
            }
        }

        static string AskForChoice()
        {
            Console.WriteLine("Tasks:\t8  9  10  11  12  13  14  15  16");
            Console.WriteLine("\t***  Enter the task number, or enter \'q\' to quit  ***");
            return Console.ReadLine();
        }
        static void Task8()
        {
            Console.Write("Reads a string from the keyboard and output it backwards\nInput string:\t");
            string inputString = Console.ReadLine();
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            Console.Write("\t\t"); Console.Write(charArray);
            Console.WriteLine("\n\tDone\n--------------------------------------------------------------\n");
        }
        static void Task9()
        {
            Console.WriteLine("Declare an array of 10 elements, fill it with elements from 0 to 9 and output");
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < 10; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine("\n\tDone\n--------------------------------------------------------------\n");

        }
        static void Task10()
        {
            Console.WriteLine("Read the size of the array, elements of the array from the keyboard and outputs array back");
            Console.WriteLine("Input array size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            Console.WriteLine("Fill the array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
                array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Your array:");
            for (int i = 0; i < arraySize; i++)
                Console.WriteLine(array[i]);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task11()
        {
            Console.WriteLine("Outpiuts the sum of elements of the array");
            Console.Write("Input array size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            int sum = 0;
            Console.WriteLine("Fill the array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task12()
        {
            Console.WriteLine("Outpiuts the multiplication of elements of the array");
            Console.Write("Input array size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            int multiplication = 1;
            Console.WriteLine("Fill the array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                multiplication *= array[i];
            }
            Console.WriteLine("The multiplication is: " + multiplication);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task16()
        {
            Console.WriteLine("Swap the minimum and maximum elements of an array");
            Console.WriteLine("Input array size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];            
            Console.WriteLine("Fill the array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
                array[i] = int.Parse(Console.ReadLine());
            int minI = 0, maxI = 0;
            int temp;
            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] < array[minI])
                    minI = i;
                else if (array[i] > array[maxI])
                    maxI = i;
            }
            temp = array[minI];
            array[minI] = array[maxI];
            array[maxI] = temp;
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("{0,4}", array[i]);
            }
            Console.WriteLine("\n\tDone\n--------------------------------------------------------------\n");
        }
        static void Task21()
        {
            Random rnd = new Random();
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
                a[i] = i;
            for (int i = 0; i < 5; i++)
            {
                int i1 = rnd.Next(0, 10); // первый индекс
                int i2 = rnd.Next(0, 10); // второй индекс
                                           // обмен значений элементов с индексами i1 и i2 
                int temp = a[i1];
                a[i1] = a[i2];
                a[i2] = temp;
            }
            Console.WriteLine("Значения элементов");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,4} ", a[i]);
                //if (i % 5 == 4)
                  //  Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
