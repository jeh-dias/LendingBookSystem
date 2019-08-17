using Domain;
using ManagerBooks.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonServices _personServices;
        private readonly ILogger<PersonController> _logger;
        public PersonController(IPersonServices personServices, ILogger<PersonController> logger)
        {
            _personServices = personServices;
            _logger = logger;
        }

        /// <summary>
        /// Este método é responsável por retornar todos da entidade livro
        /// que estão no banco de dados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received get request");
                var persons = _personServices.GetAll();
                return Ok(persons);
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
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Person> GetByGuid(int id)
        {

            try
            {
                _logger.LogInformation("Received get request");
                var persons = _personServices.GetById(id);
                return Ok(persons);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new BadRequestResult();
            }
        }

        /// <summary>
        /// Este método é responsável por inserir dados de livro
        /// </summary>
        /// <param name="Person"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Person> Insert([FromBody] Person person)
        {
            try
            {
                //person.guid = Guid.NewGuid();
                _logger.LogInformation("Received post request");
                return Ok(_personServices.Insert(person));
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
        /// <param name="Person"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<Person> Put([FromBody] Person person)
        {
            try
            {
                _logger.LogInformation("Received put request");
                return Ok(_personServices.Update(person));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new BadRequestResult();
            }
        }

        /// <summary>
        /// Este método é responsável por remover um livro
        /// </summary>
        /// <param name="Person"></param>
        /// <returns></returns>
        [HttpDelete]
        public StatusCodeResult Delete(Person person)
        {
            try
            {
                _logger.LogInformation("Received delete request");
                _personServices.Delete(person);
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
