using System;
using System.Collections.Generic;
using System.Text;
using Cinema.BLL.DTObjects;
using Cinema.DAL.Entities;
using Cinema.API.ViewModels;
using AutoMapper;

namespace Cinema.API.Mapping
{
    public class MovieMapping: Profile
    {
        public MovieMapping()
        {
            CreateMap<Movie, MovieDTO>().ReverseMap();
            CreateMap<MovieDTO, MovieViewModel>().ReverseMap();
        }
    }
}
