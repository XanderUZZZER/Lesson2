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
                    case "13":
                        Task13();
                        answer = AskForChoice();
                        break;
                    case "14":
                        Task14();
                        answer = AskForChoice();
                        break;
                    case "15":
                        Task15();
                        answer = AskForChoice();
                        break;
                    case "16":
                        Task16();
                        answer = AskForChoice();
                        break;
                    case "17":
                        Task17();
                        answer = AskForChoice();
                        break;
                    case "18":
                        Task18();
                        answer = AskForChoice();
                        break;
                    case "19":
                        Task19();
                        answer = AskForChoice();
                        break;
                    case "20":
                        Task20();
                        answer = AskForChoice();
                        break;
                    case "21":
                        Task21();
                        answer = AskForChoice();
                        break;
                    case "extra":
                        ExtraTask();
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
            Console.WriteLine("Tasks:\t8  9  10  11  12  13  14  15  16  18  19  20  21 extra");
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
            Console.WriteLine("Outputs the sum of elements of the array");
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
            Console.WriteLine("Outputs the multiplication of elements of the array");
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
        static void Task13()
        {
            Console.WriteLine("Outputs the minimum element of the array");
            Console.Write("Input array size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            int minI = 0;
            Console.WriteLine("Fill the array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < array[minI])
                    minI = i;
            }
            Console.WriteLine("The minimum element is: " + array[minI]);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task14()
        {
            Console.WriteLine("Outputs the maximum element of the array");
            Console.Write("Input array size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            int maxI = 0;
            Console.WriteLine("Fill the array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > array[maxI])
                    maxI = i;
            }
            Console.WriteLine("The maximum element is: " + array[maxI]);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task15()
        {
            Console.WriteLine("Outputs the arithmetic mean of elements of the array");
            Console.Write("Input array size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            int sum = 0;
            double arithMean = 0;
            Console.WriteLine("Fill the array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            arithMean = (double)sum / (double)arraySize;
            Console.WriteLine("The the arithmetic mean is: " + arithMean);
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
        static void Task17()
        {
            Console.WriteLine("Compares each element of 2 arrays");
            Console.Write("Input arrays size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];
            bool equal = false;
            Console.WriteLine("Fill the first array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
                array1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Fill the second array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
                array2[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("\tArray 1\tArray 2\tEqual");
            for (int i = 0; i < arraySize; i++)
            {
                if (array1[i] == array2[i])
                    equal = true;
                else
                    equal = false;
                Console.WriteLine("\t"+array1[i]+"\t"+array2[i]+"\t"+equal);
            }
            Console.WriteLine("\n\tDone\n--------------------------------------------------------------\n");
        }
        static void Task18()
        {
            Console.WriteLine("Doubles the value of all array elements");
            Console.Write("Input array size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            Console.WriteLine("Fill the array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                array[i] *= 2;
            }
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("{0,4}", array[i]);
            }
            Console.WriteLine("\n\tDone\n--------------------------------------------------------------\n");
        }
        static void Task19()
        {
            Console.WriteLine("Reads an array of strings of a user-specified size from the keyboard.\nReads a pattern string, output all the elments containing this pattern and the index from which such substring begins");
            Console.Write("Input array size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            string[] arrayString = new string[arraySize];
            Console.WriteLine("Fill the array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                arrayString[i] = Console.ReadLine();
            }
            Console.WriteLine("Input pattern string: ");
            string pattern = Console.ReadLine();
            for (int i = 0; i < arraySize; i++)
            {
                if (arrayString[i].Contains(pattern))
                {
                    int index = arrayString[i].IndexOf(pattern);
                    Console.WriteLine("Element #{0} contains pattern, value is: {1}, position is: {2}", i, arrayString[i], index);
                }
            }
            Console.WriteLine("\n\tDone\n--------------------------------------------------------------\n");
        }
        static void Task20()
        {
            Console.WriteLine("Reads an array of strings of a user-specified size from the keyboard.\nReads a pattern string, removes from elements the pattern");
            Console.Write("Input array size: \t");
            int arraySize = int.Parse(Console.ReadLine());
            string[] arrayString = new string[arraySize];
            Console.WriteLine("Fill the array in with {0} elements:", arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                arrayString[i] = Console.ReadLine();
            }
            Console.WriteLine("Input pattern string: ");
            string pattern = Console.ReadLine();
            Console.WriteLine("Edited array:");
            for (int i = 0; i < arraySize; i++)
            {
                arrayString[i] = arrayString[i].Replace(pattern, "");
                Console.WriteLine(arrayString[i]);
            }
            Console.WriteLine("\n\tDone\n--------------------------------------------------------------\n");
        }
        static void Task21()
        {
            Console.WriteLine("Generates an array of int from 0 to 9 in random order");
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
            Console.WriteLine("0 9 random array");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,4} ", a[i]);
            }
            Console.WriteLine("\n\tDone\n--------------------------------------------------------------\n");
        }
        static void ExtraTask()
        {
            Console.WriteLine("Input array elements, to stop inputting, input \"-1\" (it will be last element)");            
            int lastElement = int.Parse(Console.ReadLine());
            int size = 1;
            int[] mainArray = { lastElement };
            int[] tempArray = { lastElement };
            while (lastElement != -1)
            {
                lastElement = int.Parse(Console.ReadLine());
                size++;

                mainArray = new int[size];
                for (int i = 0; i < (size-1); i++)
                    mainArray[i] = tempArray[i];
                mainArray[size-1] = lastElement;

                tempArray = new int[size+1];
                for (int i = 0; i < size; i++)
                    tempArray[i] = mainArray[i];
            }
            Console.WriteLine();
            for (int i = 0; i< mainArray.Length; i++)
                Console.WriteLine(mainArray[i]);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
    }
}
