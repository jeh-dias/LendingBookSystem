using Dapper;
using Domain;
using ManagerBooks.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagerBooks.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(IConfiguration config, ILogger<Repository<Person>> logger) : base(config, logger)
        {
        }
        public override Person GetById(Guid key)
        {
            Person obj = null;
            try
            {
                var query = "SELECT * FROM Person WHERE key = @key";
                var parameters = new DynamicParameters();
                parameters.Add("@key", key);
                obj = ExecuteQuery(query, parameters).FirstOrDefault();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
            }
            return obj;
        }
    }
}
