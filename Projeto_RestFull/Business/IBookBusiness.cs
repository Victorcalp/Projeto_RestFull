using Projeto_RestFull.Model;
using System.Collections.Generic;

namespace Projeto_RestFull.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
        Book FiendById(long id);
        List<Book> FiendAllBook();
    }
}
