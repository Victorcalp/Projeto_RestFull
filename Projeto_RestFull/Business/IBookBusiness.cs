using Projeto_RestFull.Model;
using Projeto_RestFull.Model.Base;
using System.Collections.Generic;

namespace Projeto_RestFull.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
        Book FiendByID(long id);
        List<Book> FiendAll();
    }
}
