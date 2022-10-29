using System.Collections.Generic;

namespace Sorts
{
    public class CocktailSort
    {
        public static int Counter { get; private set; } = 0;

        public static void Sort(List<double> numbers)
        {
            Counter = 0;
            int left = 0;
            int right = numbers.Count - 1;

            while(left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Sorts.Swapper.Swap(i, i + 1, numbers);
                        Counter++;
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        Sorts.Swapper.Swap(i, i - 1, numbers);
                        Counter++;
                    }
                }
                left++;
            }
        }
    }
}