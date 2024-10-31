using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MarioBrossWPF
{
    internal class Mario
    {
        private int lives;
        private int potions;
        public Mario(int lives, int potions)
        {
            this.lives = lives;
            this.potions = potions;
        }

        public int Lives { get => lives; set => lives = value; }
        public int Potions { get => potions; set => potions = value; }
        

    }
}
