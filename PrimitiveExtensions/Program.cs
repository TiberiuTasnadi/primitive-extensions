using PrimitiveExtensions.Extensions;

namespace PrimitiveExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primitive Extensions\n");
            Console.WriteLine("****Int extensions****");
            // Example usage of extensions for int
            int number = 5;
            Console.WriteLine($"Is the number {number} even? {number.IsEven()}"); // Expected output: Is the number 5 even? False
            Console.WriteLine($"Is the number {number} odd? {number.IsOdd()}"); // Expected output: Is the number 5 odd? True
            Console.WriteLine($"The factorial of {number} is {number.Factorial()}"); // Expected output: The factorial of 5 is 120
            Console.WriteLine($"The ordinal form of {number} is {number.ToOrdinal()}"); // Expected output: The ordinal form of 5 is 5th
            Console.WriteLine($"Clamping {number} to the range 1-10: {number.Clamp(1, 10)}"); // Expected output: Clamping 5 to the range 1-10: 5
            Console.WriteLine($"Is the number {number} prime? {number.IsPrime()}"); // Expected output: Is the number 5 prime? False
            Console.WriteLine($"GCD of {number} and 15: {number.GCD(15)}"); // Expected output: GCD of 5 and 15: 5
            Console.WriteLine($"LCM of {number} and 15: {number.LCM(15)}"); // Expected output: LCM of 5 and 15: 15
            Console.WriteLine($"Binary representation of {number}: {number.ToBinaryString()}"); // Expected output: Binary representation of 5: 101
            Console.WriteLine($"Hexadecimal representation of {number}: {number.ToHexString()}"); // Expected output: Hexadecimal representation of 5: 5
            Console.WriteLine($"Sum of the digits of {number}: {number.DigitSum()}\n"); // Expected output: Sum of the digits of 5: 5

            Console.WriteLine("****String extensions****");
            // Example usage of extensions for string
            string palindrome = "radar";
            Console.WriteLine($"Is '{palindrome}' a palindrome? {palindrome.IsPalindrome()}"); // Expected output: Is 'radar' a palindrome? True

            string email = "example@email.com";
            Console.WriteLine($"Is '{email}' a valid email address? {email.IsEmail()}"); // Expected output: Is 'example@email.com' a valid email address? True

            string url = "https://www.example.com";
            Console.WriteLine($"Is '{url}' a valid URL? {url.IsUrl()}"); // Expected output: Is 'https://www.example.com' a valid URL? True

            string ipAddress = "192.168.0.1";
            Console.WriteLine($"Is '{ipAddress}' a valid IP address? {ipAddress.IsIPAddress()}"); // Expected output: Is '192.168.0.1' a valid IP address? True

            string numericString = "12345";
            Console.WriteLine($"Is '{numericString}' numeric? {numericString.IsNumeric()}"); // Expected output: Is '12345' numeric? True

            string integerString = "123";
            int integerValue = integerString.ToInt();
            Console.WriteLine($"Parsed integer value: {integerValue}"); // Expected output: Parsed integer value: 123

            string floatString = "3,14";
            float floatValue = floatString.ToFloat();
            Console.WriteLine($"Parsed float value: {floatValue}"); // Expected output: Parsed float value: 3.14

            string doubleString = "2,718";
            double doubleValue = doubleString.ToDouble();
            Console.WriteLine($"Parsed double value: {doubleValue}"); // Expected output: Parsed double value: 2.718

            string decimalString = "99,99";
            decimal decimalValue = decimalString.ToDecimal();
            Console.WriteLine($"Parsed decimal value: {decimalValue}"); // Expected output: Parsed decimal value: 99.99

            string boolString = "True";
            bool boolValue = boolString.ToBool();
            Console.WriteLine($"Parsed bool value: {boolValue}"); // Expected output: Parsed bool value: True

            string dateString = "2024-05-17";
            DateTime dateTimeValue = dateString.ToDateTime();
            Console.WriteLine($"Parsed DateTime value: {dateTimeValue}"); // Expected output: Parsed DateTime value: 5/17/2024 12:00:00 AM

            string guidString = "123e4567-e89b-12d3-a456-426614174000";
            Guid guidValue = guidString.ToGuid();
            Console.WriteLine($"Parsed GUID value: {guidValue}"); // Expected output: Parsed GUID value: 123e4567-e89b-12d3-a456-426614174000

            Console.ReadLine();

        }
    }
}
