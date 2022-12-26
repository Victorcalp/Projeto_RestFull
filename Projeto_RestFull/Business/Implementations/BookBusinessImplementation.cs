using Projeto_RestFull.Model;
using Projeto_RestFull.Repository;
using Projeto_RestFull.Repository.Generic;
using System.Collections.Generic;

namespace Projeto_RestFull.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }
        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        public List<Book> FiendAll()
        {
            return _repository.FiendAll();
        }

        public Book FiendByID(long id)
        {
            return _repository.FiendByID(id);
        }
    }
}
