using Dapper;
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
    /// <summary>
    /// Esta classe é responsável por padrão repositório de dados
    /// </summary>
    /// <typeparam name="T"></typeparam>
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

        /// <summary>
        /// Este método é responsável por receber a consulta e os parâmetros desejados 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual List<T> ExecuteQuery(string query, DynamicParameters parameters = null)
        {
            try
            {
                if (parameters == null)
                    return Conn.Query<T>(query).ToList();

                return Conn.Query<T>(query, parameters).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
            finally
            {
                if ((Conn != null) && (Conn.State != ConnectionState.Closed))
                {
                    Conn.Close();
                }
            }
        }

        /// <summary>
        /// Este método é responsável por chamar o método insert da biblioteca dapper contrib
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Este método é responsável por chamar o método delete da biblioteca dapper contrib
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual bool Remove(T obj)
        {
            return Conn.Delete(obj);
        }

        /// <summary>
        /// Este método é responsável por chamar o método GetAll da biblioteca dapper contrib
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual List<T> GetAll()
        {
            return Conn.GetAll<T>().ToList();
        }

        /// <summary>
        ///  Este método é responsável por chamar o método Update da biblioteca dapper contrib
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual T Update(T obj)
        {
            Conn.Update(obj);
            return obj;
        }

        /// <summary>
        /// Este método é responsável por buscar o objeto correspondente ao guid passado por parâmetro
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual T GetByKey(Guid key)
        {
            T obj = null;
            try
            {
                obj = Conn.QueryFirstOrDefault<T>($"SELECT * FROM {typeof(T).Name}", new { key = key });
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
            }
            return obj;
        }

        /// <summary>
        /// Este método é responsável por finalizar a conexão, caso tenha necessidade
        /// </summary>
        public void Dispose() => Conn.Dispose();

        /// <summary>
        /// Este método é responsável por chamar o método delete da biblioteca dapper contrib
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Delete(T obj)
        {
            return Conn.Delete<T>(obj);
        }
    }
}
