using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_Programmer
{
    public class Add_Digits
    {
        public int Calculate(int input)
        {
            ValidateNumber(input);

            var inputArray = ToIntArray(input);

            return 1;

        }


        private static int[] ToIntArray(int input)
        {
            var output = new List<int>();
            var charArray = input.ToString().ToCharArray();

            foreach (var item in charArray)
            {
                output.Add((int)char.GetNumericValue(item));
            }

            return output.ToArray();
        }

        private static void ValidateNumber(int input)
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException("input", "input must be a non-negative number.");
            }
        }
    }
}
