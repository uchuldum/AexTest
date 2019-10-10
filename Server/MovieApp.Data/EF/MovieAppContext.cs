using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Data.EF.Configurations;
using MovieApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.EF
{
    public class MovieAppContext : DbContext
    {
        public MovieAppContext(DbContextOptions<MovieAppContext> options) : base(options)
        { } 
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ActorMovies> ActorMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (builder != null)
            {
                base.OnModelCreating(builder);
                AddEntityConfigurations(builder);
            }
        }

        private void AddEntityConfigurations(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ActorConfiguration());
            builder.ApplyConfiguration(new MovieConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new ActorMoviesConfiguration());
        }
        
    }
}
