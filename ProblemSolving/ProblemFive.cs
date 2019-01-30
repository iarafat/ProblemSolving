using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// links:https://devskill.com/CodingProblems/ViewProblem/336
namespace ProblemSolving
{
    class ProblemFive
    {
        static void Main(string[] args)
        {
            var loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                var values = Convert.ToInt32(Console.ReadLine());
                check(values);
            }
        }

        static void check(int num)
        {
            for (int i = 2; i <= 62; i++)
            {
                if (checkBase(num, i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool checkBase(int num, int i)
        {
            // base case 
            if (num < i)
            {
                return true;
            }

            if (num >= i)
            {
                return checkBase((num / i), i);
            }
            return false;
        }
    }
}
