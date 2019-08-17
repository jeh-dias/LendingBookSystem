using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManagerBooks.Applications.Controllers
{
    //[Route("[controller]")]
    //public class DeliverController : ControllerBase
    //{
    //    private readonly IDeliverServices _deliverServices;
    //    private readonly ILogger<DeliverController> _logger;

    //    public DeliverController(IDeliverServices deliverServices, ILogger<DeliverController> logger)
    //    {
    //        _deliverServices = deliverServices;
    //        _logger = logger;
    //    }

    //    //GET: api/Devolution
    //    [HttpGet]
    //    public IEnumerable<string> Get()
    //    {
    //        return new string[] { "value1", "value2" };
    //    }

    //    //GET: api/Devolution/5
    //    [HttpGet("{id}", Name = "Get")]
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }

    //    // POST: api/Devolution
    //    [HttpPost]
    //    public Deliver Post([FromBody] Deliver deliver)
    //    {
    //        return null;
    //    }

    //    // PUT: api/Devolution/5
    //    [HttpPut]
    //    public Deliver Put([FromBody] Deliver deliver)
    //    {
    //        return null;
    //    }
    //}
}
