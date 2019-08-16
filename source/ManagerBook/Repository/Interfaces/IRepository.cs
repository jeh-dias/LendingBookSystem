using ManagerBooks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerBooks.Repository.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        T Insert(T obj);
        bool Delete(T obj);
        List<T> GetAll();
        T Update(T obj);
        T GetByGuid(Guid guid);
    }
}
