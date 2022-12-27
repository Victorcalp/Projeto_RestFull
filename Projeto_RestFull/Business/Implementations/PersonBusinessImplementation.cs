using Projeto_RestFull.Data.Converter.Implementations;
using Projeto_RestFull.Data.VO;
using Projeto_RestFull.Model;
using Projeto_RestFull.Repository.Generic;
using System.Collections.Generic;

namespace Projeto_RestFull.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }
        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person); //converte de VO para entidade
            personEntity = _repository.Create(personEntity); 
            return _converter.Parse(personEntity);
        }
        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
        public List<PersonVO> FiendAll()
        {
            return _converter.Parse(_repository.FiendAll());
        }
        public PersonVO FiendByID(long id)
        {
            return _converter.Parse(_repository.FiendByID(id));
        }
    }
}
