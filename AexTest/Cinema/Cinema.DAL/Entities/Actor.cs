using System;
using System.Collections.Generic;

namespace Cinema.DAL.Entities
{
    public partial class Actor
    {
        public Actor()
        {
            MoviesActors = new HashSet<MoviesActors>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        public virtual ICollection<MoviesActors> MoviesActors { get; set; }
    }
}
