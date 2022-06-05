using DDD.Application.Dtos;
using DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Services.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;
        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCliente = applicationServiceCliente;
        }

        [HttpGet("{id}")]
        public ActionResult<string?> GetById(int id)
        {
            return Ok(_applicationServiceCliente.GetById(id));
        }

        [HttpPost]
        public ActionResult Insert([FromBody]ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                {
                    return NotFound();
                }
                _applicationServiceCliente.Add(clienteDto);
                return Ok("Cliente cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        [HttpPut]
        public ActionResult Update([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                {
                    return NotFound();
                }
                _applicationServiceCliente.Update(clienteDto);
                return Ok("Cliente atualizado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                {
                    return NotFound();
                }
                _applicationServiceCliente.Remove(clienteDto);
                return Ok("Cliente atualizado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet]
        public ActionResult<string?> GetAll()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

    }
}
