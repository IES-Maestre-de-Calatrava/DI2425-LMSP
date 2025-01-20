using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sudoku.Domain;

namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SudokuGrid sudoku = new SudokuGrid();
            sudoku.Print();
            SetValue(sudoku, 0, 0, 5);
            sudoku.Print();

        }
        private static void SetValue(SudokuGrid sudoku, int row, int col, int value)
        {
            sudoku.Board[row,col] = value;
        }
    }
}
