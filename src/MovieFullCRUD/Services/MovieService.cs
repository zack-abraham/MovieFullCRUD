using MovieFullCRUD.Interfaces;
using MovieFullCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFullCRUD.Services
{
    public class MovieService
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
    }
}
