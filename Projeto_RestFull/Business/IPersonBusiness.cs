using Projeto_RestFull.Data.VO;
using System.Collections.Generic;

namespace Projeto_RestFull.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO Update(PersonVO person);
        void Delete(long id);
        PersonVO FiendByID(long id);
        List<PersonVO> FiendAll();
    }
}
