using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioBros
{
    internal class Mario
    {
        private int vidas = 3;
        private int pocimas = 0;
        public Mario() {
        }
        public int getVidas()
        {
            return vidas;
        }
        public void setVidas(int vidas)
        {
            this.vidas = vidas;
        }
        public int getPocimas()
        {
            return pocimas;
        }
        public void setPocimas(int pocimas)
        {
            this.pocimas = pocimas;
        }

    }
}
