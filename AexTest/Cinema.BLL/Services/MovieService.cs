using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Cinema.BLL.DTObjects;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Interfaces;
using Cinema.DAL.Entities;
using AutoMapper;
using System.Threading.Tasks;

namespace Cinema.BLL.Services
{
    public class MovieService: IMovieService
    {
        private readonly IUnitOfWork database;
        private readonly IMapper mapper;
        public MovieService(IUnitOfWork database, IMapper mapper) 
        {
            this.database = database;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<MovieDTO>> GetAll()
        {
            return mapper.Map<IEnumerable<MovieDTO>>(await database.MovieRepository.GetAll());
        }

        public async Task<MovieDTO> GetById(int id)
        {
            return mapper.Map<MovieDTO>(await database.MovieRepository.GetById(id));
        }

        private async Task<IEnumerable<MovieDTO>> GetMovieDTOs(int actors)
        {
            return mapper.Map<IEnumerable<MovieDTO>>(await database.MovieRepository.GetMovies(actors));
        }

        private async Task<IEnumerable<MovieDTO>> GetMovieDTOs(int[] genre)
        {
            return mapper.Map<IEnumerable<MovieDTO>>(await database.MovieRepository.GetMovies(genre));
        }

        public async Task<IEnumerable<MovieDTO>> GetMovieDTOs(string name)
        {
            if (name == null) return await GetAll();
            return mapper.Map<IEnumerable<MovieDTO>>(await database.MovieRepository.GetMovies(name.ToLower()));
        }

        public async Task<IEnumerable<MovieDTO>> GetMovieDTOs(int actor, int[] genres)
        {
            int isAllZero = 0;
            foreach (var genre in genres)
            {
                if (actor < 0) return null;
                isAllZero += genre;
            }
            if (isAllZero == 0)
                if (actor == 0)
                    return await GetAll();
                else return await GetMovieDTOs(actor);
            if(actor == 0)
                return await GetMovieDTOs(genres);
            return mapper.Map<IEnumerable<MovieDTO>>(await database
                                                            .MovieRepository
                                                            .GetMovies(actor, genres));
        }
    }
}
