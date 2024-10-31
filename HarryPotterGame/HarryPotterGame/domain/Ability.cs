using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterGame.domain
{
    internal class Ability
    {
        public int id {  get; set; }
        public string name { get; set; }    
        public int point { get; set; }

        public Ability(string name) {
            this.id = 0;
            this.name = name;
            this.point = 100;
        }
        public Ability(String name, int point)
        {
            this.id = 0;
            this.name = name;
            this.point = point;
        }
    }
}
