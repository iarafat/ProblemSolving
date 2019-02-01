using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// links: https://devskill.com/CodingProblems/ViewProblem/27

namespace ProblemSolving
{
    class ProblemSeven
    {
        static void Main(string[] args)
        {
            var loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= loop; ++i)
            {
                var values = Convert.ToInt32(Console.ReadLine());
                if (IsPrime(values))
                {
                    Console.WriteLine("Yes");
                } else
                {
                    Console.WriteLine("No");
                }
            }

        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var limit = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= limit; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
