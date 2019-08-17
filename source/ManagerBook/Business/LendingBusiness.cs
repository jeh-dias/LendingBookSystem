using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    /// <summary>
    /// Classe responsável pela regras de negócio do empréstimo
    /// </summary>
    public class LendingBusiness
    {
        private const int totalDaysWeek = 7;

        private readonly LendingRepository _lendingRepository;

        public LendingBusiness(LendingRepository lendingRepository)
        {
            _lendingRepository = lendingRepository;
        }

        /// <summary>
        /// Método responsável por interagir com o método de inserção do repositório
        /// </summary>
        /// <param name="lending"></param>
        /// <returns></returns>
        public Lending Insert(Lending lending)
        {
            InsertDateLending(lending);
            CalculateDateDevolution(lending);
            return _lendingRepository.Insert(lending);
        }

        /// <summary>
        /// Método responsável por definir a data de devolução de um livro
        /// O modificador estático foi usado para otimizar o espaço de memória quando for chamado
        /// </summary>
        /// <param name="lending"></param>
        /// <returns></returns>
        private static DateTime CalculateDateDevolution(Lending lending)
        {
            DateTime dateDevolution = lending.dateLending.AddDays(totalDaysWeek);
            lending.dateDevolution = dateDevolution;
            return lending.dateDevolution;
        }

        /// <summary>
        /// Método responsável por inserir a data de empréstimo
        /// O modificador estático foi usado para otimizar o espaço de memória quando for chamado
        /// </summary>
        /// <param name="lending"></param>
        /// <returns></returns>
        private static DateTime InsertDateLending(Lending lending)
        {
            return lending.dateLending = DateTime.Now;
        }
    }
}
