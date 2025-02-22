using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingClub.Domain
{
    class Book
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PYear { get; set; }

        public Book(string genre, string title, string author, int pYear)
        {
            Genre = genre;
            Title = title;
            Author = author;
            PYear = pYear;
        }
    }
}
