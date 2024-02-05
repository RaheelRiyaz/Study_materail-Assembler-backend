using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using StudyMaterial.Application.Abstractions.IRepository;
using StudyMaterial.Domain.Models;
using StudyMaterial.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity,new ()
    {
        private readonly StudyMaterialDbContext context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(StudyMaterialDbContext context)
        {
            this.context = context;
            _dbSet = context.Set<T>();
        }
        public async Task<int> AddAsync(T model)
        {
            _dbSet.Add(model);
            return await context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(T model)
        {
            _dbSet.Remove(model);
            return await context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            _dbSet.Remove(new T() { Id = id});
            return await context.SaveChangesAsync();
        }

        public async Task<int> DeleteRangeAsync(List<Guid> ids)
        {
            List<T> entities = new List<T>();
            foreach (Guid id in ids)
            {
                entities.Add(new T() { Id = id });
            }
            _dbSet.RemoveRange(entities);
            return await context.SaveChangesAsync();
        }

        public async Task<int> DeleteRangeAsync(List<T> models)
        {
            _dbSet.RemoveRange(models);
            return await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> Filter(Expression<Func<T, bool>> expression)
        {
            return await Task.Run(()=> _dbSet.Where(expression));
        }

        public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Task.Run(() => _dbSet);
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> InsertRange(List<T> models)
        {
           _dbSet.AddRange(models);
            return await context.SaveChangesAsync();
        }

        public async Task<bool> IsExists(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public async Task<int> UpdateAsync(T model)
        {
            _dbSet.Update(model);
            return await context.SaveChangesAsync();
        }
    }
}
