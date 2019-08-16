using Domain;
using ManagerBooks.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerBooks.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(IConfiguration config, ILogger<Repository<Person>> logger) : base(config, logger)
        {
        }
    }
}
