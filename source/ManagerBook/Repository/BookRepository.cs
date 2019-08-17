using Dapper;
using Domain;
using ManagerBooks.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(IConfiguration config, ILogger<Repository<Book>> logger) : base(config, logger)
        {
        }

        public override Book GetById(Guid key)
        {
            Book obj = null;
            try
            {
                var query = "SELECT * FROM book WHERE key = @key";
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
