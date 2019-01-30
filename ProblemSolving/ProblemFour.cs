using System;
using System.Text;
namespace ProblemSolving
{
    // link:https://devskill.com/CodingProblems/ViewProblem/22

    class ProblemFour
    {
        static void Main(string[] args)
        {
            var loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                var values = Console.ReadLine().Split(',');
                var valueOne = Convert.ToInt32(values[0]);
                var valueTwo = Convert.ToInt32(values[1]);
                if (valueOne != 0 && valueTwo != 0) 
                {
                    Console.WriteLine(ToBase(valueOne, valueTwo));
                }
            }
                
        }

        public static string ToBase(int value, int radix)
        {
            const string baseChars =
                "0123456789" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = new StringBuilder();
            int temp = value;
            while (temp != 0)
            {
                result.Append(baseChars[temp % radix]);
                temp /= radix;
            }
            return Reverse(result.ToString());
        }

        public static string Reverse(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /*public static string IntToString(int value, char[] baseChars)
        {
            string result = string.Empty;
            int targetBase = baseChars.Length;

                do
                {
                  result = baseChars[value % targetBase] + result;
                } while (value > 0);
            Console.WriteLine(result);
            return result;
        }*/
    }
}
