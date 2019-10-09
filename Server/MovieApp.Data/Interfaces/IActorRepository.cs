﻿using MovieApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Interfaces
{
    public interface IActorRepository : IRepository<Actor>
    {
        Actor GetActorWithMovies(int id);
    }
}
