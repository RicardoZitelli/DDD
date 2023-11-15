using DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Services.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class ProductTypeController : Controller
    {
        private readonly IApplicationServiceProductType _applicationServiceProductType;
        public ProductTypeController(IApplicationServiceProductType applicationServiceProductType)
        {
            _applicationServiceProductType = applicationServiceProductType;
        }

        [HttpPost("InsertAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Application.Dtos.Requests.ProductTypeDto>>> InsertAsync([FromBody] Application.Dtos.Requests.ProductTypeDto productTypeDto)
        {
            try
            {
                if (productTypeDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceProductType.AddAsync(productTypeDto);

                return Ok(await _applicationServiceProductType.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpPut("UpdateAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Application.Dtos.Requests.ProductTypeDto>>> UpdateAsync([FromBody] Application.Dtos.Requests.ProductTypeDto productTypeDto)
        {
            try
            {
                if (productTypeDto == null)
                {
                    return NotFound();
                }

                await _applicationServiceProductType.UpdateAsync(productTypeDto);

                return Ok(await _applicationServiceProductType.GetAllAsync());
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpDelete("DeleteAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Application.Dtos.Requests.ProductTypeDto>>> DeleteAsync([FromBody] Application.Dtos.Requests.ProductTypeDto productTypeDto)
        {
            try
            {
                if (productTypeDto == null)
                {
                    return NotFound();
                }
              
                await _applicationServiceProductType.RemoveAsync(productTypeDto);
               
                return Ok(await _applicationServiceProductType.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpGet("GetAllAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Application.Dtos.Requests.ProductTypeDto>>> GetAllAsync()
        {
            return Ok(await _applicationServiceProductType.GetAllAsync());
        }

        [HttpGet("FindByIdAsync/{id}")]
        public async Task<ActionResult<Application.Dtos.Requests.ProductTypeDto>> FindByIdAsync([FromRoute]int id)
        {
            return Ok(await _applicationServiceProductType.FindByIdAsync(id));
        }
    }
}
