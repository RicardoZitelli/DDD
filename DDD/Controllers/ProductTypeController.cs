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

        [HttpPost]
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

        [HttpPut]
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

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync([FromBody] Application.Dtos.Requests.ProductTypeDto productTypeDto)
        {
            try
            {
                if (productTypeDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceProductType.RemoveAsync(productTypeDto);
                return Ok("Product type successfully removed");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpGet]
        public async Task<ActionResult<string?>> GetAllAsync()
        {
            return Ok(await _applicationServiceProductType.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string?>> FindByIdAsync(int id)
        {
            return Ok(await _applicationServiceProductType.FindByIdAsync(id));
        }
    }
}
