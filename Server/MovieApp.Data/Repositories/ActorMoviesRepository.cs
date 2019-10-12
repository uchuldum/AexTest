using MovieApp.Data.EF;
using MovieApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Repositories
{
    public class ActorMoviesRepository : Repository<ActorMovies>
    {
        public ActorMoviesRepository(MovieAppContext context) : base(context)
        {
        }
    }
}
