using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask
{
    class Task1
    {
        public Task1()
        {
            Console.WriteLine("MyClass class has initialized");
        }    
    }

    class Task2
    {
        public Task2(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Task3
    {
        public  long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            long factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }



        public class ArraySorter
        {
        public  void PrintArray(int[] array)
        {
            Console.Write("{ ");

            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" }");
        }
        }

        public class Difference
        {
        
        public void DisplayTheDifference(DateTime dateTime1,DateTime dateTime2)
        {
            TimeSpan timeSpan=dateTime1 - dateTime2;
            Console.WriteLine(timeSpan.ToString());
        }

        }

    public class StringToDateConversion
    {
       
        public  DateTime ConvertStringToDate(string dateString)
        {
            string format = "dd-MM-yyyy";

            DateTime convertedDate = DateTime.ParseExact(dateString, format, null);

            return convertedDate;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //  Task1 display = new Task1();

            //2
            //Task2 display2 = new Task2("Hello");

            //3
            //  Task3 display = new Task3();
            //int number = 5;
            //long result = display.CalculateFactorial(number);

            //4
            //int[] array = { 11, -2, 4, 35, 0, 8, -9 };
            //ArraySorter sorter = new ArraySorter();
            //Console.WriteLine("Sorted array:");
            //sorter.PrintArray(array);

            //5
            //Difference difference = new Difference();
            //DateTime date1 = new DateTime(1981, 11, 03);
            //DateTime date2 = new DateTime(2013, 09, 04);

            //difference.DisplayTheDifference(date1, date2);

            //6
            StringToDateConversion stringToDate=new StringToDateConversion();
            string dateString = "12-08-2004";
            DateTime convertedDate = stringToDate.ConvertStringToDate(dateString);
            Console.WriteLine($"Converted Date: {convertedDate.ToString("yyyy-MM-dd")}");
        }
    }
}
