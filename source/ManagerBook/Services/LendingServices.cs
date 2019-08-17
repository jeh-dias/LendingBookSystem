
using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerBooks.Services
{
    /// <summary>
    /// Esta classe é responsável por receber dados de empréstimo que estão na camada de aplicação
    /// e enviar para a camada de negócios
    /// </summary>
    public class LendingServices : ILendingServices
    {
        private readonly ILendingBusines _lendingBusiness;
        private readonly ILendingRepository _lendingRepository;

        public LendingServices(ILendingBusines lendingBusiness, ILendingRepository lendingRepository)
        {
            _lendingBusiness = lendingBusiness;
            _lendingRepository = lendingRepository;
        }
        /// <summary>
        /// Este método conversa com a camada de negócio
        /// </summary>
        /// <param name="lending"></param>
        /// <returns></returns>
        public Lending Insert(Lending lending)
        {
            return _lendingBusiness.Insert(lending);
        }

        public Lending Update(Lending lending)
        {
            return _lendingBusiness.Update(lending);
        }
        public IEnumerable<Lending> GetAll()
        {
            return _lendingRepository.GetAll();
        }

        public Lending GetById(Guid id)
        {
            return _lendingRepository.GetById(id);
        }
    }
}
