﻿using BlazorArchitecture.Server.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlazorArchitecture.Server.Repositories
{
    public class RepositoryBase<T> : IAsyncRepository<T> where T : class, new()
    {
        //protected readonly PedidosPacificoAzureContext _context;

        //public RepositoryBase(PedidosPacificoAzureContext context)
        //{
        //    _context = context ?? throw new ArgumentNullException(nameof(context));
        //}

        //public async Task<IReadOnlyList<T>> GetAllAsync()
        //{
        //    return await _context.Set<T>().ToListAsync();
        //}

        //public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        //{
        //    return await _context.Set<T>().Where(predicate).ToListAsync();
        //}

        //public async Task<IReadOnlyList<T>> GetAsyncById(Expression<Func<T, bool>> predicate)
        //{
        //    return await _context.Set<T>().Where(predicate).ToListAsync();
        //}

        //public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
        //                               Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //                               string includeString = null,
        //                               bool disableTracking = true)
        //{
        //    IQueryable<T> query = _context.Set<T>();
        //    if (disableTracking) query = query.AsNoTracking();

        //    if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);

        //    if (predicate != null) query = query.Where(predicate);

        //    if (orderBy != null)
        //        return await orderBy(query).ToListAsync();


        //    return await query.ToListAsync();
        //}

        //public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
        //                             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //                             List<Expression<Func<T, object>>> includes = null,
        //                             bool disableTracking = true)
        //{

        //    IQueryable<T> query = _context.Set<T>();
        //    if (disableTracking) query = query.AsNoTracking();

        //    if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

        //    if (predicate != null) query = query.Where(predicate);

        //    if (orderBy != null)
        //        return await orderBy(query).ToListAsync();


        //    return await query.ToListAsync();
        //}


        //public virtual async Task<T> GetByIdAsync(int id)
        //{
        //    return await _context.Set<T>().FindAsync(id);
        //}

        //public async Task<T> AddAsync(T entity)
        //{
        //    _context.Set<T>().Add(entity);
        //    await _context.SaveChangesAsync();
        //    return entity;
        //}

        //public async Task<T> UpdateAsync(T entity)
        //{
        //    _context.Set<T>().Attach(entity);
        //    _context.Entry(entity).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //    return entity;
        //}

        //public async Task DeleteAsync(T entity)
        //{
        //    _context.Set<T>().Remove(entity);
        //    await _context.SaveChangesAsync();
        //}

        //public void AddEntity(T entity)
        //{
        //    _context.Set<T>().Add(entity);
        //}

        //public void UpdateEntity(T entity)
        //{
        //    _context.Set<T>().Attach(entity);
        //    _context.Entry(entity).State = EntityState.Modified;
        //}

        //public void DeleteEntity(T entity)
        //{
        //    _context.Set<T>().Remove(entity);
        //}

        //public void SaveBatch(IEnumerable<T> itemList)
        //{
        //    //_context.ChangeTracker.Clear();

        //    _context.AddRange(itemList);

        //    _context.SaveChanges();
        //}

        //public void DeleteBatch(IEnumerable<T> itemList)
        //{

        //    _context.RemoveRange(itemList);

        //    _context.SaveChanges();

        //}

        //public void UpdateBatch(IEnumerable<T> itemList)
        //{
        //    _context.ChangeTracker.Clear();

        //    _context.UpdateRange(itemList);

        //    _context.SaveChanges();
        //}
        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void AddEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteBatch(IEnumerable<T> itemList)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<Expression<Func<T, object>>> includes = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAsyncById(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveBatch(IEnumerable<T> itemList)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateBatch(IEnumerable<T> itemList)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
