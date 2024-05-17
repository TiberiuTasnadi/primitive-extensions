using FluentAssertions;
using PrimitiveExtensions.Extensions;
using Xunit;

namespace PrimitiveExtensions.Test.Extensions
{
    public class IntExtensionsTest
    {
        [Fact]
        public void IsOdd_ShouldReturnTrueForOddNumbers()
        {
            3.IsOdd().Should().BeTrue();
            5.IsOdd().Should().BeTrue();
        }

        [Fact]
        public void IsOdd_ShouldReturnFalseForEvenNumbers()
        {
            2.IsOdd().Should().BeFalse();
            4.IsOdd().Should().BeFalse();
        }

        [Fact]
        public void ToOrdinal_ShouldReturnCorrectOrdinalString()
        {
            1.ToOrdinal().Should().Be("1st");
            2.ToOrdinal().Should().Be("2nd");
            3.ToOrdinal().Should().Be("3rd");
            4.ToOrdinal().Should().Be("4th");
            11.ToOrdinal().Should().Be("11th");
            12.ToOrdinal().Should().Be("12th");
            13.ToOrdinal().Should().Be("13th");
            21.ToOrdinal().Should().Be("21st");
            22.ToOrdinal().Should().Be("22nd");
            23.ToOrdinal().Should().Be("23rd");
        }

        [Fact]
        public void Clamp_ShouldClampValueWithinRange()
        {
            5.Clamp(1, 10).Should().Be(5);
            0.Clamp(1, 10).Should().Be(1);
            15.Clamp(1, 10).Should().Be(10);
        }

        [Fact]
        public void IsPrime_ShouldReturnTrueForPrimeNumbers()
        {
            2.IsPrime().Should().BeTrue();
            3.IsPrime().Should().BeTrue();
            5.IsPrime().Should().BeTrue();
            11.IsPrime().Should().BeTrue();
        }

        [Fact]
        public void IsPrime_ShouldReturnFalseForNonPrimeNumbers()
        {
            1.IsPrime().Should().BeFalse();
            4.IsPrime().Should().BeFalse();
            10.IsPrime().Should().BeFalse();
        }

        [Fact]
        public void GCD_ShouldReturnCorrectGCD()
        {
            10.GCD(15).Should().Be(5);
            17.GCD(19).Should().Be(1);
            54.GCD(24).Should().Be(6);
        }

        [Fact]
        public void LCM_ShouldReturnCorrectLCM()
        {
            10.LCM(15).Should().Be(30);
            17.LCM(19).Should().Be(323);
            4.LCM(5).Should().Be(20);
        }

        [Fact]
        public void ToBinaryString_ShouldReturnCorrectBinaryRepresentation()
        {
            5.ToBinaryString().Should().Be("101");
            15.ToBinaryString().Should().Be("1111");
            10.ToBinaryString().Should().Be("1010");
        }

        [Fact]
        public void ToHexString_ShouldReturnCorrectHexRepresentation()
        {
            5.ToHexString().Should().Be("5");
            15.ToHexString().Should().Be("f");
            255.ToHexString().Should().Be("ff");
        }

        [Fact]
        public void DigitSum_ShouldReturnCorrectSumOfDigits()
        {
            123.DigitSum().Should().Be(6);
            456.DigitSum().Should().Be(15);
            789.DigitSum().Should().Be(24);
        }

        [Fact]
        public void Factorial_ShouldReturnCorrectFactorial()
        {
            0.Factorial().Should().Be(1);
            1.Factorial().Should().Be(1);
            2.Factorial().Should().Be(2);
            3.Factorial().Should().Be(6);
            4.Factorial().Should().Be(24);
            5.Factorial().Should().Be(120);
        }

        [Fact]
        public void Factorial_ShouldThrowExceptionForNegativeNumbers()
        {
            Action act = () => (-1).Factorial();
            act.Should().Throw<ArgumentException>().WithMessage("Factorial is not defined for negative numbers.");
        }
    }
}
