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
    /// Esta classe é responsável por receber objetos da entrega que vem do front
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DeliverController : ControllerBase
    {
        private readonly IDeliverServices _deliverServices;
        private readonly ILogger<DeliverController> _logger;

        public DeliverController(IDeliverServices deliverServices, ILogger<DeliverController> logger)
        {
            _deliverServices = deliverServices;
            _logger = logger;
        }

        /// <summary>
        /// Este método é responsável por interagir com a classe de serviço para listar
        /// todas as entregas que existem no banco de dados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Deliver>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received get request");
                var delivers = _deliverServices.GetAll();
                return Ok(delivers);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest();
            }
        }

        /// <summary>
        /// Este método é responsável por interagir com a classe de serviço para listar
        /// a entrega que é correspondente ao guid passado por parâmetro
        /// </summary>
        /// <returns></returns>
        [HttpGet("{key}")]
        public ActionResult<Deliver> GetByKey(Guid key)
        {
            try
            {
                _logger.LogInformation("Received get request");
                var deliver = _deliverServices.GetByKey(key);
                return Ok(deliver);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest();
            }
        }

        /// <summary>
        /// Este método é responsável por interagir com a classe de serviço para inserir
        /// a entrega no banco de dados
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Deliver> Post([FromBody] Deliver deliver)
        {
            try
            {
                _logger.LogInformation("Received post request");
                return Ok(_deliverServices.Insert(deliver));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest(null);
            }
        }

        /// <summary>
        /// Este método é responsável por interagir com a classe de serviço para atualizar
        /// a entrega no banco de dados
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<Deliver> Put([FromBody] Deliver deliver)
        {
            try
            {
                _logger.LogInformation("Received put request");
                return Ok(_deliverServices.Update(deliver));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return BadRequest(null);
            }
        }
    }
}
