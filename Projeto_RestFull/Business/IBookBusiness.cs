using Projeto_RestFull.Data.VO;
using System.Collections.Generic;

namespace Projeto_RestFull.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO Update(BookVO book);
        void Delete(long id);
        BookVO FiendByID(long id);
        List<BookVO> FiendAll();
    }
}
