using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Cinema.DAL.Entities;

namespace Cinema.DAL.EF
{
    public partial class AEXTestDBContext : DbContext
    {
        public AEXTestDBContext()
        {
        }

        public AEXTestDBContext(DbContextOptions<AEXTestDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MoviesActors> MoviesActors { get; set; }
        public virtual DbSet<MoviesGenres> MoviesGenres { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Actors>(entity =>
            {
                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Genres>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RealeaseYear).HasColumnType("date");
            });

            modelBuilder.Entity<MoviesActors>(entity =>
            {
                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.MoviesActors)
                    .HasForeignKey(d => d.ActorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MoviesAct__Actor__29572725");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MoviesActors)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MoviesAct__Movie__2A4B4B5E");
            });

            modelBuilder.Entity<MoviesGenres>(entity =>
            {
                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.MoviesGenres)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MoviesGen__Genre__30F848ED");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MoviesGenres)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MoviesGen__Movie__31EC6D26");
            });
        }*/
    }
}
