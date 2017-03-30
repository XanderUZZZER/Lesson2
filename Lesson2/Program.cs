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
                    case "3":
                        //Task3();
                        answer = AskForChoice();
                        break;
                    case "4":
                        //Task4();
                        answer = AskForChoice();
                        break;
                    case "5":
                        //Task5();
                        answer = AskForChoice();
                        break;
                    case "6":
                        //Task6();
                        answer = AskForChoice();
                        break;
                    case "6.1":
                        //Task6dot1();
                        answer = AskForChoice();
                        break;
                    case "7":
                       // Task7();
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
            char temp;
            for (int i = 0, j = inputString.Length - 1; i < j; i++, j--)
            {
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }
            Console.Write("\t\t");
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write(charArray[i]);
            }
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
    }
}
