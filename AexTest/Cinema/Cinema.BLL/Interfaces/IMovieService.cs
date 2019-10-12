﻿using System;
using System.Collections.Generic;
using System.Text;
using Cinema.BLL.DTObjects;

namespace Cinema.BLL.Interfaces
{
    public interface IMovieService: IService<MovieDTO>
    {
        IEnumerable<MovieDTO> GetMovieDTOs(GenreDTO genreDTO);
        IEnumerable<MovieDTO> GetMovieDTOs(ActorDTO actorDTO);
        IEnumerable<MovieDTO> GetMovieDTOs(ActorDTO actorDTO, GenreDTO genreDTO);
    }
}