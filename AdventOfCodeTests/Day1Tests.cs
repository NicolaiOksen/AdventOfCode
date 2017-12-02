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
    }
}
