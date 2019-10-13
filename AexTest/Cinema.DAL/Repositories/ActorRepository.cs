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
    public class ActorRepository: Repository<Actor>, IActorRepository
    {
        public ActorRepository(AEXTestDBContext context) : base(context)
        { }

        public AEXTestDBContext Context
        {
            get => Context as AEXTestDBContext;
        }
    }
}
