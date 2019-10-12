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
            MovieDTO movieDTO = mapper.Map<MovieDTO>(await database.MovieRepository.GetById(id));
            return mapper.Map<MovieDTO>(await database.MovieRepository.GetById(id));
        }

        public IEnumerable<MovieDTO> GetMovieDTOs(ActorDTO actorDTO)
        {
            return mapper.Map<IEnumerable<MovieDTO>>(database.MovieRepository.GetMovies(mapper.Map<Actor>(actorDTO)));
        }

        public IEnumerable<MovieDTO> GetMovieDTOs(GenreDTO genreDTO)
        {
            return mapper.Map<IEnumerable<MovieDTO>>(database.MovieRepository.GetMovies(mapper.Map<Genre>(genreDTO)));
        }

        public IEnumerable<MovieDTO> GetMovieDTOs(ActorDTO actorDTO, GenreDTO genreDTO)
        {
            return mapper.Map<IEnumerable<MovieDTO>>(database
                                                        .MovieRepository
                                                        .GetMovies(mapper.Map<Actor>(actorDTO),mapper.Map<Genre>(genreDTO)));
        }
    }
}
