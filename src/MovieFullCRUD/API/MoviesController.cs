using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieFullCRUD.Data;
using MovieFullCRUD.Models;
using MovieFullCRUD.Interfaces;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieFullCRUD.API
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private IMovieService _movService;
        private ApplicationDbContext _db;

        [HttpGet]
        public List<Movie> Get()
        {
            return _movService.ListMovies();
        }

        //[HttpGet("{id}")]
        //public Movie Get(int id)
        //{
        //    return _movService.GetMovie(id);
        //}
        //[HttpPost]
        //[Authorize]
        //public IActionResult Post([FromBody]Movie mov)
        //{
        //    if (mov == null)
        //    {
        //        return BadRequest();
        //    }
        //    else if (mov.Id == 0)
        //    {
        //        ApplicationUser activeUser = (from u in _db.UsersTable
        //                                      where u.UserName == User.Identity.Name
        //                                      select u).FirstOrDefault();
        //        mov.User = activeUser;
        //        _db.Movies.Add(mov);
        //        _db.SaveChanges();
        //        return Ok();
        //    }
        //    else
        //    {
        //        _db.Movies.Update(mov);
        //        _db.SaveChanges();
        //        return Ok();
        //    }
        //}
        //[HttpPost]
        //public IActionResult Post([FromBody] Movie mov)
        //{
        //    if (mov == null)
        //    {
        //        return BadRequest();
        //    }
        //    else if (mov.Id == 0)
        //    {
        //        _movService.AddMovie(mov);
        //        return Ok();
        //    }
        //    else
        //    {
        //        _movService.EditMovie(mov);
        //        return Ok();
        //    }
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    _movService.DeleteMovie(id);
        //    return Ok();
        //}

        public MoviesController(IMovieService movService, ApplicationDbContext db)
        {
            _movService = movService;
            _db = db;
        }
    }
}
