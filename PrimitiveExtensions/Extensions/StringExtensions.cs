using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrimitiveExtensions.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether the specified string is a palindrome.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>True if the string is a palindrome; otherwise, false.</returns>
        public static bool IsPalindrome(this string input)
        {
            string cleanedInput = input.ToLower().Replace(" ", "");
            return cleanedInput.SequenceEqual(cleanedInput.Reverse());
        }

        /// <summary>
        /// Counts the number of vowels in the string.
        /// </summary>
        /// <param name="input">The string to count vowels in.</param>
        /// <returns>The number of vowels in the string.</returns>
        public static int CountVowels(this string input)
        {
            return input.Count(c => "aeiouAEIOU".Contains(c));
        }

        /// <summary>
        /// Reverses the characters in the string.
        /// </summary>
        /// <param name="input">The string to reverse.</param>
        /// <returns>The reversed string.</returns>
        public static string Reverse(this string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Checks if the string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>True if the string is null, empty, or consists only of white-space characters; otherwise, false.</returns>
        public static bool IsNullOrEmptyOrWhiteSpace(this string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Truncates the string to the specified maximum length.
        /// </summary>
        /// <param name="input">The string to truncate.</param>
        /// <param name="maxLength">The maximum length of the truncated string.</param>
        /// <returns>The truncated string.</returns>
        public static string Truncate(this string input, int maxLength)
        {
            if (input.Length <= maxLength)
                return input;
            return input.Substring(0, maxLength);
        }

        /// <summary>
        /// Converts the string to title case.
        /// </summary>
        /// <param name="input">The string to convert.</param>
        /// <returns>The string converted to title case.</returns>
        public static string ToTitleCase(this string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
        }

        /// <summary>
        /// Removes all whitespace characters from the string.
        /// </summary>
        /// <param name="input">The string to remove whitespace from.</param>
        /// <returns>The string with whitespace characters removed.</returns>
        public static string RemoveWhitespace(this string input)
        {
            return new string(input.Where(c => !char.IsWhiteSpace(c)).ToArray());
        }

        /// <summary>
        /// Splits a CamelCase formatted string into words.
        /// </summary>
        /// <param name="input">The CamelCase string to split.</param>
        /// <returns>A string array containing the words.</returns>
        public static string[] SplitCamelCase(this string input)
        {
            return Regex.Split(input, @"(?<!^)(?=[A-Z])");
        }

        /// <summary>
        /// Determines whether the string represents a numeric value.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>True if the string represents a numeric value; otherwise, false.</returns>
        public static bool IsNumeric(this string input)
        {
            return double.TryParse(input, out _);
        }

        /// <summary>
        /// Determines whether the string represents an email address.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>True if the string represents an email address; otherwise, false.</returns>
        public static bool IsEmail(this string input)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(input, pattern);
        }

        /// <summary>
        /// Determines whether the string represents a URL.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>True if the string represents a URL; otherwise, false.</returns>
        public static bool IsUrl(this string input)
        {
            Uri uriResult;
            return Uri.TryCreate(input, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        /// <summary>
        /// Determines whether the string represents an IP address.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>True if the string represents an IP address; otherwise, false.</returns>
        public static bool IsIPAddress(this string input)
        {
            string pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
            return Regex.IsMatch(input, pattern);
        }

        /// <summary>
        /// Safely parses the string representation of an integer.
        /// </summary>
        /// <param name="input">The string to parse.</param>
        /// <returns>The parsed integer value.</returns>
        public static int ToInt(this string input)
        {
            if (int.TryParse(input, out int result))
                return result;
            else
                throw new FormatException("Invalid integer format.");
        }

        /// <summary>
        /// Safely parses the string representation of a floating-point number.
        /// </summary>
        /// <param name="input">The string to parse.</param>
        /// <returns>The parsed floating-point value.</returns>
        public static float ToFloat(this string input)
        {
            if (float.TryParse(input, out float result))
                return result;
            else
                throw new FormatException("Invalid float format.");
        }

        /// <summary>
        /// Safely parses the string representation of a double-precision floating-point number.
        /// </summary>
        /// <param name="input">The string to parse.</param>
        /// <returns>The parsed double-precision floating-point value.</returns>
        public static double ToDouble(this string input)
        {
            if (double.TryParse(input, out double result))
                return result;
            else
                throw new FormatException("Invalid double format.");
        }

        /// <summary>
        /// Safely parses the string representation of a decimal number.
        /// </summary>
        /// <param name="input">The string to parse.</param>
        /// <returns>The parsed decimal value.</returns>
        public static decimal ToDecimal(this string input)
        {
            if (decimal.TryParse(input, out decimal result))
                return result;
            else
                throw new FormatException("Invalid decimal format.");
        }

        /// <summary>
        /// Safely parses the string representation of a boolean value.
        /// </summary>
        /// <param name="input">The string to parse.</param>
        /// <returns>The parsed boolean value.</returns>
        public static bool ToBool(this string input)
        {
            if (bool.TryParse(input, out bool result))
                return result;
            else
                throw new FormatException("Invalid boolean format.");
        }

        /// <summary>
        /// Safely parses the string representation of a DateTime value.
        /// </summary>
        /// <param name="input">The string to parse.</param>
        /// <returns>The parsed DateTime value.</returns>
        public static DateTime ToDateTime(this string input)
        {
            if (DateTime.TryParse(input, out DateTime result))
                return result;
            else
                throw new FormatException("Invalid DateTime format.");
        }

        /// <summary>
        /// Safely parses the string representation of a GUID.
        /// </summary>
        /// <param name="input">The string to parse.</param>
        /// <returns>The parsed GUID value.</returns>
        public static Guid ToGuid(this string input)
        {
            if (Guid.TryParse(input, out Guid result))
                return result;
            else
                throw new FormatException("Invalid GUID format.");
        }
    }
}
