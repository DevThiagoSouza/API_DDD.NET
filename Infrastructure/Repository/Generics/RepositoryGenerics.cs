using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces.Generics;


namespace Infrastructure.Repository.Generics
{
    public class RepositoryGenerics<T> : IGeneric<T>, IDisposable where T : class
    {
        public Task Add(T Objeto)
        {
            throw new NotImplementedException();
        }

        public Task Update(T Objeto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T Objeto)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> List()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
