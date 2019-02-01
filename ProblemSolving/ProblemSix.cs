using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//links: https://devskill.com/CodingProblems/ViewProblem/26

namespace ProblemSolving
{
    class ProblemSix
    {
        static void Main(string[] args)
        {
            var loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                var values = Console.ReadLine();
                Console.WriteLine(Reverse(values.ToString()));
            }

        }
        public static string Reverse(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
