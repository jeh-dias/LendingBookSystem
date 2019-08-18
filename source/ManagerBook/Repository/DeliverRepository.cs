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
    public class DeliverRepository : Repository<Deliver> , IDeliverRepository
    {
        public DeliverRepository(IConfiguration config, ILogger<Repository<Deliver>> logger) : base(config, logger)
        {
        }
    }
}
