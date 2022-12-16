using Projeto_RestFull.Model;
using System.Collections.Generic;

namespace Projeto_RestFull.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person Update(Person person);
        void Delete(long id);
        Person FiendByID(long id);
        List<Person> FiendAll();
    }
}
