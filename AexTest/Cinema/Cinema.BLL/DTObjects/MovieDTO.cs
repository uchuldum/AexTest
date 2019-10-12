using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.BLL.DTObjects
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RealeaseYear { get; set; }
        public string Description { get; set; }
    }
}
