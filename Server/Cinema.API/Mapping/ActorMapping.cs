using System;
using System.Collections.Generic;
using System.Text;
using Cinema.BLL.DTObjects;
using Cinema.DAL.Entities;
using Cinema.API.ViewModels;
using AutoMapper;

namespace Cinema.API.Mapping
{
    public class ActorMapping: Profile
    {
        public ActorMapping()
        {
            CreateMap<Actor, ActorDTO>().ReverseMap();
            CreateMap<ActorDTO, ActorViewModel>().ReverseMap();
        }
    }
}
