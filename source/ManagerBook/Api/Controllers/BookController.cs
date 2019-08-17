

using Domain;
using ManagerBooks.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace ManagerBooks.Applications.Controllers
{
    /// <summary>
    /// Esta classe é responsável por implementar todos os métodos
    /// da api de livros
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices _bookServices;
        private readonly ILogger<BookController> _logger;
        public BookController(IBookServices bookServices, ILogger<BookController> logger)
        {
            _bookServices = bookServices;
            _logger = logger;
        }

        /// <summary>
        /// Este método é responsável por retornar todos da entidade livro
        /// que estão no banco de dados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received get request");
                var books = _bookServices.GetAll();
                return Ok(books);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest();
            }
        }

        /// <summary>
        /// Este método é responsável por retornar
        /// um objeto da entidade livro, de acordo com o valor
        /// do id passa como parâmetro
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet("{key}")]
        public ActionResult<Book> GetByGuid(Guid key)
        {

            try
            {
                _logger.LogInformation("Received get request");
                var books = _bookServices.GetById(key);
                return Ok(books);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest();
            }
        }

        /// <summary>
        /// Este método é responsável por inserir dados de livro
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Book> Insert([FromBody] Book book)
        {
            try
            {
                _logger.LogInformation("Received post request");
                return Ok(_bookServices.Insert(book));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest(null);
            }
        }

        /// <summary>
        /// Este método é responsável por atualizar um livro
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<Book> Put([FromBody] Book book)
        {
            try
            {
                _logger.LogInformation("Received put request");
                return Ok(_bookServices.Update(book));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest();
            }
        }

        /// <summary>
        /// Este método é responsável por remover um livro
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpDelete]
        public StatusCodeResult Delete(Book book)
        {
            try
            {
                _logger.LogInformation("Received delete request");
                _bookServices.Delete(book);
                return new StatusCodeResult(201);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(204);
            }
        }
    }
}
