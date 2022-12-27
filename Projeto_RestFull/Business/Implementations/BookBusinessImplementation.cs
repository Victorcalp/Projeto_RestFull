using Projeto_RestFull.Data.Converter.Implementations;
using Projeto_RestFull.Data.VO;
using Projeto_RestFull.Model;
using Projeto_RestFull.Repository;
using Projeto_RestFull.Repository.Generic;
using System.Collections.Generic;

namespace Projeto_RestFull.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }
        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
        public List<BookVO> FiendAll()
        {
            var result = _converter.Parse(_repository.FiendAll());
            return result;
        }
        public BookVO FiendByID(long id)
        {
            var result = _converter.Parse(_repository.FiendByID(id));
            return result;
        }
    }
}
