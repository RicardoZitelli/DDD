using DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DDD.Application.Dtos.Requests;
using DDD.Application.Dtos.Responses;

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
        public ActionResult<string?> FindById(int id)
        {
            return Ok(_applicationServiceCliente.FindById(id));
        }

        [HttpPost]
        public ActionResult Insert([FromBody] Application.Dtos.Requests.ClienteDto clienteDto)
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
            catch (Exception)
            {
                throw ;
            }
           
        }

        [HttpPut]
        public ActionResult Update([FromBody] Application.Dtos.Requests.ClienteDto clienteDto)
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
            catch (Exception)
            {
                throw;
            }

        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Application.Dtos.Requests.ClienteDto clienteDto)
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
            catch (Exception)
            {
                throw ;
            }

        }

        [HttpGet]
        public ActionResult<string?> GetAll()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

    }
}
