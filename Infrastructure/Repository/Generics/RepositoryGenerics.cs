using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces.Generics;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;


namespace Infrastructure.Repository.Generics
{
    public class RepositoryGenerics<T> : IGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<ContextBase> ContextOptions;

        public RepositoryGenerics()
        {
            ContextOptions = new DbContextOptions<ContextBase>();
        }

        public async Task Add(T Objeto)
        {
            using (var dt = new ContextBase(ContextOptions))
            {
                await dt.Set<T>().AddAsync(Objeto);
                await dt.SaveChangesAsync();
            }
        }

        public async Task Update(T Objeto)
        {
            using (var dt = new ContextBase(ContextOptions))
            {
                dt.Set<T>().Update(Objeto);
                await dt.SaveChangesAsync();
            }
        }

        public async Task Delete(T Objeto)
        {
            using (var dt = new ContextBase(ContextOptions))
            {
                dt.Set<T>().Remove(Objeto);
                await dt.SaveChangesAsync();
            }
        }

        public async Task<T> GetEntityById(int Id)
        {
            using (var dt = new ContextBase(ContextOptions))
            {
                return await dt.Set<T>().FindAsync(Id);
            }
        }

        public async Task<List<T>> List()
        {
            using (var dt = new ContextBase(ContextOptions))
            {
                return await dt.Set<T>().ToListAsync();
            }
        }
        
        // disposed padrao da da microsoft
        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        
        bool disposed = false;
        
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
            }

            disposed = true;
        }
        #endregion
    }
}
