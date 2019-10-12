using System;
using System.Collections.Generic;
using System.Text;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces;
using Cinema.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Cinema.DAL.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(AEXTestDBContext context) : base(context)
        { }

        public AEXTestDBContext Context
        {
            get => Context as AEXTestDBContext;
        }

        /*Get movies by autor*/
        public IEnumerable<Movie> GetMovies(Actor actor)
        {
            return Context.Movies.Include(m => m.MoviesActors.Where(ma => ma.ActorId == actor.Id));
        }

        /*Get movies by genre*/
        public IEnumerable<Movie> GetMovies(Genre genre)
        {
            return Context.Movies.Include(m => m.MoviesGenres.Where(mg => mg.GenreId == genre.Id));
        }

        public IEnumerable<Movie> GetMovies(Actor actor, Genre genre)
        {
            return Context.Movies.Include(m => m.MoviesGenres.Where(mg => mg.GenreId == genre.Id))
                                 .Include(m => m.MoviesActors.Where(ma => ma.ActorId == actor.Id));
        }
    }
}

