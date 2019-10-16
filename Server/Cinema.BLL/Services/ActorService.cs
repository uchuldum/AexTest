using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Cinema.BLL.DTObjects;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Interfaces;
using AutoMapper;
using System.Threading.Tasks;
using Cinema.DAL.Entities;

namespace Cinema.BLL.Services
{
    public class ActorService: IActorService
    {
        private readonly IUnitOfWork database;
        private readonly IMapper mapper;
        public ActorService(IUnitOfWork database, IMapper mapper)
        {
            this.database = database;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ActorDTO>> GetAll()
        {
            return mapper.Map<IEnumerable<ActorDTO>>(await database.ActorRepository.GetAll());
        }

        public async Task<ActorDTO> GetById(int id)
        {
            return mapper.Map<ActorDTO>(await database.ActorRepository.GetById(id));
        }
    }
}
