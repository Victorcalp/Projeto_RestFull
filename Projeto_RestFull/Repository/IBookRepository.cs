using Projeto_RestFull.Model;
using System.Collections.Generic;

namespace Projeto_RestFull.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
        Book ListById(long id);
        List<Book> FiendAllBook();
        bool Exists(long id);
    }
}
