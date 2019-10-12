using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL.Entities;
namespace Cinema.DAL.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetMovies(Actor actor);
        IEnumerable<Movie> GetMovies(Genre genre);
        IEnumerable<Movie> GetMovies(Actor actor, Genre genre);
    }
}
