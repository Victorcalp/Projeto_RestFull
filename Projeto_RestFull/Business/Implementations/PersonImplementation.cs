using Projeto_RestFull.Model;
using Projeto_RestFull.Model.Context;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_RestFull.Business.Implementations
{
    public class PersonImplementation : IPerson
    {
        private readonly MySQLContext _context;

        public PersonImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Person.Add(person);
                _context.SaveChanges();
                return person;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void Delete(long id)
        {
            var result = _context.Person.FirstOrDefault(x => x.Id.Equals(id));

            if (!Exists(id)) new Person();

            try
            {
                _context.Person.Remove(result);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<Person> FiendAll()
        {
            return _context.Person.ToList();
        }

        public Person FiendByID(long id)
        {
            return (_context.Person.FirstOrDefault(x => x.Id == id));
        }

        public Person Update(Person person)
        {
            try
            {
                _context.Person.Update(person);
                _context.SaveChanges();
                return person;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public bool Exists(long id)
        {
            return _context.Person.Any(p => p.Id.Equals(id));
        }
    }
}
