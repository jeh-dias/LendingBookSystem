
using Domain;
using ManagerBooks.Repository.Interfaces;
using ManagerBooks.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerBooks.Services
{
    /// <summary>
    /// Esta classe é responsável por receber dados da entidade pessoa que estão na camada de aplicação
    /// e enviar para a camada de repositório. 
    /// A camada de negócio não existe para esta entidade,  pois não há regras de negócio, somente 
    /// as funcionalidades de cadastro
    /// </summary>
    public class PersonServices : IPersonServices
    {
        private readonly IPersonRepository _personRepository;
        public PersonServices(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        /// <summary>
        /// Este método é responsável por enviar o objeto
        /// para o repositório remover do banco de dados
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool Delete(Person person)
        {
            return _personRepository.Delete(person);
        }

        /// <summary>
        ///  Este método é responsável por interagir com o repositório
        ///  e pedir a lista de todas as pessoas que foram inseridas no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        /// <summary>
        /// Este método é responsável por receber um identificador de uma pessoa
        /// e pedir o objeto desta pessoa para o repositório
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Person GetById(Guid id)
        {
            return _personRepository.GetById(id);
        }

        /// <summary>
        /// Este método é responsável  por receber dados da pessoa
        /// e enviar para o repositório inserir no banco de dados
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Person Insert(Person person)
        {
            return _personRepository.Insert(person);
        }

        /// <summary>
        /// Este método é responsável  por receber dados da pessoa
        /// e enviar para o repositório atualizar no banco de dados
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Person Update(Person person)
        {
            return _personRepository.Update(person);
        }
    }
}
