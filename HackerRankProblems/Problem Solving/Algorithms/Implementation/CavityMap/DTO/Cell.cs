namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.CavityMap.DTO
{
    public class Cell
    {
        public int Row { get; }
        public int Column { get; }
        public int Value { get; }
        public bool IsBorder { get; }

        public string FinValue { get; set; }

        public Cell(int row, int column, int value, bool isBorder)
        {
            Row = row;
            Column = column;
            Value = value;
            IsBorder = isBorder;
        }
    }
}
