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
    }
}
