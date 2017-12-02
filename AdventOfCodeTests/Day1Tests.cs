using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode;
using Xunit;

namespace AdventOfCodeTests
{
    public class Day1Tests
    {
        // 1122 produces a sum of 3 (1 + 2) because the first digit (1) matches the second digit and the third digit (2) matches the fourth digit.
        [Fact]
        public void OneOneTwoTwoSumOfThreeTest()
        {
            var day1 = new Day1("1122");

            var result = day1.GetCaptchaSolution();

            Assert.Equal("3", result);
        }

        // 1111 produces 4 because each digit(all 1) matches the next.
        [Fact]
        public void OneOneOneOneSumOfFourTest()
        {
            var day1 = new Day1("1111");

            var result = day1.GetCaptchaSolution();

            Assert.Equal("4", result);
        }

        // 1234 produces 0 because no digit matches the next.
        [Fact]
        public void OneTwoThreeFourSumOfZeroTest()
        {
            var day1 = new Day1("1234");

            var result = day1.GetCaptchaSolution();

            Assert.Equal("0", result);
        }

        // 91212129 produces 9 because the only digit that matches the next one is the last digit, 9.
        [Fact]
        public void _91212129SumOfNineTest()
        {
            var day1 = new Day1("91212129");

            var result = day1.GetCaptchaSolution();

            Assert.Equal("9", result);
        }

        // 1212 produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead.
        [Fact]
        public void _1212SumOf6Test()
        {
            var day1 = new Day1("1212");

            var result = day1.GetCaptchaHalfwayAroundSolution();

            Assert.Equal("6", result);
        }
        // 1221 produces 0, because every comparison is between a 1 and a 2.
        [Fact]
        public void _1221SumOfZeroTest()
        {
            var day1 = new Day1("1221");

            var result = day1.GetCaptchaHalfwayAroundSolution();

            Assert.Equal("0", result);
        }
        // 123425 produces 4, because both 2s match each other, but no other digit has a match.
        [Fact]
        public void _123425SumOf4Test()
        {
            var day1 = new Day1("123425");

            var result = day1.GetCaptchaHalfwayAroundSolution();

            Assert.Equal("4", result);
        }
        // 123123 produces 12.
        [Fact]
        public void _123123SumOf12Test()
        {
            var day1 = new Day1("123123");

            var result = day1.GetCaptchaHalfwayAroundSolution();

            Assert.Equal("12", result);
        }
        // 12131415 produces 4.
        [Fact]
        public void _12131415SumOf4Test()
        {
            var day1 = new Day1("12131415");

            var result = day1.GetCaptchaHalfwayAroundSolution();

            Assert.Equal("4", result);
        }
    }
}
