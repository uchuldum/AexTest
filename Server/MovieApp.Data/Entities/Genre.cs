using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Entities
{
    public class Genre : BaseEntity
    {
        public Genre()
        {
            MovieGenres = new HashSet<MovieGenres>();
        }
        public string Name { get; set; }
        public IEnumerable<MovieGenres> MovieGenres { get; set; }
    }
}
