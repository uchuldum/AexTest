using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public IEnumerable<Actor> Actors {get; set;}
    }
}
