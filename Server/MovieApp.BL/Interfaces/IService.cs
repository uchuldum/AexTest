using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.BL.Interfaces
{
    public interface IService<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> Find(string name);
        IEnumerable<TEntity> GetAll();
        void GetById(int id);
    }
}
