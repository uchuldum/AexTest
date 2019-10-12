using MovieApp.Data.EF;
using MovieApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Repositories
{
    public class MovieGenresRepository : Repository<MovieGenres>
    {
        public MovieGenresRepository(MovieAppContext context) : base(context)
        {
        }
    }
}
