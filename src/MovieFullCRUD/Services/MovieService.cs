using MovieFullCRUD.Interfaces;
using MovieFullCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFullCRUD.Services
{
    public class MovieService: IMovieService
    {
        private IGenericRepository _repo;

        public MovieService(IGenericRepository repo)
        {
            _repo = repo;
        }

        // lists all movies
        public List<Movie> ListMovies()
        {
            List<Movie> movies = (from m in _repo.Query<Movie>()
                                  select new Movie
                                  {
                                      Id = m.Id,
                                      Title = m.Title,
                                      Director = m.Director
                                  }).ToList();
            return movies;
        }

        // gets a single movie
        public Movie GetMovie(int id)
        {
            Movie movie = (from m in _repo.Query<Movie>()
                           where m.Id == id
                           select new Movie
                           {
                               Id = m.Id,
                               Title = m.Title,
                               Director = m.Director
                           }).FirstOrDefault();
            return movie;
        }

        public void AddMovie(Movie mov)
        {
            _repo.Add(mov);
        }

        public void EditMovie(Movie mov)
        {
            _repo.Update(mov);
        }

        public void DeleteMovie(int id)
        {
            Movie movToDelete = GetMovie(id);
            _repo.Delete(movToDelete);
        }
    }
}
