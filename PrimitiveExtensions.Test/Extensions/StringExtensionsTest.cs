using Xunit;
using FluentAssertions;
using PrimitiveExtensions.Extensions;

namespace PrimitiveExtensions.Test.Extensions
{
    public class StringExtensionsTest
    {
        /// <summary>
        /// Tests the IsPalindrome method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("radar", true)]
        [InlineData("hello", false)]
        public void IsPalindrome_ReturnsExpected(string input, bool expected)
        {
            // Act
            var result = input.IsPalindrome();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the IsEmail method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("example@email.com", true)]
        [InlineData("example.com", false)]
        public void IsEmail_ReturnsExpected(string input, bool expected)
        {
            // Act
            var result = input.IsEmail();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the IsUrl method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("https://www.example.com", true)]
        [InlineData("example.com", false)]
        public void IsUrl_ReturnsExpected(string input, bool expected)
        {
            // Act
            var result = input.IsUrl();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the IsIPAddress method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("192.168.0.1", true)]
        [InlineData("example", false)]
        public void IsIPAddress_ReturnsExpected(string input, bool expected)
        {
            // Act
            var result = input.IsIPAddress();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the CountVowels method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("hello", 2)]
        [InlineData("world", 1)]
        public void CountVowels_ReturnsExpected(string input, int expected)
        {
            // Act
            var result = input.CountVowels();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the Reverse method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("hello", "olleh")]
        [InlineData("world", "dlrow")]
        public void Reverse_ReturnsExpected(string input, string expected)
        {
            // Act
            var result = input.Reverse();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the IsNullOrEmptyOrWhiteSpace method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData(null, true)]
        [InlineData("hello", false)]
        public void IsNullOrEmptyOrWhiteSpace_ReturnsExpected(string input, bool expected)
        {
            // Act
            var result = input.IsNullOrEmptyOrWhiteSpace();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the Truncate method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("hello world", 5)]
        [InlineData("example", 7)]
        public void Truncate_ReturnsExpected(string input, int maxLength)
        {
            // Act
            var result = input.Truncate(maxLength);

            // Assert
            result.Length.Should().BeLessOrEqualTo(maxLength);
        }

        /// <summary>
        /// Tests the ToTitleCase method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("hello world", "Hello World")]
        [InlineData("example", "Example")]
        public void ToTitleCase_ReturnsExpected(string input, string expected)
        {
            // Act
            var result = input.ToTitleCase();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the RemoveWhitespace method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("hello world", "helloworld")]
        [InlineData("example", "example")]
        public void RemoveWhitespace_ReturnsExpected(string input, string expected)
        {
            // Act
            var result = input.RemoveWhitespace();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the SplitCamelCase method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("camelCaseString", new[] { "camel", "Case", "String" })]
        [InlineData("exampleString", new[] { "example", "String" })]
        public void SplitCamelCase_ReturnsExpected(string input, string[] expected)
        {
            // Act
            var result = input.SplitCamelCase();

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        /// <summary>
        /// Tests the IsNumeric method.
        /// </summary>
        /// <param name="input">input value.</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData("123", true)]
        [InlineData("example", false)]
        public void IsNumeric_ReturnsExpected(string input, bool expected)
        {
            // Act
            var result = input.IsNumeric();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the ToInt method.
        /// </summary>
        [Fact]
        public void ToInt_ReturnsExpected()
        {
            // Arrange
            string input = "123";
            int expected = 123;

            // Act
            var result = input.ToInt();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the ToFloat method.
        /// </summary>
        [Fact]
        public void ToFloat_ReturnsExpected()
        {
            // Arrange
            string input = "3,14";
            float expected = 3.14f;

            // Act
            var result = input.ToFloat();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the ToDouble method.
        /// </summary>
        [Fact]
        public void ToDouble_ReturnsExpected()
        {
            // Arrange
            string input = "3,14";
            double expected = 3.14;

            // Act
            var result = input.ToDouble();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the ToDecimal method.
        /// </summary>
        [Fact]
        public void ToDecimal_ReturnsExpected()
        {
            // Arrange
            string input = "3,14";
            decimal expected = 3.14m;

            // Act
            var result = input.ToDecimal();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the ToBool method.
        /// </summary>
        [Fact]
        public void ToBool_ReturnsExpected()
        {
            // Arrange
            string input = "true";
            bool expected = true;

            // Act
            var result = input.ToBool();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the ToDateTime method.
        /// </summary>
        [Fact]
        public void ToDateTime_ReturnsExpected()
        {
            // Arrange
            string input = "2022-01-01";
            DateTime expected = new DateTime(2022, 1, 1);

            // Act
            var result = input.ToDateTime();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests the ToGuid method.
        /// </summary>
        [Fact]
        public void ToGuid_ReturnsExpected()
        {
            // Arrange
            string input = "123e4567-e89b-12d3-a456-426614174000";
            Guid expected = new Guid("123e4567-e89b-12d3-a456-426614174000");

            // Act
            var result = input.ToGuid();

            // Assert
            result.Should().Be(expected);
        }

        /// <summary>
        /// Tests that ToInt method throws exception.
        /// </summary>
        [Fact]
        public void ToInt_ThrowsFormatException()
        {
            // Arrange
            string input = "invalid-int";

            // Act
            Action action = () => input.ToInt();

            // Assert
            action.Should().Throw<FormatException>();
        }

        /// <summary>
        /// Tests that ToFloat method throws exception.
        /// </summary>
        [Fact]
        public void ToFloat_ThrowsFormatException()
        {
            // Arrange
            string input = "invalid-float";

            // Act
            Action action = () => input.ToFloat();

            // Assert
            action.Should().Throw<FormatException>();
        }

        /// <summary>
        /// Tests that ToDouble method throws exception.
        /// </summary>
        [Fact]
        public void ToDouble_ThrowsFormatException()
        {
            // Arrange
            string input = "invalid-double";

            // Act
            Action action = () => input.ToDouble();

            // Assert
            action.Should().Throw<FormatException>();
        }

        /// <summary>
        /// Tests that ToDecimal method throws exception.
        /// </summary>
        [Fact]
        public void ToDecimal_ThrowsFormatException()
        {
            // Arrange
            string input = "invalid-decimal";

            // Act
            Action action = () => input.ToDecimal();

            // Assert
            action.Should().Throw<FormatException>();
        }

        /// <summary>
        /// Tests that ToBool method throws exception.
        /// </summary>
        [Fact]
        public void ToBool_ThrowsFormatException()
        {
            // Arrange
            string input = "invalid-bool";

            // Act
            Action action = () => input.ToBool();

            // Assert
            action.Should().Throw<FormatException>();
        }

        /// <summary>
        /// Tests that ToDateTime method throws exception.
        /// </summary>
        [Fact]
        public void ToDateTime_ThrowsFormatException()
        {
            // Arrange
            string input = "invalid-date";

            // Act
            Action action = () => input.ToDateTime();

            // Assert
            action.Should().Throw<FormatException>();
        }

        /// <summary>
        /// Tests that ToGuid method throws exception.
        /// </summary>
        [Fact]
        public void ToGuid_ThrowsFormatException()
        {
            // Arrange
            string input = "invalid-guid";

            // Act
            Action action = () => input.ToGuid();

            // Assert
            action.Should().Throw<FormatException>();
        }
    }
}
