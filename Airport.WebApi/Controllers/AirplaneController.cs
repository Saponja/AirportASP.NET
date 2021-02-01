using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Airport.Data.UnitOfWork;
using Airport.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airport.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        IUnitOfWork uow;

        public AirplaneController(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        // GET: api/<AirplaneController>
        [HttpGet]
        public List<Airplane> Get()
        {
            return uow.Airplane.GetAll();
        }

        // GET api/<AirplaneController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Airplane airplane = uow.Airplane.FindById(id);
            if(airplane != null)
            {
                return Ok(airplane);
            }
            return NotFound();
        }

        // POST api/<AirplaneController>
        [HttpPost]
        public void Post([FromBody] Airplane item)
        {

            try
            {
                uow.Airplane.Add(item);
                uow.Commit();
                HttpContext.Response.StatusCode = (int)HttpStatusCode.Created;
            }
            catch (Exception)
            {
                HttpContext.Response.StatusCode = 400;
            }
        }

        // PUT api/<AirplaneController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AirplaneController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                Airplane airplane = uow.Airplane.FindById(id);
                uow.Airplane.Remove(airplane);
                uow.Commit();
                HttpContext.Response.StatusCode = (int)HttpStatusCode.Created;
            }
            catch (Exception)
            {
                HttpContext.Response.StatusCode = 400;
            }
        }

        [HttpGet("destinations/{id}")]
        public List<string> GetDestinations([FromRoute] int id)
        {
            return uow.Airplane.GetDestinations(id);
        }
    }
}
