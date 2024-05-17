# .NET Primitive Extensions

This project provides a collection of extension methods for primitive types in .NET (such as `int`, `float`, `string`, etc.). These extensions are designed to enhance functionality and improve code readability.

## Features

- Extension methods for `int`, `float`, `string`, and more.
- Test methods to ensure the correct functionality of the extensions.
- Usage examples in a console application to demonstrate the utility of the extensions.

## Usage
## Extension Methods for `int`

### IsOdd

The `IsOdd` extension method determines whether the specified number is odd.

### ToOrdinal

The `ToOrdinal` extension method converts the number to its ordinal representation. For example, `1` becomes `"1st"`, `2` becomes `"2nd"`, `3` becomes `"3rd"`, and so on.

### Clamp

The `Clamp` extension method restricts the number to a specified range.

### IsPrime

The `IsPrime` extension method determines whether the specified number is prime.

### GCD

The `GCD` extension method calculates the greatest common divisor (GCD) of the number and another number.

### LCM

The `LCM` extension method calculates the least common multiple (LCM) of the number and another number.

### ToBinaryString

The `ToBinaryString` extension method converts the number to its binary string representation.

### ToHexString

The `ToHexString` extension method converts the number to its hexadecimal string representation.

### DigitSum

The `DigitSum` extension method calculates the sum of the digits of the number.

### Factorial

The `Factorial` extension method calculates the factorial of the number. The factorial of a non-negative integer `n`, denoted as `n!`, is the product of all positive integers less than or equal to `n`. For example:
- The factorial of 0 is 1: `0! = 1`
- The factorial of 1 is 1: `1! = 1`
- The factorial of 2 is 2: `2! = 2 * 1 = 2`
- The factorial of 3 is 6: `3! = 3 * 2 * 1 = 6`
- The factorial of 4 is 24: `4! = 4 * 3 * 2 * 1 = 24`

This method can be useful in situations where you need to calculate combinations or permutations, as well as in mathematical problems and algorithms.
