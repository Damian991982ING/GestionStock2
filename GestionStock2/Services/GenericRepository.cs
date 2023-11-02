using GestionStock2.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionStock2.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected GestionStockDBContext _dbContext;

        internal DbSet<T> DBSet { get; set; }

        public GenericRepository(GestionStockDBContext dbContext)
        {
            this._dbContext = dbContext;
            this.DBSet = this._dbContext.Set<T>();
        }

        public virtual Task<bool> AddEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> GetAllAsync()
        {
            return this.DBSet.ToListAsync();
        }

        public virtual Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
