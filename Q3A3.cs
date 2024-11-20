using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    internal class Q3A3
    {
        public static class MathHelper
        {
            public static double CalculateAverage(int[] numbers)
            {
                if (numbers == null || numbers.Length == 0)
                {
                    throw new ArgumentException("Array cannot be null or empty.");
                }

                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }

                return (double)sum / numbers.Length;
            }
        }
           public  static void Number()
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                double average = MathHelper.CalculateAverage(numbers);
                Console.WriteLine($"The average is: {average}");
            }
        }
    }

