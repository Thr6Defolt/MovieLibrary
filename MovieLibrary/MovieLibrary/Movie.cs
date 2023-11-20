using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    internal class Movie
    {
        public string Name { get; set; }
        public string Article { get; set; }
        public Movie(string article, string name)
        {
            Article = article;
            Name = name;
        }
    }
}
