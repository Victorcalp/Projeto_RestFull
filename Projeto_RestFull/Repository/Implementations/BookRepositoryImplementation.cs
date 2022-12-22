using Projeto_RestFull.Model;
using Projeto_RestFull.Model.Context;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_RestFull.Repository.Implementations
{
    public class BookRepositoryImplementation : IBookRepository
    {
        private readonly MySQLContext _context;

        public BookRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Book Create(Book book)
        {
            try
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return book;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public Book Update(Book book)
        {
            try
            {
                _context.Books.Update(book);
                _context.SaveChanges();
                return book;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void Delete(long id)
        {
            var result = _context.Books.FirstOrDefault(x => x.Id == id);

            if (!Exists(id)) new Book();
            try
            {
                _context.Books.Remove(result);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public List<Book> FiendAllBook()
        {
            return _context.Books.ToList();
        }

        public Book ListById(long id)
        {
            return _context.Books.FirstOrDefault(x => x.Id == id);
        }

        public bool Exists(long id)
        {
            return _context.Books.Any(x => x.Id.Equals(id));
        }
    }
}
