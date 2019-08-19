using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ILendingBusiness
    {
        Lending Insert(Lending lending);

        Lending Update(Lending lending);
    }
}
