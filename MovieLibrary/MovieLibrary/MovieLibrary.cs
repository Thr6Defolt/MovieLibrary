using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieLibrary
{
    internal class MovieLibrary
    {
        public Movie this[string article] {
            get
            {
                foreach (Movie movie in _ordinaryMovies)
                {
                    if (movie.Article == article)
                    {
                        return movie;
                    }
                }

                foreach (Movie movie in _onlyAdultMovies)
                {
                    if (movie.Article == article)
                    {
                        return movie;
                    }
                }
                
                return null;
            }
            set 
            {
                _onlyAdultMovies.Add(value);
                _ordinaryMovies.Add(value);
            }
        }

        List<Movie> _ordinaryMovies = new List<Movie>();
        List<Movie> _onlyAdultMovies = new List<Movie>();

        public void AddOrdinatyMovie(string movieTitle, string _article)
        {
            _ordinaryMovies.Add(new Movie(movieTitle, _article));
            Console.WriteLine($"{movieTitle}movie add");
        }

        public void AddOnlyAdultMovies(string movieTitle, string _article)
        {
            _onlyAdultMovies.Add(new Movie(movieTitle, _article));
            Console.WriteLine($"{movieTitle}movie add");
        }

        public string GetMovie(double time)
        {
            if(time >= 23.00 || time <= 7.00)
            {
                foreach (Movie movie in _onlyAdultMovies)
                {
                    Console.WriteLine($"{movie.Article}, {movie.Name}");
                }
            }
            else if(time <= 22.59 || time >= 7.01)
            {
                foreach (Movie movie in _ordinaryMovies)
                {
                    Console.WriteLine($"{movie.Article}, {movie.Name}");
                }
            }
            else if(time >= 24 || time <= -1)
            {
                Console.WriteLine("Erorr");
            }
            else
            {
                Console.WriteLine("Erorr");
            }
            return null;
        }
    }
}
