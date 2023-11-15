using DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DDD.Application.Dtos.Requests;
using DDD.Application.Dtos.Responses;

namespace DDD.Services.Controllers
{
    [Route("api/v1/[Controller]")]
    [Route("[Controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IApplicationServiceCustomer _applicationServiceCustomer;
        public CustomerController(IApplicationServiceCustomer applicationServiceCliente)
        {
            _applicationServiceCustomer = applicationServiceCliente;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> InsertAsync([FromBody] Application.Dtos.Requests.CustomerDto customerDto)
        {
            try
            {
                if (customerDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceCustomer.AddAsync(customerDto);
                return Ok("Customer successfully registered");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
           
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateAsync([FromBody] Application.Dtos.Requests.CustomerDto customerDto)
        {
            try
            {
                if (customerDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceCustomer.UpdateAsync(customerDto);
                return Ok("Customer successfully updated");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteAsync([FromBody] Application.Dtos.Requests.CustomerDto customerDto)
        {
            try
            {
                if (customerDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceCustomer.RemoveAsync(customerDto);
                return Ok("Customer successfully removed");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<string?>> FindByIdAsync(int id)
        {
            return Ok(await _applicationServiceCustomer.FindByIdAsync(id));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<string?>> GetAllAsync()
        {
            return Ok(await _applicationServiceCustomer.GetAllAsync());
        }

    }
}
