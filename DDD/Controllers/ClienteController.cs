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
        public async Task<ActionResult<string?>> FindByIdAsync(int id)
        {
            return Ok(await _applicationServiceCliente.FindByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> InsertAsync([FromBody] Application.Dtos.Requests.ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceCliente.AddAsync(clienteDto);
                return Ok("Cliente cadastrado com sucesso");
            }
            catch (Exception)
            {
                throw ;
            }
           
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] Application.Dtos.Requests.ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceCliente.UpdateAsync(clienteDto);
                return Ok("Cliente atualizado com sucesso");
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync([FromBody] Application.Dtos.Requests.ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceCliente.RemoveAsync(clienteDto);
                return Ok("Cliente atualizado com sucesso");
            }
            catch (Exception)
            {
                throw ;
            }

        }

        [HttpGet]
        public async Task<ActionResult<string?>> GetAllAsync()
        {
            return Ok(await _applicationServiceCliente.GetAllAsync());
        }

    }
}
