using static System.Console;

namespace NegativeToPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mixNums = {0, -7, 1, 7, -23};
            MakePositive(mixNums);
        }

        private static int[] MakePositive(int[] mixNums)
        {
            for (var i = 0; i < mixNums.Length; i++)
            {
                if (mixNums[i] < 0)
                {
                    mixNums[i] *= -1;
                }
                Write($"{mixNums[i]}; ");
            }
            return mixNums;
        }
    }
}
