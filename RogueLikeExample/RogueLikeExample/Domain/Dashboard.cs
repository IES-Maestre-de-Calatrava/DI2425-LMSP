using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeExample.Domain
{
    
    internal class Dashboard
    {
        
        private int Rows { get; set; }
        private int Columns { get; set; }
        private int Treasures { get; }
        private int Traps { get; }
        private char[,] Board { get; set; }
        public Dashboard(int N, int treasures, int traps)
        {
            Rows = N;
            Columns = N;
            Treasures = treasures;
            Traps = traps;
            Board = new char[Rows, Columns];
        }
        public void Initialize(Character c)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Board[i, j] = '-';
                }
            }
            InsertCharacter(c.Symbol);
            InsertTreasures();
            InsertTraps();
            Print();
        }
        private void InsertCharacter(char characterSymbol)
        {
            Random random = new Random();
            int row = random.Next(0, Rows);
            int column = random.Next(0, Columns);
            Board[row, column] = characterSymbol;
        }
        private void InsertTreasures()
        {
            Random random = new Random();
            int count = 0;
            while (count < Treasures)
            {
                int row = random.Next(0, Rows);
                int column = random.Next(0, Columns);
                if (Board[row, column] == '-')
                {
                    Board[row, column] = 't';
                    count++;
                }
            }
        }
        private void InsertTraps()
        {
            Random random = new Random();
            int count = 0;
            while (count < Traps)
            {
                int row = random.Next(0, Rows);
                int column = random.Next(0, Columns);
                if (Board[row, column] == '-')
                {
                    Board[row, column] = 'x';
                    count++;
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    switch(Board[i, j])
                    {
                        case 't':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 'x':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case '-':
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }
                    Console.Write(Board[i, j] + " ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }
        public void Move(Character c)
        {
            Console.WriteLine("Move your character (WASD):");
            char move = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int row = 0;
            int column = 0;
            FindCharacter(c.Symbol, ref row, ref column);
            switch (move)
            {
                case 'w':
                    if (row > 0)
                    {
                        Board[row, column] = '-';
                        ChangesToCharacter(c, row - 1, column);
                        Board[row - 1, column] = c.Symbol;
                    }
                    break;
                case 'a':
                    if (column > 0)
                    {
                        Board[row, column] = '-';
                        ChangesToCharacter(c, row, column - 1);
                        Board[row, column - 1] = c.Symbol;
                    }
                    break;
                case 's':
                    if (row < Rows - 1)
                    {
                        Board[row, column] = '-';
                        ChangesToCharacter(c, row + 1, column);
                        Board[row + 1, column] = c.Symbol;
                    }
                    break;
                case 'd':
                    if (column < Columns - 1)
                    {   
                        Board[row, column] = '-';
                        ChangesToCharacter(c, row, column + 1);
                        Board[row, column + 1] = c.Symbol;
                    }
                    break;
            }
            Print();
        }
        private void FindCharacter(char characterSymbol, ref int row, ref int column)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (Board[i, j] == characterSymbol)
                    {
                        row = i;
                        column = j;
                        return;
                    }
                }
            }
        }
        private void ChangesToCharacter(Character c, int row, int column)
        {
            if (Board[row, column] == 't')
            {
                c.Tresaures++;
            }
            else if (Board[row, column] == 'x')
            {
                c.Lives--;
            }
        }
    }
}
