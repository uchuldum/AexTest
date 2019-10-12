using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.EF.Configurations
{
    public class ActorMoviesConfiguration : IEntityTypeConfiguration<ActorMovies>
    {
        public void Configure(EntityTypeBuilder<ActorMovies> builder)
        {
            builder.ToTable("ActorMovies");

            builder.HasOne<Actor>()
                .WithMany(am => am.ActorMovies)
                .HasForeignKey(am => am.ActorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AM_Actor");

            builder.HasOne<Movie>()
                .WithMany(am => am.ActorMovies)
                .HasForeignKey(am => am.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AM_Movie");
        }
    }
}
