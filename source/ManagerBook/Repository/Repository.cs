using Dapper.Contrib.Extensions;
using ManagerBooks.Domain;
using ManagerBooks.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ManagerBooks.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly IConfiguration _config;
        protected readonly ILogger<Repository<T>> _logger;

        public Repository(IConfiguration config, ILogger<Repository<T>> logger)
        {
            _config = config;
            _logger = logger;
        }

        protected IDbConnection Conn => new NpgsqlConnection(_config.GetConnectionString("DefaultConnection"));

        public virtual T Insert(T obj)
        {
            try
            {
                Conn.Insert(obj);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
            }
            
            return obj;
        }

        public virtual bool Remove(T obj)
        {
            return Conn.Delete(obj);
        }

        public virtual List<T> GetAll()
        {
            return Conn.GetAll<T>().ToList();
        }

        public virtual T Update(T obj)
        {
            Conn.Update(obj);
            return obj;
        }

        public virtual T GetById(Guid id)
        {
            return Conn.Get<T>(id);
        }

        public void Dispose() => Conn.Dispose();

        public bool Delete(T obj)
        {
            return Conn.Delete<T>(obj);
        }

        public T GetByGuid(Guid guid)
        {
            return Conn.Get<T>(guid);
        }
    }
}
