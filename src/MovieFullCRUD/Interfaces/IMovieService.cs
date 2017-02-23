using System.Collections.Generic;
using MovieFullCRUD.Models;

namespace MovieFullCRUD.Interfaces
{
    public interface IMovieService
    {
        void AddMovie(Movie mov);
        void DeleteMovie(int id);
        Movie GetMovie(int id);
        List<Movie> ListMovies();
        void EditMovie(Movie mov);
    }
}