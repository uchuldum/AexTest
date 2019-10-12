using MovieApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Data.EF
{
    public static class DbInitilize
    {
        public static async Task Seed(MovieAppContext context)
        {
            try
            {
                _ = context.Database.EnsureCreated();
                if (!context.Actors.Any()) 
                {
                    context.Actors.AddRange(GetInitializeActors());
                    await context.SaveChangesAsync().ConfigureAwait(true);
                }

                if (!context.Genres.Any())
                {
                    context.Genres.AddRange(GetInitializeGenres());
                    await context.SaveChangesAsync().ConfigureAwait(true);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        static IEnumerable<Genre> GetInitializeGenres() =>
            new List<Genre>()
            {
                new Genre() { Name = "Боевик"},
                new Genre() { Name = "Комедия"},
                new Genre() { Name = "Драма"},
                new Genre() { Name = "Научная фантастика"}
            };

        static IEnumerable<Actor> GetInitializeActors() =>
            new List<Actor>()
            {
                new Actor() { Name = "Keanu Reeves" },
                new Actor() { Name = "Jackie Chan" },
                new Actor() { Name = "Bruce Willis" },
                new Actor() { Name = "Tom Cruise" },
                new Actor() { Name = "Jim Carrey" },
                new Actor() { Name = "Ken Watanabe" },
                new Actor() { Name = "Carrie-Anne Moss" },
                new Actor() { Name = "Laurence Fishborn" },
                new Actor() { Name = "Chris Tucker" }
            };
    }
}
