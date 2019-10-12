using System;
using System.Collections.Generic;
using System.Text;
using Cinema.BLL.DTObjects;
using Cinema.DAL.Entities;
using AutoMapper;

namespace Cinema.BLL.Mapping
{
    public class ActorMapping: Profile
    {
        public ActorMapping()
        {
            CreateMap<Actor, ActorDTO>().ReverseMap();
        }
    }
}
