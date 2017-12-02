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

        public override string ToString()
        {
            return $"Day 2 of Christmas: {CalculateChecksumOfTable()}";
        }
    }
}
