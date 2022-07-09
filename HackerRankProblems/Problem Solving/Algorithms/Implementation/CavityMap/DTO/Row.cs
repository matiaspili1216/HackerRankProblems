using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.CavityMap.DTO
{
    public class Row
    {
        public int IRow { get; }
        public List<Cell> Cells { get; }

        public string FinValues => string.Join("", Cells.Select(c => c.FinValue));

        public Row(int iRow, List<Cell> cells)
        {
            IRow = iRow;
            Cells = cells;
        }
    }
}
