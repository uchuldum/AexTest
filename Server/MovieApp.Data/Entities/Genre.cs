using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
