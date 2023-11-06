using DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Services.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;
        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            _applicationServiceProduto = applicationServiceProduto;
        }

        [HttpPost]
        public async Task<ActionResult> InsertAsync([FromBody] Application.Dtos.Requests.ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceProduto.AddAsync(produtoDto);
                return Ok("Produto cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(error: string.Format("Erro: {ex}",ex.Message));
            }

        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] Application.Dtos.Requests.ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceProduto.UpdateAsync(produtoDto);
                return Ok("Produto atualizado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(error: string.Format("Erro: {ex}", ex.Message));
            }

        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync([FromBody] Application.Dtos.Requests.ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceProduto.RemoveAsync(produtoDto);
                return Ok("Produto removido com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(error: string.Format("Erro: {ex}", ex.Message));
            }

        }

        [HttpGet]
        public async Task<ActionResult<string?>> GetAllAsync()
        {
            return Ok(await _applicationServiceProduto.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string?>> FindByIdAsync(int id)
        {
            return Ok(await _applicationServiceProduto.FindByIdAsync(id));
        }
    }
}
