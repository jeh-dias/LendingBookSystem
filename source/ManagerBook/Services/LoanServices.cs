using Domain;
using ManagerBooks.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerBooks.Services
{
    /// <summary>
    /// Esta classe é responsável por receber dados de empréstimo que estão na camada de aplicação
    /// e enviar para a camada de negócios
    /// </summary>
    public class LoanServices : ILoanServices
    {
        /// <summary>
        /// Este método conversa com a camada de negócio
        /// </summary>
        /// <param name="loan"></param>
        /// <returns></returns>
        public Loan Insert(Loan loan)
        {
            throw new NotImplementedException();
        }
    }
}
