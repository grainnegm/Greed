using System;

namespace Greed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Score(new int[] {5, 1, 3, 4, 1}));
        }

        public static int Score(int[] dice)
        {
            int points = 0;

            int[] counts = { 0, 0, 0, 0, 0, 0 };

            foreach (int die in dice)
            {
                counts[die - 1] += 1;
            }

            for (int i = 1; i <= 6; i++)
            {

                int count = counts[i - 1];

                if (count >= 3)
                {
                    if (i == 1)
                    {
                        points += 1000;
                    }
                    else
                    {
                        points += i * 100;
                    }
                    count -= 3;
                }

                if (i == 1)
                {
                    points += count * 100;
                }
                else if (i == 5)
                {
                    points += count * 50;
                }
            }
            return points;
        }

    }
}
