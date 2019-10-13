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

       /* public AEXTestDBContext Context
        {
            get => Context as AEXTestDBContext;
        }*/

        /*Get movies by autor*/
        public async Task<IEnumerable<Movie>> GetMovies(Actor actor)
        {
            return await Context.Movies.Where(m => m.MoviesActors.Any(ma => ma.ActorId == actor.Id)).ToListAsync();
        }

        /*Get movies by genre*/
        public async Task<IEnumerable<Movie>> GetMovies(Genre genre)
        {
            return await Context.Movies.Where(m => m.MoviesGenres.Any(mg => mg.GenreId == genre.Id)).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetMovies(Actor actor, Genre genre)
        {
            return await Context.Movies.Where(m => m.MoviesGenres.Any(mg => mg.GenreId == genre.Id) &&
                                             m.MoviesActors.Any(ma => ma.ActorId == actor.Id)).ToListAsync();
        }
    }
}

