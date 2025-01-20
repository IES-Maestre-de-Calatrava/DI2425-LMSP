using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeExample.Domain
{
    internal class Character
    {   
        private const int LIVES = 3;
        public string Name { get; set; }
        public int Lives { get; set; }
        public int Tresaures { get; set; }
        public char Symbol { get; set; }
        public Character(string name)
        {
            Name = name;
            Lives = LIVES;
            Tresaures = 0;
            char[] nameToChar = Name.ToUpper().ToCharArray();
            Symbol = nameToChar[0];
        }
    }
}
