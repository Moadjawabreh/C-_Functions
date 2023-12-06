using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int newDate = getDays(new DateTime(2019, 6, 14), new DateTime(2019, 6, 20));
            //Console.WriteLine(newDate.ToString());

            //2
            //string[] strings = { "1a", "a", "2b", "b" };
            //numInStr(strings);

            //3
            //string reversString=  reverseOdd("Bananas");

            //4 

            //bool checkIfPand = isPandigital(90864523148909);

            //Console.WriteLine(checkIfPand);

            
        }

        private static bool isPandigital(long v)
        {
            string numbers=v.ToString();
            HashSet<char> set = new HashSet<char>();
            foreach (char item in numbers)
            {
                set.Add(item);
            }


            return set.Count==10;
        }

        private static string reverseOdd(string v)
        {
            string [] splitString= v.Split(' ');
            for (int i = 0; i < splitString.Length; i++)
            {
                if (splitString[i].Length % 2 != 0)
                {
                    char[] charArray = splitString[i].ToCharArray();
                    Array.Reverse(charArray);
                    splitString[i] = new string(charArray);

                }   

            }

            return splitString.ToString();
        }

        private static string [] numInStr(string[] strings)
        {
            List<string> list = new List<string>();
            foreach (var item in strings)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (char.IsDigit(item[i]))
                    {
                        list.Add(item);
                        break;
                    }

                }
            }

            return list.ToArray();
        }

        private static int getDays(DateTime dateTime1, DateTime dateTime2)
        {
            TimeSpan timeSpan=dateTime2 - dateTime1;
            return timeSpan.Days;
        }
    }
}
