using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL.Entities;
namespace Cinema.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IActorRepository ActorRepository { get; }
        IGenreRepository GenreRepository { get; }
        IMovieRepository MovieRepository { get; }
        Task Save();
    }
}
