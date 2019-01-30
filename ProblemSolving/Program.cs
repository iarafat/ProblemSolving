using System;

namespace ProblemSolving
{
    // link:https://devskill.com/CodingProblems/ViewProblem/4
    class ProbelmTwo
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] getInputs = line.Split(' ');

                var totalSpritTime = int.Parse(getInputs[0]);
                var totalTeamMember = int.Parse(getInputs[1]);

                int totalWorkingHOurs = 0;
                for (int i = 0; i < totalTeamMember; i++)
                {
                    totalWorkingHOurs += int.Parse(Console.ReadLine());
                }

                var workingDays = 0;
                if (totalSpritTime % totalWorkingHOurs == 0)
                {
                    workingDays = totalSpritTime / totalWorkingHOurs;
                }
                else
                {
                    workingDays = (totalSpritTime / totalWorkingHOurs) + 1;
                }
                if (workingDays == 1)
                {
                    Console.WriteLine("Project will finish within 1 day.");
                }
                else
                {
                    Console.WriteLine("Project will finish within {0} days.", workingDays);
                }
            }
        }
    }
}
