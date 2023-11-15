using DDD.Application.Dtos.Requests;
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
        public async Task<ActionResult> InsertAsync([FromBody] Application.Dtos.Requests.ProductTypeDto productTypeDto)
        {
            try
            {
                if (productTypeDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceProductType.AddAsync(productTypeDto);
                return Ok("Product type successfully registered");
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
        public async Task<ActionResult> UpdateAsync([FromBody] Application.Dtos.Requests.ProductTypeDto productTypeDto)
        {
            try
            {
                if (productTypeDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceProductType.UpdateAsync(productTypeDto);
                return Ok("Product type successfully updated");
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpDelete("DeleteAsync/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteAsync([FromRoute] int productTypeId)
        {
            try
            {
                var productTypeDto = await _applicationServiceProductType.FindByIdAsync(productTypeId);

                if (productTypeDto == null)
                {
                    return NotFound();
                }

                await _applicationServiceProductType.RemoveAsync(new ProductTypeDto
                    {
                        Id = productTypeDto.Id,
                        Descricao = productTypeDto.Descricao,
                        Ativo = productTypeDto.Ativo
                    });

                return Ok("Product type successfully removed");
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
        public async Task<ActionResult<string?>> GetAllAsync()
        {
            return Ok(await _applicationServiceProductType.GetAllAsync());
        }

        [HttpGet("FindByIdAsync/{id}")]
        public async Task<ActionResult<string?>> FindByIdAsync([FromRoute] int id)
        {
            return Ok(await _applicationServiceProductType.FindByIdAsync(id));
        }
    }
}
