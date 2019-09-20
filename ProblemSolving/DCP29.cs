using System;

namespace ProblemSolving
{
    public class DCP29
    {
        static void Main(string[] args)
        {
            var loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                var values = Console.ReadLine().Split(' ');
                int logestInt = LongestCommonSubstring(values[0], values[1]);

                Console.WriteLine($"Case {i + 1 }: {logestInt}");
            }
        }

        public static int LongestCommonSubstring(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
            {
                return 0;
            }

            int[,] number = new int[str1.Length, str2.Length];
            int maxlen = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] != str2[j])
                    {
                        number[i, j] = 0;
                    } else
                    {
                        if ((i == 0) || (j == 0))
                        {
                            number[i, j] = 1;
                        } else
                        {
                            number[i, j] = 1 + number[i - 1, j - 1];
                        }

                        if (number[i, j] > maxlen)
                        {
                            maxlen = number[i, j];
                        }
                    }
                }
            }

            return maxlen;
        }
    }
}