using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    // link:https://devskill.com/CodingProblems/ViewProblem/22
    class ProblemFourAnotherExample
    {
        static void Main(string[] args)
        {
            var loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                var values = Console.ReadLine().Split(',');
                var valueOne = Convert.ToInt64(values[0]);
                var valueTwo = Convert.ToInt32(values[1]);
                
                Console.WriteLine(DecimalToArbitraySystem(valueOne, valueTwo));
            }
        }

        public static string DecimalToArbitraySystem(long decimalNumer, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

            if (decimalNumer == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumer);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int reminder = (int)(currentNumber % radix);
                charArray[index--] = Digits[reminder];
                currentNumber = currentNumber / radix;
            }

            string result = new string(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumer < 0)
            {
                result = "-" + result;
            }

            return result;
        }
    }
}
