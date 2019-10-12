using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Entities
{
    public class Movie : BaseEntity
    {
        public Movie()
        {
            ActorMovies = new HashSet<ActorMovies>();
        }

        public string Name { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }
<<<<<<< HEAD
        public IEnumerable<Actor> Actors {get; set;}
=======

        public IEnumerable<ActorMovies> ActorMovies {get;set;}
        
>>>>>>> e7625f0dbb905a9e1bde876795c6edf232f25d4e
    }
}
