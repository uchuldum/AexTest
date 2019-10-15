using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Cinema.BLL.DTObjects;
using Cinema.BLL.Interfaces;
using Cinema.API.ViewModels;

namespace Cinema.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService service;
        private IMapper mapper;
        public MoviesController(IMovieService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null) return Ok(mapper.Map<IEnumerable<MovieViewModel>>(await service.GetAll()));
            return Ok(mapper.Map<MovieViewModel>(await service.GetById((int)id)));
        }

        [HttpGet]
        public async Task<IActionResult> GetByCondition([FromQuery]int[] genre, int actor)
        {
            IEnumerable<MovieViewModel> movies = mapper.Map<IEnumerable<MovieViewModel>>(await service.GetMovieDTOs(actor, genre));
            return Ok(movies);
        }

        [HttpGet]
        public async Task<IActionResult> GetByMovieName(string name)
        {   
            IEnumerable<MovieViewModel> movies = mapper.Map<IEnumerable<MovieViewModel>>(await service.GetMovieDTOs(name));
            if (movies == null) return BadRequest();
            return Ok(movies);
        }
    }
}