using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinocchio
{
    internal class Player
    {
        #region Constants
        public const int LIVES = 10;
        public const int FINISH_BOX = 4;
        public const int FISHES_TO_FINISH = 5;
        #endregion
        #region Attributes
        private int lives;
        private int fishes;
        private int jumps;
        private char charact;
        private int posI;
        private int posJ;
        private string name;
        #endregion
        public Player(char charact, string name)
        {
            this.lives = LIVES;
            this.fishes = 0;
            this.jumps = 0;
            this.charact = charact;
            this.posI = 0;
            this.posJ = 0;
            this.name = name;
        }
        #region Getters & Setters
        public char Charact { get => charact;}
        public int Lives { get => lives; set => lives = value;}
        public int Fishes { get => fishes; set => fishes = value;}
        public int Jumps { get => jumps; set => jumps = value;} 
        public int PosI {  get => posI; set => posI = value;}
        public int PosJ { get => posJ; set => posJ = value;}
        public string Name {  get => name;}
        #endregion
        public Boolean IsWinner()
        {
            Boolean isWinner = false;
            if ((Fishes >= FISHES_TO_FINISH)&&(PosI == FINISH_BOX)&&(PosJ == FINISH_BOX))
            {
                isWinner = true;
                Console.WriteLine();
                Console.WriteLine(Name +" is the Winner!!!!!!");
            }
            return isWinner;
        }
    }
}
