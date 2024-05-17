using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveExtensions.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// Checks if an integer is even.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>True if the integer is even, otherwise false.</returns>
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// Checks if an integer is odd.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>True if the integer is odd, otherwise false.</returns>
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        /// <summary>
        /// Converts an integer to its ordinal representation.
        /// </summary>
        /// <param name="number">The integer to convert.</param>
        /// <returns>The ordinal representation of the integer (e.g. 1st, 2nd, 3rd, etc.).</returns>
        public static string ToOrdinal(this int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be greater than zero.");
            }

            int lastDigit = number % 10;
            int lastTwoDigits = number % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 13)
                return number + "th";

            string ordinalSuffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th",
            };

            return number + ordinalSuffix;
        }

        /// <summary>
        /// Clamps the number to a specified range.
        /// </summary>
        /// <param name="number">The number to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The clamped value.</returns>
        public static int Clamp(this int number, int min, int max)
        {
            return Math.Max(min, Math.Min(max, number));
        }

        /// <summary>
        /// Determines whether the specified number is prime.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is prime; otherwise, false.</returns>
        public static bool IsPrime(this int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Calculates the greatest common divisor (GCD) of the number and another number.
        /// </summary>
        /// <param name="number">The first number.</param>
        /// <param name="other">The second number.</param>
        /// <returns>The GCD of the two numbers.</returns>
        public static int GCD(this int number, int other)
        {
            while (other != 0)
            {
                int temp = other;
                other = number % other;
                number = temp;
            }
            return number;
        }

        /// <summary>
        /// Calculates the least common multiple (LCM) of the number and another number.
        /// </summary>
        /// <param name="number">The first number.</param>
        /// <param name="other">The second number.</param>
        /// <returns>The LCM of the two numbers.</returns>
        public static int LCM(this int number, int other)
        {
            return Math.Abs(number * other) / number.GCD(other);
        }

        /// <summary>
        /// Converts the number to its hexadecimal string representation.
        /// </summary>
        /// <param name="number">The number to convert.</param>
        /// <returns>A string representing the hexadecimal form of the number.</returns>
        public static string ToHexString(this int number)
        {
            return Convert.ToString(number, 16);
        }

        /// <summary>
        /// Converts the number to its binary string representation.
        /// </summary>
        /// <param name="number">The number to convert.</param>
        /// <returns>A string representing the binary form of the number.</returns>
        public static string ToBinaryString(this int number)
        {
            return Convert.ToString(number, 2);
        }

        /// <summary>
        /// Checks if an integer is positive.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>True if the integer is positive, otherwise false.</returns>
        public static bool IsPositive(this int number)
        {
            return number > 0;
        }

        /// <summary>
        /// Checks if an integer is negative.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>True if the integer is negative, otherwise false.</returns>
        public static bool IsNegative(this int number)
        {
            return number < 0;
        }

        /// <summary>
        /// Calculates the sum of the digits of the number.
        /// </summary>
        /// <param name="number">The number whose digits are to be summed.</param>
        /// <returns>The sum of the digits of the number.</returns>
        public static int DigitSum(this int number)
        {
            return number.ToString().ToCharArray().Sum(c => c - '0');
        }

        /// <summary>
        /// Calculates the factorial of the number.
        /// </summary>
        /// <param name="number">The number whose factorial is to be calculated.</param>
        /// <returns>The factorial of the number.</returns>
        public static int Factorial(this int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
