using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerBooks.Services.Interfaces
{
    /// <summary>
    /// Este é o contrato dos serviços disponíveis para a entidade empréstimo
    /// </summary>
    public interface ILoanServices
    {
        Loan Insert(Loan loan);
    }
}
