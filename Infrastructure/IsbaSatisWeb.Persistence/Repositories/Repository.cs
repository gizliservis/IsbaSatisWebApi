using IsbaSatisWeb.Application.Repositories;
using IsbaSatisWeb.Core.Domain.Entities.Common;
using IsbaSatisWeb.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IsbaSatisWebDbContext _context;

        public Repository(IsbaSatisWebDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAssync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAssync(List<T> entity)
        {
            await Table.AddRangeAsync(entity);
            return true;

        }
        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }
        public bool RemoveRange(List<T> entities)
        {
            Table.RemoveRange(entities);
            return true;
        }
        public async Task<bool> RemoveAsync(string id)
        {
            T model = await Table.FirstOrDefaultAsync(c => c.Id == Guid.Parse(id));
            return Remove(model);

        }

        public bool Update(T entity)
        {
            EntityEntry entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }
        public IQueryable<T> GetAll()
       => Table;

        public async Task<T> GetByIdAsync(string id)
       => await Table.FirstOrDefaultAsync(c => c.Id == Guid.Parse(id));

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> filter)
       => await Table.FirstOrDefaultAsync(filter);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter)
       => Table.Where(filter);

        public async Task<int> SaveAsync()
           => await _context.SaveChangesAsync();
    }
}
