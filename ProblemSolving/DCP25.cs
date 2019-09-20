using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class DCP25
    {
        static void Main(string[] args)
        {
            var loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                string value = Console.ReadLine();
                if (IsPalindrom(value))
                {
                    Console.WriteLine("Yes");
                } else
                {
                    Console.WriteLine("No");
                }
            }
        }

        public static bool IsPalindrom(string value)
        {
            int length = value.Length;
            var lowerValue = value.ToLower();

            var charArray = lowerValue.ToCharArray();
            var RevCharArray = new char[charArray.Length];

            int i = 0;
            for (int j = length - 1; j >= 0; j--)
            {
                RevCharArray[i] = charArray[j];
                i++;
            }

            var revString = new string(RevCharArray);
            
            if (lowerValue == revString)
            {
                return true;
            } else {
                return false;
            }
        }
    }
}
