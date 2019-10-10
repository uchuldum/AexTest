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
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~UnitOfWork()
        // {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
