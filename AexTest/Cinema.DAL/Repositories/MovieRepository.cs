using System;
using System.Collections.Generic;
using System.Text;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces;
using Cinema.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.DAL.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private readonly AEXTestDBContext Context;
        public MovieRepository(AEXTestDBContext context) : base(context)
        {
            Context = context;
        }

        /*Get movies by autor*/
        public async Task<IEnumerable<Movie>> GetMovies(int actor)
        {
            return await Context.Movies.Where(m => m.MoviesActors.Any(ma => ma.ActorId == actor)).ToListAsync();
        }

        /*Get movies by genres*/
        public async Task<IEnumerable<Movie>> GetMovies(int[] genres)
        {
            IQueryable<Movie> movies = Context.Movies;
            foreach (var genreId in genres)
                movies = movies.Include(m => m.MoviesActors).Where(m => m.MoviesGenres.Any(g => g.GenreId == genreId));
            return await movies.ToListAsync();
        }
        
        /*Get movies by genres and actor*/
        public async Task<IEnumerable<Movie>> GetMovies(int actor, int[] genres)
        {
            IEnumerable<Movie> movies = await GetMovies(genres);
            return movies.Where(m => m.MoviesActors.Any(ma => ma.ActorId == actor)).ToList();
        }

        /*Get movies by name*/
        public async Task<IEnumerable<Movie>> GetMovies(string name)
        {
            return await Context.Movies.Where(m => m.Name.ToLower().StartsWith(name)).ToListAsync();
        }
    }
}

