using Microsoft.EntityFrameworkCore;
using Projeto_RestFull.Model;
using Projeto_RestFull.Model.Base;
using Projeto_RestFull.Model.Context;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_RestFull.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MySQLContext _context;
        private DbSet<T> dataset;

        public GenericRepository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }
        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public T Update(T item)
        {
            try
            {
                dataset.Update(item);
                _context.SaveChanges();
                return item;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(x => x.Id.Equals(id));

            if (!Exists(id)) new Person();
            try
            {
                dataset.Remove(result);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public List<T> FiendAll()
        {
            return dataset.ToList();
        }
        public T FiendByID(long id)
        {
            return dataset.SingleOrDefault(x => x.Id.Equals(id));
        }
        public bool Exists(long id)
        {
            return dataset.Any(x => x.Id.Equals(id));
        }
    }
}
