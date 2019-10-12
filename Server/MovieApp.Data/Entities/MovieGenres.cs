using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Entities
{
    public class MovieGenres : BaseEntity
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
