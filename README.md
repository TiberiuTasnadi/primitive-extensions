# .NET Primitive Extensions

This project provides a collection of extension methods for primitive types in .NET (such as `int`, `float`, `string`, etc.). These extensions are designed to enhance functionality and improve code readability.

## Features

- Extension methods for `int`, `float`, `string`, and more.
- Test methods to ensure the correct functionality of the extensions.
- Usage examples in a console application to demonstrate the utility of the extensions.

## Usage

### Extension Methods for `int`

| Method        | Description                                                  |
|---------------|--------------------------------------------------------------|
| `IsOdd`       | Determines whether the specified number is odd.              |
| `ToOrdinal`   | Converts the number to its ordinal representation.           |
| `Clamp`       | Restricts the number to a specified range.                   |
| `IsPrime`     | Determines whether the specified number is prime.            |
| `GCD`         | Calculates the greatest common divisor of the number.        |
| `LCM`         | Calculates the least common multiple of the number.          |
| `ToBinaryString` | Converts the number to its binary string representation.    |
| `ToHexString` | Converts the number to its hexadecimal string representation. |
| `DigitSum`    | Calculates the sum of the digits of the number.              |
| `Factorial`   | Calculates the factorial of the number. More info below

#### Factorial

The `Factorial` extension method calculates the factorial of the number. The factorial of a non-negative integer `n`, denoted as `n!`, is the product of all positive integers less than or equal to `n`. For example:
- The factorial of 0 is 1: `0! = 1`
- The factorial of 1 is 1: `1! = 1`
- The factorial of 2 is 2: `2! = 2 * 1 = 2`
- The factorial of 3 is 6: `3! = 3 * 2 * 1 = 6`
- The factorial of 4 is 24: `4! = 4 * 3 * 2 * 1 = 24`

This method can be useful in situations where you need to calculate combinations or permutations, as well as in mathematical problems and algorithms.

### Extension Methods for `string`

| Method            | Description                                                       |
|-------------------|-------------------------------------------------------------------|
| `IsPalindrome`   | Determines whether the specified string is a palindrome.          |
| `CountVowels`    | Counts the number of vowels in the string.                        |
| `RemoveWhitespace` | Removes all whitespace characters from the string.                |
| `SplitCamelCase` | Splits a CamelCase formatted string into words.                   |
| `IsNumeric`      | Determines whether the string represents a numeric value.         |
| `IsEmail`        | Determines whether the string represents an email address.        |
| `IsUrl`          | Determines whether the string represents a URL.                   |
| `IsIPAddress`    | Determines whether the string represents an IP address.           |
| `ToInt`          | Safely parses the string representation of an integer.            |
| `ToFloat`        | Safely parses the string representation of a floating-point number. |
| `ToDouble`       | Safely parses the string representation of a double-precision floating-point number. |
| `ToDecimal`      | Safely parses the string representation of a decimal number.      |
| `ToBool`         | Safely parses the string representation of a boolean value.       |
| `ToDateTime`     | Safely parses the string representation of a DateTime value.      |
| `ToGuid`         | Safely parses the string representation of a GUID.               |

## Contributing

Contributions to this repository are welcome! If you have any ideas for new extension methods or improvements to existing ones, feel free to open an issue or contact me via email: **ttasnadi.olivera@gmail.com**

