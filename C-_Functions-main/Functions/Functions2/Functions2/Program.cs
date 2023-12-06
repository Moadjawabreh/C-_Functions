using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int number = Add(10, 20);

            //2
            //float newNumber=removeLeadingTrailing("230.000");

            //3
            //int[] nums = new int[] { 10, 40, 30, 20, 50 };
            //int secondLarge = secondLargest(nums);

            //4
            //Console.WriteLine(isRepdigit(66));   
            //Console.WriteLine(isRepdigit(0));     
            //Console.WriteLine(isRepdigit(-11));

            //5

            //string newString=reverseWords(" the sky is blue");

            //6
            //int[] array1 = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(SevenBoom(array1));

            //7

            //string newWord=insertWhitespace("SheWalksToTheBeach");

            //8

            //bool[] array1 = { true, false, false, true, false };
            //Console.WriteLine(CountTrue(array1));

            //9

            //Console.WriteLine(CapToFront("hApPy"));      


            //10

            //string[] strings = { "rsq", "6hi", "g", "rsq6hig" };
            //bool check= matchLastItem(strings);

            //11
            //Console.WriteLine(FindNaN(new double[] { 1, 2, double.NaN }));       

            //12
            // string[] stringsWithDuplicateItems = { "John", "Taylor", "John" };
            //string[] stringsWithOutDuplicateItems = removeDups(stringsWithDuplicateItems);

            // Console.WriteLine(stringsWithOutDuplicateItems);

            //13

            //string timeConverted = convertTime("12:40:22AM");

            //14
            //string stringAfter= removeLastVowel("Those who dare to fail miserably can achieve greatly.");


            //15
            int[] numbers = { 1, 5, 9 };

            Console.WriteLine(SumOfCubes(numbers));
        }


        static int SumOfCubes(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += (int)Math.Pow(number, 3);
            }

            return sum;
        }

        private static string removeLastVowel(string sentence)
        {
            List<Char> list = new List<Char>();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'e' || sentence[i] == 'o' || sentence[i] == 'a' || sentence[i] == 'i' || sentence[i] == 'u')
                {
                    if (sentence[i+1]==' ')
                    {
                        continue;
                    }

                }
                list.Add(sentence[i]);

            }
             sentence = string.Join("", list);

            return sentence;    
        }

        private static string convertTime(string time)
        {
            string hours = time[0].ToString() + time[1].ToString();
            int intHours=int.Parse(hours);


            foreach (var item in time)
            {
                if (item == 'P')
                {
                    intHours=intHours+12;
                    if (intHours == 24)
                    {
                        intHours = 12;
                    }

                    time = intHours + time.Substring(2, 6);
                }
                else if(item == 'A')
                {
                    if (intHours == 12)
                    {
                        intHours = intHours - 12;

                    }
                    time = intHours + time.Substring(2, 6);

                }

            }
            return time;
        }

        private static string[] removeDups(string [] strings)
        {
            HashSet<string> result = new HashSet<string>();
            foreach (var item in strings)
            {
                result.Add(item);   
            }
            return result.ToArray();
        }

        static int FindNaN(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (double.IsNaN(numbers[i]))
                {
                    return i;
                }
            }

            return -1;
        }


        private static bool matchLastItem(string[] strings)
        {
            string v= strings[strings.Length-1];
            string concat = "";
            for (int i = 0; i < strings.Length; i++)
            {
                if (i == strings.Length - 1)
                {
                    if (concat == strings[i].ToString())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                concat += strings[i];
                
            }
            return false;

        }

        static string CapToFront(string word)
        {
            StringBuilder capitalLetters = new StringBuilder();
            StringBuilder nonCapitalLetters = new StringBuilder();

            foreach (char letter in word)
            {
                if (char.IsUpper(letter))
                {
                    capitalLetters.Append(letter);
                }
                else
                {
                    nonCapitalLetters.Append(letter);
                }
            }

            return capitalLetters.ToString() + nonCapitalLetters.ToString();
        }


        static int CountTrue(bool[] values)
        {
            int count = 0;

            foreach (bool value in values)
            {
                if (value)
                {
                    count++;
                }
            }

            return count;
        }

        private static string insertWhitespace(string v)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < v.Length; i++)
            {
                if (char.IsUpper(v[i]) && i > 0)
                {
                    sb.Append(' ');
                }
                sb.Append(v[i]);

            }
            return sb.ToString();
        }

        static string SevenBoom(int[] numbers)
        {
            foreach (int num in numbers)
            {
                if (ContainsSeven(num))
                {
                    return "Boom!";
                }
            }

            return "there is no 7 in the array";
        }

        static bool ContainsSeven(int number)
        {
            while (number > 0)
            {
                if (number % 10 == 7)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }



        private static string reverseWords(string v)
        {
            string[] words = v.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);

        }

        static bool isRepdigit(int number)
        {
            string numberString = Math.Abs(number).ToString();

            for (int i = 1; i < numberString.Length; i++)
            {
                if (numberString[i] != numberString[0])
                {
                    return false;
                }
            }

            return true;
        }

        private static int secondLargest(int [] values)
        {
            Array.Sort(values);
            Array.Reverse(values);
            return values[1];
        }

        private static float removeLeadingTrailing(string v)
        {
            float num = float.Parse(v);
            return num;
        }

        private static int Add(int v1, int v2)
        {
            return v1+v2;
        }
    }
}
