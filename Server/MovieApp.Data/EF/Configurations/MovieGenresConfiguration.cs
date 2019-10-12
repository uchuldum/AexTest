using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.EF.Configurations
{
    public class MovieGenresConfiguration : IEntityTypeConfiguration<MovieGenres>
    {
        public void Configure(EntityTypeBuilder<MovieGenres> builder)
        {
            builder.ToTable("MovieGenres");

            builder.HasOne<Movie>()
                .WithMany(mg => mg.MovieGenres)
                .HasForeignKey(mg => mg.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MG_M");

            builder.HasOne<Genre>()
                .WithMany(mg => mg.MovieGenres)
                .HasForeignKey(mg => mg.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MG_G");
        }
    }
}
