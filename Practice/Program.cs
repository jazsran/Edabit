using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            IntReversal();
            //Console.WriteLine(solution("aabbbzcccddoiesjzzlee"));
            //Console.WriteLine(LandscapeType(new int[] {3, 4, 5, 4, 3}));
            //GetAbsSum(new int[] { 5000 });
            //SpecialReverseString("1 23 456");
            //License("Eric", 2, "Adam Caroline Rebecca Frank");
            //OverTime(new[] { 2, 22, 30, 1.5 });
            //Console.WriteLine(SevenBoom(new int[] { 2, 6, 8, 9, 3 }));
            //HackerSpeak("become A coder");
            //Factorial(3);
            //CountDs("My friend Dylan got distracted at school");
            //CountClaps("!CClaClClap!ClCClCCClaCClap!ClCCClCClClap!ClClClap!CClap!CClCClap!ClCClap!Clap!Clap!Clap!ClClap!Clap!CClaClClap!ClaClaClaClCClClaClClap!ClaClClaClap!ClaClap!CClClClap!ClClaClClap!Clap!ClaClaClaClaClClap!CClaClClaCClap!ClClClClClap!Clap!CClClap!ClClap!ClaClap!CClClaClaClap!Clap!");
            //Console.WriteLiClapne(isIdentical("kkakkk"));
            //NameShuffle("Jas Sran");
            //FindMinMax(new double[] { 13, 72, 98, 43, 24, 65, 31 });
            //ReverseCase("JaS");
            //ArrayOfMultiples(7, 5);
        }
        public static void IntReversal()
        {
            int a = 5;
            int b = 10;
            b = b + a;
            a = b - a;
            b = b - a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static String solution(String S)
        {
            int[] occurrences = new int[26];
            foreach (char ch in S)
            {
                occurrences[(int)ch - 'a']++;
            }

            char best_char = 'a';
            int best_res = 0;

            for (int i = 1; i < 26; i++)
            {
                if (occurrences[i] > best_res)
                {
                    best_char = (char)('a' + i);
                    best_res = occurrences[i];
                }
            }

            return best_char.ToString();
        }

        //public static int solution(int[] A)
        //{
        //    List<int> AList = new List<int>();

        //    foreach (int i in A)
        //    {
        //        if (i > 9 && i < 100)
        //            AList.Add(i);

        //        else if (i < -9 && i > -100)
        //            AList.Add(i);
        //    }

        //    //remove this
        //    foreach (int i in AList)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    return AList.Sum();
        //}

        //public static int solution(int[] A)
        //{
        //that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

        //For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

        //Given A = [1, 2, 3], the function should return 4.

        //Given A = [−1, −3], the function should return 1.       
        //int i = 
        //return 0;
        //}
        public static string LandscapeType(int[] arr)
        {
            int peak = arr.Max();
            List<int> arrList = new List<int>();
            List<int> PriorList = new List<int>();
            List<int> PriorListsorted = new List<int>();
            List<int> AfterList = new List<int>();
            arrList = (arr).ToList();
            int x = arrList.IndexOf(peak);
            int ctr = 0;

            for (int i = 0; i < arrList.IndexOf(peak); i++)
            {
                PriorList.Add(arrList[i]);
            }

            //PriorList.AddRange(arr.Split(2));

            for (int i = arrList.IndexOf(peak) + 1; i < arrList.Count(); i++)
            {
                AfterList.Add(arrList[i]);
            }

            foreach (int i in PriorList)
            {
                //Console.WriteLine(i);
            }

            foreach (int i in AfterList)
            {
                //Console.WriteLine(i);
            }

            PriorListsorted = PriorList;
            PriorListsorted.Sort();
            AfterList.Sort();


            foreach (int i in arrList)
            {
                if (i == peak)
                    ctr++;
            }

            if (ctr > 1 || arrList.IndexOf(peak) == 0 || arrList.IndexOf(peak) == arrList.Count - 1)
                return "neither";

            for (int i = 0; i < PriorList.Count(); i++)
            {
                if (PriorList[i] != PriorListsorted[i])
                    return "neither";
            }

            foreach (int i in PriorListsorted)
            {
                Console.WriteLine(i);
            }

            foreach (int i in PriorList)
            {
                Console.WriteLine(i);
            }
            //if (PriorList == PriorList.Sort())
            //return "mountain";

            //for (int i = 0; i < arrList.IndexOf(peak); i++)
            //{
            //    Console.WriteLine(arrList[i].ToString());
            //    if (arrList[i] >= peak)
            //        return "neither";

            //    if (arrList[i] < ctr)
            //        ctr = arrList[i];
            //}

            return "mountain";
        }
        public static int GetAbsSum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum = sum + System.Math.Abs(num);
            }
            Console.WriteLine(sum.ToString());
            return sum;
        }
        public static string SpecialReverseString(string txt)
        {
            List<char> OriginalList = new List<char>();
            char[] Originaltxt = txt.ToCharArray();
            string reversed = "";

            for (int i = 0; i < Originaltxt.Length; i++)
            {
                if (Originaltxt[i] != ' ')
                    OriginalList.Add(Originaltxt[i]);
            }

            for (int i = 0; i < Originaltxt.Length; i++)
            {
                if (Originaltxt[i] != ' ')
                {
                    if (char.IsUpper(Originaltxt[i]))
                        reversed = reversed + char.ToUpper(OriginalList.Last());

                    else if (char.IsLower(Originaltxt[i]))
                        reversed = reversed + char.ToLower(OriginalList.Last());
                    else
                        reversed = reversed + OriginalList.Last();

                    OriginalList.RemoveAt(OriginalList.Count - 1);
                }
                else
                    reversed = reversed + " ";
            }
            Console.WriteLine(reversed);
            return string.Empty;
        }
        public static int License(string me, int agents, string others)
        {
            int queue = 0;
            double time = 0;
            List<string> People = others.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            People.Add(me);
            People.Sort();
            //queue = People.FindIndex(a => a.Contains(me)) + 1;
            queue = People.IndexOf(me) + 1;
            time = Math.Ceiling((double)queue / agents) * 20;

            People.ForEach(Console.WriteLine);
            Console.WriteLine(queue.ToString());
            Console.WriteLine(time.ToString());

            return Convert.ToInt32(time);
        }
        public static string OverTime(double[] arr)
        {
            double pay = 0;
            double time = 0;
            double normal = 0;
            double overtime = 0;

            time = arr[1] - arr[0];

            if (arr[0] < 9)
                overtime = 9 - arr[0];
            if (arr[1] > 17)
                overtime = overtime + (arr[1] - 17);
            normal = time - overtime;

            pay = ((normal * arr[2]) + overtime * arr[2] * arr[3]);

            Console.WriteLine(overtime.ToString());
            Console.WriteLine(pay.ToString());

            return pay.ToString();
        }
        public static string SevenBoom(int[] arr)
        {
            if (arr.ToList().Contains(7))
                return "Boom!";
            return "there is no 7 in the array";
        }
        public static string HackerSpeak(string str)
        {
            //replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.
            str = str.ToLower().Replace("a", "4").Replace("e", "3").Replace("i", "1").Replace("o", "0").Replace("s", "5");
            Console.WriteLine(str);
            return str;
        }
        public static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = num; i > 0; i--)
                factorial = factorial * i;

            Console.WriteLine(factorial.ToString());
            return factorial;
        }
        public static int CountDs(string str)
        {
            int count = 0;
            count = str.Split('d', 'D').Length - 1;
            Console.WriteLine(count.ToString());
            return count;
        }
        public static int CountClaps(string txt)
        {
            int counter = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt.Substring(i, 1).ToLower() == "c")
                    counter++;
            }
            Console.WriteLine(counter.ToString());
            return counter;
        }
        public static bool isIdentical(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(0, 1) != str.Substring(i, 1))
                    return false;
            }
            return true;
        }
        public static string NameShuffle(string str)
        {
            Console.WriteLine(str.Substring(str.IndexOf(" ") + 1) + " " + str.Substring(0, str.IndexOf(" ")));
            return str.Substring(str.IndexOf(" ") + 1) + " " + str.Substring(0, str.IndexOf(" "));
        }
        public static double[] FindMinMax(double[] values)
        {
            double[] MinMax = { values[0], values[0] };

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < MinMax[0])
                    MinMax[0] = values[i];

                if (values[i] > MinMax[1])
                    MinMax[1] = values[i];
            }

            Console.WriteLine(MinMax[0].ToString());
            Console.WriteLine(MinMax[1].ToString());
            return MinMax;
        }
        public static string ReverseCase(string str)
        {
            char[] carr = str.ToCharArray();
            for (int i = 0; i < carr.Length; i++)
            {
                if (char.IsLetter(carr[i]))
                {
                    if (char.IsUpper(carr[i]))
                        carr[i] = char.ToLower(carr[i]);
                    else
                        carr[i] = char.ToUpper(carr[i]);
                }
            }
            str = new string(carr);
            Console.WriteLine(str);
            return str;
        }
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] array = new int[length];

            for (int i = 1; i <= length; i++)
            {
                array[i - 1] = (num * i);
            }

            foreach (var number in array)
            {
                Console.WriteLine(number.ToString());
            }
            return array;
        }
    }
}