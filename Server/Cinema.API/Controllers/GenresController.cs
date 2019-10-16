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
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private IGenreService service;
        private IMapper mapper;
        public GenresController(IGenreService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null) return Ok(mapper.Map<IEnumerable<GenreViewModel>>(await service.GetAll()));
            return Ok(mapper.Map<GenreViewModel>(await service.GetById((int)id)));
        }
    }
}