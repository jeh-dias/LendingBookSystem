using Domain;
using ManagerBooks.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    /// <summary>
    /// Classe responsável por repositório do empréstimo
    /// </summary>
    public class LendingRepository : Repository<Lending>, ILendingRepository
    {
        public LendingRepository(IConfiguration config, ILogger<Repository<Lending>> logger) : base(config, logger)
        {
        }
    }
}
