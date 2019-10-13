using System;
using System.Collections.Generic;
using System.Text;
using Cinema.BLL.DTObjects;
using Cinema.DAL.Entities;
using Cinema.API.ViewModels;
using AutoMapper;

namespace Cinema.API.Mapping
{
    public class GenreMapping : Profile
    {
        public GenreMapping()
        {
            CreateMap<Genre, GenreDTO>().ReverseMap();
            CreateMap<GenreDTO, GenreViewModel>().ReverseMap();
        }
    }
}
