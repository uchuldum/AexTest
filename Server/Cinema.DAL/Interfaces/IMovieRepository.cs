using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL.Entities;
namespace Cinema.DAL.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetMovies(int actor);
        Task<IEnumerable<Movie>> GetMovies(int[] genres);
        Task<IEnumerable<Movie>> GetMovies(int actor, int[] genres);
        Task<IEnumerable<Movie>> GetMovies(string name);
    }
}
