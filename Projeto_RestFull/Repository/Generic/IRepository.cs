using Projeto_RestFull.Model;
using Projeto_RestFull.Model.Base;
using System.Collections.Generic;

namespace Projeto_RestFull.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        void Delete(long id);
        T FiendByID(long id);
        List<T> FiendAll();
        bool Exists(long id);
    }
}
