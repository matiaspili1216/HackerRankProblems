using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/cavity-map/problem
    /// </summary>
    public class CavityMapResult
    {
        /*
         * Complete the 'cavityMap' function below.
         *
         * The function is expected to return a STRING_ARRAY.
         * The function accepts STRING_ARRAY grid as parameter.
         */

        public static List<string> CavityMap(List<string> grid)
        {

            List<Row> rows = GenerateRows(grid);
            List<Row> rowsFinValue = SetFinValue(rows);

            return rowsFinValue.Select(r => r.FinValues).ToList();
        }


        private static List<Row> SetFinValue(List<Row> rows)
        {

            foreach (var row in rows)
            {
                foreach (var cell in row.Cells)
                {
                    if (cell.IsBorder)
                    {
                        cell.FinValue = cell.Value.ToString();
                    }
                    else
                    {
                        if (rows.FirstOrDefault(r => r.IRow == cell.Row - 1).Cells.FirstOrDefault(c => c.Column == cell.Column).Value >= cell.Value) { cell.FinValue = cell.Value.ToString(); }
                        else if (rows.FirstOrDefault(r => r.IRow == cell.Row + 1).Cells.FirstOrDefault(c => c.Column == cell.Column).Value >= cell.Value) { cell.FinValue = cell.Value.ToString(); }
                        else if (rows.FirstOrDefault(r => r.IRow == cell.Row).Cells.FirstOrDefault(c => c.Column == cell.Column + 1).Value >= cell.Value) { cell.FinValue = cell.Value.ToString(); }
                        else if (rows.FirstOrDefault(r => r.IRow == cell.Row).Cells.FirstOrDefault(c => c.Column == cell.Column - 1).Value >= cell.Value) { cell.FinValue = cell.Value.ToString(); }
                        else { cell.FinValue = "X"; }
                    }
                }
            }

            return rows;
        }

        private static List<Cell> GenerateCells(string rowCells, int row, int borderValue)
        {
            int column = 0;

            List<Cell> cells = rowCells.Select(g =>
            {
                int valInRow = int.Parse(g.ToString());
                var cell = new Cell(row, column, valInRow, column == borderValue || row == borderValue || column == 0 || row == 0);
                column++;
                return cell;
            }).ToList();

            return cells;
        }

        private static List<Row> GenerateRows(List<string> grid)
        {
            int row = 0;
            int borderValue = grid.Count - 1;

            List<Row> rows = grid.Select(g =>
            {
                var cells = GenerateCells(g, row, borderValue);
                var r = new Row(row, cells);
                row++;
                return r;

            }).ToList();

            return rows;
        }
    }

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



    public class CavityMapSolution
    {
        public static void Solve()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            List<string> result = CavityMapResult.CavityMap(grid);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(String.Join("\n", result));
            Console.ReadLine();
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
