using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ILendingServices
    {
        Lending Insert(Lending lending);
        Lending Update(Lending lending);
        IEnumerable<Lending> GetAll();

        Lending GetById(Guid id);
    }
}
