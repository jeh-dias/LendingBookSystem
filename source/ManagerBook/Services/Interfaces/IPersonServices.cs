using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerBooks.Services.Interfaces
{
    /// <summary>
    /// Este é o contrato dos serviços disponíveis para a entidade pessoa
    /// </summary>
    public interface IPersonServices
    {
        bool Delete(Person Person);
        List<Person> GetAll();
        Person GetById(Guid guid);
        Person Insert(Person Person);
        Person Update(Person Person);
    }
}
