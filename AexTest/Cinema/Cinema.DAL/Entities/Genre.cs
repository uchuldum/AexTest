using System;
using System.Collections.Generic;

namespace Cinema.DAL.Entities
{
    public partial class Genre
    {
        public Genre()
        {
            MoviesGenres = new HashSet<MoviesGenres>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MoviesGenres> MoviesGenres { get; set; }
    }
}
