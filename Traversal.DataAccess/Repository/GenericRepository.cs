using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;

namespace Traversal.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        protected readonly AppDbContext _appDbContext;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = appDbContext.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
            _appDbContext.SaveChanges();
            
        }

        public void Delete(T item)
        {
            _dbSet.Remove(item);
            _appDbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
           return _dbSet.Where(filter).ToList();
        }

        public void Update(T item)
        {
            _dbSet.Update(item);
            _appDbContext.SaveChanges();
        }
    }
}
