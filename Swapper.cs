using System.Collections.Generic;

namespace Sorts
{
    public class Swapper
    {
        public static void Swap(int posA, int posB, List<double> numbers)
        {
            if (posA < numbers.Count && posB < numbers.Count)
            {
                var temp = numbers[posA];
                numbers[posA] = numbers[posB];
                numbers[posB] = temp;
            }
        }
    }
}