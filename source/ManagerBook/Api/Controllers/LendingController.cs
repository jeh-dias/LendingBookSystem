using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interfaces;

namespace ManagerBooks.Applications.Controllers
{
    /// <summary>
    /// Classe da api responsável pela interação com a classe de serviço
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LendingController : ControllerBase
    {
        private readonly ILendingServices _lendingServices;
        private readonly ILogger<LendingController> _logger;

        public LendingController(ILendingServices lendingServices, ILogger<LendingController> logger)
        {
            _lendingServices = lendingServices;
            _logger = logger;
        }

        /// <summary>
        /// Método responsável por interagir com o método GetAll do serviço
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Lending>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received get request");
                IEnumerable<Lending> lendingList = _lendingServices.GetAll();
                return Ok(lendingList);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest();
            }
        }

        /// <summary>
        ///  Método responsável por interagir com o método GetById do serviço
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Lending> GetById(Guid id)
        {
            try
            {
                _logger.LogInformation("Received get request");
                Lending lending = _lendingServices.GetById(id);
                return Ok(lending);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest();
            }
        }

        /// <summary>
        /// Método responsável por interagir com o método Insert do serviço
        /// </summary>
        /// <param name="lending"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Lending> Post([FromBody] Lending lending)
        {
            try
            {
                _logger.LogInformation("Received post request");
                Lending lend = _lendingServices.Insert(lending);
                return Ok(lend);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest();
            }
        }

        /// <summary>
        /// Método responsável por interagir com o método Update do serviço
        /// </summary>
        /// <param name="lending"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<Lending> Put([FromBody] Lending lending)
        {
            try
            {
                _logger.LogInformation("Received put request");
                Lending lend = _lendingServices.Update(lending);
                return Ok(lend);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest();
            }
        }
    }
}
