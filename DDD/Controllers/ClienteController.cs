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
        private readonly IApplicationServiceCliente _applicationServiceCustomer;
        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCustomer = applicationServiceCliente;
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
                await _applicationServiceCustomer.AddAsync(clienteDto);
                return Ok("Customer successfully registered");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
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
                await _applicationServiceCustomer.UpdateAsync(clienteDto);
                return Ok("Customer successfully updated");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
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
                await _applicationServiceCustomer.RemoveAsync(clienteDto);
                return Ok("Customer successfully deleted");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string?>> FindByIdAsync(int id)
        {
            return Ok(await _applicationServiceCustomer.FindByIdAsync(id));
        }

        [HttpGet]
        public async Task<ActionResult<string?>> GetAllAsync()
        {
            return Ok(await _applicationServiceCustomer.GetAllAsync());
        }

    }
}
