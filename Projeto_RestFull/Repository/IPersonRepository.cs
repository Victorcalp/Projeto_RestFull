using Projeto_RestFull.Model;
using System.Collections.Generic;

namespace Projeto_RestFull.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person Update(Person person);
        void Delete(long id);
        Person FiendByID(long id);
        List<Person> FiendAll();
        bool Exists(long id);
    }
}
