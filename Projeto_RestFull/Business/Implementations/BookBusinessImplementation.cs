using Projeto_RestFull.Model;
using Projeto_RestFull.Repository;
using System.Collections.Generic;

namespace Projeto_RestFull.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository)
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

        public List<Book> FiendAllBook()
        {
            return _repository.FiendAllBook();
        }

        public Book FiendById(long id)
        {
            return _repository.FiendById(id);
        }
    }
}
