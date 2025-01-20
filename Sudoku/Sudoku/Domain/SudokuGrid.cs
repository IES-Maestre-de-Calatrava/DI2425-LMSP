using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Domain
{

    internal class SudokuGrid
    {
        private const int SIZE = 9;
        public int[,] Board { get; set; }
        public SudokuGrid()
        {
            Board = new int[SIZE, SIZE];
            Initialice();
        }
        private void Initialice()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    Board[i, j] = 0;
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    Console.Write(Board[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
