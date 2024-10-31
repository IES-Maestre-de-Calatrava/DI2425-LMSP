using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HarryPotterGame.domain
{
    internal class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public int point { get; set; }

        int idCounter { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="points"></param>
        public Character(int id,  String name, int points = 0)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show($"\"{nameof(name)}\" Can´t be null.",nameof(name));
                throw new ArgumentNullException($"\"{nameof(name)}\" Can´t be null.");
            }
            this.id = id;
            this.name = name;
            this.point = points;
            if(id > idCounter)
                idCounter = id;
        }
        public Character(String name, int points = 0)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show($"\"{nameof(name)}\" Can´t be null.", nameof(name));
                throw new ArgumentNullException($"\"{nameof(name)}\" Can´t be null.");
            }
            this.id = this.idCounter++;
            this.name = name;
            this.point = points;
        }

    }
}
