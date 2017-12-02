using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace AdventOfCodeTests
{
    public class Day2Tests
    {
        /*
         * 5 1 9 5
         * 7 5 3
         * 2 4 6 8
         * The first row's largest and smallest values are 9 and 1, and their difference is 8.
         * The second row's largest and smallest values are 7 and 3, and their difference is 4.
         * The third row's difference is 6.
         * In this example, the spreadsheet's checksum would be 8 + 4 + 6 = 18.
         */

        private IList<int[]> Table => new List<int[]>
        {
            new int[] {5, 1, 9, 5},
            new int[] {7, 5, 3},
            new int[] {2, 4, 6, 8}
        };

        [Fact]
        public void FirstRowsDifferenceIsEight()
        {
            var day2 = new Day2(Table);

            var result = day2.GetDifferenceForRow(0);

            Assert.Equal(8, result);
        }

        [Fact]
        public void SecondRowDifferenceIsFour()
        {
            var day2 = new Day2(Table);

            var result = day2.GetDifferenceForRow(1);

            Assert.Equal(4, result);
        }

        [Fact]
        public void ThirdRowDifferenceIsSix()
        {
            var day2 = new Day2(Table);

            var result = day2.GetDifferenceForRow(2);

            Assert.Equal(6, result);
        }

        [Fact]
        public void ChecksumIs18()
        {
            var day2 = new Day2(Table);

            var result = day2.CalculateChecksumOfTable();

            Assert.Equal(18, result);
        }

        // 5 9 2 8
        // 9 4 7 3
        // 3 8 6 5
        // In the first row, the only two numbers that evenly divide are 8 and 2; the result of this division is 4.
        // In the second row, the two numbers are 9 and 3; the result is 3.
        // In the third row, the result is 2.
        // In this example, the sum of the results would be 4 + 3 + 2 = 9.

        private IList<int[]> TablePartTwo => new List<int[]>
        {
            new int[] {5, 9, 2, 8},
            new int[] {9, 4, 7, 3},
            new int[] {3, 8, 6, 5}
        };

        [Fact]
        public void FirstRowDivisionIs4()
        {
            var day2 = new Day2(TablePartTwo);

            var result = day2.FindEvenlyDivideForRow(0);

            Assert.Equal(4, result);
        }

        [Fact]
        public void SecondRowDivisionIs3()
        {
            var day2 = new Day2(TablePartTwo);

            var result = day2.FindEvenlyDivideForRow(1);

            Assert.Equal(3, result);
        }

        [Fact]
        public void ThirdRowDivisionIs2()
        {
            var day2 = new Day2(TablePartTwo);

            var result = day2.FindEvenlyDivideForRow(2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void ChecksumIs9()
        {
            var day2 = new Day2(TablePartTwo);

            var result = day2.CalculateChecksumOfEvenlyDivideForTable();

            Assert.Equal(9, result);
        }
    }
}
