using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    // links:https://devskill.com/CodingProblems/ViewProblem/13
    class ProblemThree
    {
        static void Main(string[] args)
        {
            var loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                int bdRunsOne = 0;
                int bdRunsTwo = 0;
                int pkRunsOne = 0;
                int pkRunsTwo = 0;
                for (int j = 0; j < 2; j++)
                {
                    var teamsRuns = Console.ReadLine().Split(' ');
                    if (j == 0)
                    {
                        bdRunsOne += Convert.ToInt32(teamsRuns[0]) + Convert.ToInt32(teamsRuns[1]);
                        pkRunsOne += Convert.ToInt32(teamsRuns[2]) + Convert.ToInt32(teamsRuns[3]);
                    } else
                    {
                        bdRunsTwo += Convert.ToInt32(teamsRuns[0]) + Convert.ToInt32(teamsRuns[1]);
                        pkRunsTwo += Convert.ToInt32(teamsRuns[2]) + Convert.ToInt32(teamsRuns[3]);
                    }
                    
                }
                
                if ((bdRunsOne > pkRunsOne) && (bdRunsTwo > pkRunsTwo))
                {
                    Console.WriteLine("Banglawash");
                } else
                {
                    Console.WriteLine("Miss");
                }
                //Console.WriteLine("{0}, {1}, {2}, {3}", bdRunsOne, bdRunsTwo, pkRunsOne, pkRunsTwo);
            }
        }
    }
}
