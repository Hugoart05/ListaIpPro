using DataBase.Config;
using DataBase.Repository.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repository.implementations
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly DbConfig _dbConfig;
        private readonly DbContext _context;

        protected RepositoryBase(DbConfig dbConfig, DbContext context)
        {
            _dbConfig = dbConfig;
            _context = context;
        }

        public async Task<T> Create(T entity)
        {
            var delete = _context.Entry(entity).State = EntityState.Added;

            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(T entity)
        {
            var delete  = _context.Entry(entity).State = EntityState.Deleted;

            if (entity == null)
            {
                return null;
            }

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
