namespace MovieLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieLibrary movieLibrary = new MovieLibrary();

            movieLibrary.AddOrdinatyMovie("Pig Pepa", "1234");
            movieLibrary.AddOrdinatyMovie("War Craft", "9090");
            movieLibrary.AddOnlyAdultMovies("50 gray shades", "5678");
            movieLibrary.AddOnlyAdultMovies("Jon Wik", "228");

            movieLibrary.GetMovie(14.59);

            movieLibrary.GetMovie(23.49);
        }
    }
}