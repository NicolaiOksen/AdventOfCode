using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day2
    {
        public IList<int[]> Table { get; }

        public Day2(IList<int[]> table)
        {
            Table = table;
        }

        public int CalculateChecksumOfTable()
        {
            return Table.Sum(GetDifferenceForRow);
        }

        private int GetDifferenceForRow(int[] row)
        {
            return row.Max() - row.Min();
        }

        public int GetDifferenceForRow(int rowIndex)
        {
            return GetDifferenceForRow(Table[rowIndex]);
        }

        private int FindEvenlyDivideForRow(int[] row)
        {
            var index = 0;

            while (index < row.Length)
            {
                var cell = row[index];
                var innerIndex = ++index;
                while (innerIndex < row.Length)
                {
                    var innerCell = row[innerIndex];
                    if (cell % innerCell == 0)
                    {
                        return cell / innerCell;
                    }
                    if (innerCell % cell == 0)
                    {
                        return innerCell / cell;
                    }
                    innerIndex++;
                }
            }

            return 0; // Should never get here.
        }

        public int FindEvenlyDivideForRow(int rowIndex)
        {
            return FindEvenlyDivideForRow(Table[rowIndex]);
        }

        public int CalculateChecksumOfEvenlyDivideForTable()
        {
            return Table.Sum(FindEvenlyDivideForRow);
        }

        public override string ToString()
        {
            return $"Day 2 of Christmas: Part 1: {CalculateChecksumOfTable()} and part 2: {CalculateChecksumOfEvenlyDivideForTable()}";
        }
    }
}
