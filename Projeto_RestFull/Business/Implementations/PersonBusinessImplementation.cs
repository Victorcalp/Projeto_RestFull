using Projeto_RestFull.Model;
using Projeto_RestFull.Repository;
using System.Collections.Generic;

namespace Projeto_RestFull.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Person> FiendAll()
        {
            return _repository.FiendAll();
        }

        public Person FiendByID(long id)
        {
            return _repository.FiendByID(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
