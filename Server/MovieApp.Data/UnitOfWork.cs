using MovieApp.Data.EF;
using MovieApp.Data.Interfaces;
using MovieApp.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieAppContext context;

        public IMovieRepository Movies { get; private set; }
        public IActorRepository Actors { get; private set; }
        public IGenreRepository Genres { get; set; }

        public UnitOfWork( MovieAppContext context)
        {
            this.context = context;
            Movies = new MovieRepository(this.context);
            Actors = new ActorRepository(this.context);
            Genres = new GenreRepository(this.context);
        }
        
        public int Save()
        {
            return context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
