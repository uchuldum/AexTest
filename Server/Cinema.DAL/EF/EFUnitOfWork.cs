using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL.Interfaces;
using Cinema.DAL.Repositories;

namespace Cinema.DAL.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AEXTestDBContext context;

        public IMovieRepository MovieRepository { get; private set; }

        public IGenreRepository GenreRepository { get; private set; }

        public IActorRepository ActorRepository { get; private set; }

        public EFUnitOfWork(AEXTestDBContext context)
        {
            this.context = context;
            MovieRepository = new MovieRepository(this.context);
            ActorRepository = new ActorRepository(this.context);
            GenreRepository = new GenreRepository(this.context);
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
