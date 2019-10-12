using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MovieApp.Data.Entities;
using MovieApp.BL.DTOs;

namespace MovieApp.BL
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            ActorMap();
            MovieMap();
            GenreMap();
        }
        private void ActorMap() 
        {
            CreateMap<Actor, ActorDTO>().ReverseMap();
        }
        private void MovieMap()
        {
            CreateMap<Movie, MovieDTO>().ReverseMap();
        }
        private void GenreMap()
        {
            CreateMap<Genre, GenreDTO>().ReverseMap();
        }
    }
}
