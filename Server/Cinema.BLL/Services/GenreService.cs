using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Cinema.BLL.DTObjects;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Interfaces;
using AutoMapper;
using System.Threading.Tasks;

namespace Cinema.BLL.Services
{
    public class GenreService: IGenreService
    {
        private readonly IUnitOfWork database;
        private readonly IMapper mapper;
        public GenreService(IUnitOfWork database, IMapper mapper)
        {
            this.database = database;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<GenreDTO>> GetAll()
        {
            return mapper.Map<IEnumerable<GenreDTO>>(await database.GenreRepository.GetAll());
        }

        public async Task<GenreDTO> GetById(int id)
        {
            return mapper.Map<GenreDTO>(await database.GenreRepository.GetById(id));
        }
    }
}
