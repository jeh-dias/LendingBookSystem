using Domain;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    /// <summary>
    /// Esta classe é responsável por passar os dados do controller para o repositório
    /// </summary>
    public class DeliverServices : IDeliverServices
    {
        private readonly IDeliverRepository _deliverRepository;
        public DeliverServices(IDeliverRepository deliverRepository)
        {
            _deliverRepository = deliverRepository;
        }

        /// <summary>
        /// Este método é responsável por interagir com o repositório e receber todas as entregas
        /// que existem no banco de dados
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Deliver> GetAll()
        {
            return _deliverRepository.GetAll();
        }

        /// <summary>
        /// Este método é responsável por interagir com o repositório e receber a entrega
        /// correspondenete ao guid do banco de dados
        /// </summary>
        /// <returns></returns>
        public Deliver GetByKey(Guid key)
        {
            return _deliverRepository.GetByKey(key);
        }

        /// <summary>
        /// Este método é responsável por interagir com o repositório e inserir a entrega
        /// no banco de dados
        /// </summary>
        /// <returns></returns>
        public Deliver Insert(Deliver deliver)
        {
            deliver.key = Guid.NewGuid();
            return _deliverRepository.Insert(deliver);
        }

        /// <summary>
        /// Este método é responsável por interagir com o repositório e atualizar a entrega
        /// no banco de dados
        /// </summary>
        /// <returns></returns>
        public Deliver Update(Deliver deliver)
        {
            return _deliverRepository.Update(deliver);
        }
    }
}
