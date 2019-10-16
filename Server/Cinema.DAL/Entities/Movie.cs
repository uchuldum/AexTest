using System;
using System.Collections.Generic;

namespace Cinema.DAL.Entities
{
    public partial class Movie
    {
        public Movie()
        {
            MoviesActors = new HashSet<MoviesActors>();
            MoviesGenres = new HashSet<MoviesGenres>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RealeaseYear { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MoviesActors> MoviesActors { get; set; }
        public virtual ICollection<MoviesGenres> MoviesGenres { get; set; }
    }
}
