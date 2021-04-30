using Microsoft.AspNetCore.Mvc;
using solucionIoT.COMMON.Entidades;
using solucionIoT.COMMON.Interface;
using solucionIoT.COMMON.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SolucionIoT.Web.api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericAPIController <T> : ControllerBase where T : BaseDTO
    {
        IGenericManager<T> manager;
            public GenericAPIController(IGenericManager<T> genericManager) 
            {
              manager = genericManager;
            }
        // GET: api/<GenericAPIController>
        [HttpGet]
        public ActionResult<IEnumerable<T>> Get()
        {
            try
            {
                return Ok(manager.ObtenerTodo);
            }
            catch (Exception)
            {

                return BadRequest(manager.Error);
            }
        }

        // GET api/<GenericAPIController>/5
        [HttpGet("{id}")]
        public ActionResult<T> Get(string id)
        {
            try
            {
                return Ok(manager.BuscarPorId(id));
            }
            catch (Exception)
            {

                return BadRequest(manager.Error);
            }
        }

        // POST api/<GenericAPIController>
        [HttpPost]
        public ActionResult<T> Post([FromBody] T value)
        {
            try
            {
                return Ok(manager.Insertar(value));
            }
            catch (Exception)
            {

                return BadRequest(manager.Error);
            }
        }

        // PUT api/<GenericAPIController>/5
        [HttpPut]
        public ActionResult <T> Put([FromBody] T value)
        {
            try
            {
                return Ok(manager.Actualizar(value));
            }
            catch (Exception)
            {

                return BadRequest(manager.Error);
            }
        }

        // DELETE api/<GenericAPIController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string id)
        {
            try
            {
                return Ok(manager.Eliminar(id));
            }
            catch (Exception)
            {

                return BadRequest(manager.Error);
            }
        }
    }
}
