﻿using System.Collections.Generic;
using MovieFullCRUD.Models;

namespace MovieFullCRUD.Intefaces
{
    public interface IMovieService
    {
        void AddMovie(Movie mov);
        void DeleteMovie(Movie mov);
        Movie GetMovie(int id);
        List<Movie> ListMovies();
        void UpdateMovie(Movie mov);
    }
}