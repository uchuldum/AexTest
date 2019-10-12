using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.BL.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public string Description { get; set; }
        public IEnumerable<ActorDTO> Actors {get;set;}
        public IEnumerable<GenreDTO> Genre { get; set; }
    }
}
