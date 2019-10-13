using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL.Entities;
namespace Cinema.DAL.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetMovies(Actor actor);
        Task<IEnumerable<Movie>> GetMovies(Genre genre);
        Task<IEnumerable<Movie>> GetMovies(Actor actor, Genre genre);
    }
}
