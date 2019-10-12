using System;
using System.Collections.Generic;
using System.Text;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces;
using Cinema.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cinema.DAL.Repositories
{
    public class GenreRepository: Repository<Genre>, IGenreRepository
    {
        public GenreRepository(AEXTestDBContext context) : base(context)
        { }

        public AEXTestDBContext Context
        {
            get => Context as AEXTestDBContext;
        }
    }
}
