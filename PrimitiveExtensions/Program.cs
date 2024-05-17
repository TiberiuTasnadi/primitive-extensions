using PrimitiveExtensions.Extensions;

namespace PrimitiveExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage of extensions for int
            int number = 5;
            Console.WriteLine($"Is the number {number} even? {number.IsEven()}"); // False
            Console.WriteLine($"Is the number {number} odd? {number.IsOdd()}"); // True
            Console.WriteLine($"The factorial of {number} is {number.Factorial()}"); // 120
            Console.WriteLine($"The ordinal form of {number} is {number.ToOrdinal()}"); // 5th
            Console.WriteLine($"Clamping {number} to the range 1-10: {number.Clamp(1, 10)}"); // 5
            Console.WriteLine($"Is the number {number} prime? {number.IsPrime()}"); // False
            Console.WriteLine($"GCD of {number} and 15: {number.GCD(15)}"); // 5
            Console.WriteLine($"LCM of {number} and 15: {number.LCM(15)}"); // 15
            Console.WriteLine($"Binary representation of {number}: {number.ToBinaryString()}"); // 101
            Console.WriteLine($"Hexadecimal representation of {number}: {number.ToHexString()}"); // 5
            Console.WriteLine($"Sum of the digits of {number}: {number.DigitSum()}"); // 5
        }
    }
}
