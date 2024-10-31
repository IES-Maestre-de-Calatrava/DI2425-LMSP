using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pinocchio
{
    internal class Dashboard
    {
        #region Constants
        public const int MAX_JUMPS = 18;
        #endregion
        #region Attributes
        private int rows;
        private int columns;
        private string[,] dash;
        #endregion

        static Random rnd = new Random(DateTime.Now.Millisecond);
        public Dashboard(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.dash = new string[rows, columns];
        }
        #region Getters
        public int Rows { get => rows;}
        public int Columns { get => columns;}
        #endregion
        public void InitDash()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    dash[i, j] = rnd.Next(0,4) +"";
                }
            }
        }
        public void SeekBox(Player p)
        {
            int surprise = Int32.Parse(dash[p.PosI, p.PosJ]);
            switch (surprise)
            {
                case 0:p.Lives--;break;//piranha
                case 1:break;//river
                case 2:if(p.Fishes > 0)p.Fishes--;break;//stone
                case 3:p.Fishes++; break;//fish
            }
            Console.Write(" (" + p.PosI + "," + p.PosJ + ")");
            p.Jumps++;
        }
        public void JumpToDash(Player p) 
        {   
            SeekBox(p);
            dash[p.PosI, p.PosJ] = p.Charact+"";
        }
        public int RndMovement()
        {
            int option = rnd.Next(1,5);
            return option; 
        }
        public void MakeMovement(Player p)
        {
            switch (RndMovement())
            {
                case 1:
                    {
                        if (p.PosJ +1 < Rows)
                        {   
                            dash[p.PosI, p.PosJ] = rnd.Next(0, 4)+"";
                            p.PosJ++;
                            SeekBox(p);
                            dash[p.PosI, p.PosJ] = p.Charact + "";
                        }
                        break;
                    }
                case 2:
                    {
                        if (p.PosJ -1 >= 0)
                        {
                            dash[p.PosI, p.PosJ] = rnd.Next(0, 4) + "";
                            p.PosJ--;
                            SeekBox(p);
                            dash[p.PosI, p.PosJ] = p.Charact + "";
                        }
                        break;
                    }
                    
                case 3:
                    {
                        if (p.PosI -1 >= 0)
                        {
                            dash[p.PosI, p.PosJ] = rnd.Next(0, 4) + "";
                            p.PosI--;
                            SeekBox(p);
                            dash[p.PosI, p.PosJ] = p.Charact + "";
                        }
                        break;
                    }
                case 4:
                    {
                        if (p.PosI +1 < Columns)
                        {
                            dash[p.PosI, p.PosJ] = rnd.Next(0, 4) + "";
                            p.PosI++;
                            SeekBox(p);
                            dash[p.PosI, p.PosJ] = p.Charact + "";
                        }
                        break;
                    }
            }

        }
        public void GameOfPlayer(Player p)
        {
            Console.Write(p.Name + ": ");
            JumpToDash(p);
            
            while ((p.Lives > 0) && (p.Jumps < MAX_JUMPS) && (!p.IsWinner()))
            {
                MakeMovement(p);
                
              
                if (p.Jumps == MAX_JUMPS)
                {
                    Console.WriteLine();
                    Console.WriteLine(p.Name + " drowned.");
                }
                else if (p.Lives == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(p.Name + " died.");
                }
            }
            dash[p.PosI, p.PosJ] = rnd.Next(0, 4) + "";
            Console.WriteLine(p.Name + " caught " + p.Fishes + " fishes.");
        }

    }
    
}
