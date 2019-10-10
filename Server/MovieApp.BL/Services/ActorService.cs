using MovieApp.BL.DTOs;
using MovieApp.BL.Interfaces;
using MovieApp.Data.Entities;
using MovieApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MovieApp.BL;
using System.Linq;

namespace MovieApp.BL.Services
{
    public class ActorService : IActorService
    {
        private IUnitOfWork Db { get; set; }
        private readonly IMapper mapper;

        public ActorService(IUnitOfWork uow, IMapper mapper)
        {
            Db = uow;
            this.mapper = mapper;
        }

        public IEnumerable<ActorDTO> Find(string name)
        {
            return null;
        }

        public IEnumerable<ActorDTO> GetAll() =>
            mapper.Map<IEnumerable<Actor>, IEnumerable<ActorDTO>>(Db.Actors.GetAll());

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
