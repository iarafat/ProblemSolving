using System;
using System.Linq;
using System.Collections.Generic;

namespace ProblemSolving
{
    public class DCP30
    {
        static void Main(string[] args)
        {
            var loop = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine($"Case {i + 1 }:");
                var values = Console.ReadLine();
                CountStringFrequencies(values);
            }
        }

        public static void CountStringFrequencies(string str)
        {
            Dictionary<char, int> FrequenceDictionary = new Dictionary<char, int>();

            foreach (var fChar in str)
            {
                if (FrequenceDictionary.ContainsKey(fChar))
                {
                    FrequenceDictionary[fChar] = FrequenceDictionary[fChar] + 1;
                } else
                {
                    FrequenceDictionary.Add(fChar, 1);
                }
            }

            foreach (var item in FrequenceDictionary.OrderBy(fChar => fChar.Key))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}