using DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Services.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class TipoProdutoController : Controller
    {
        private readonly IApplicationServiceTipoProduto _applicationServiceTipoProduto;
        public TipoProdutoController(IApplicationServiceTipoProduto applicationServiceTipoProduto)
        {
            _applicationServiceTipoProduto = applicationServiceTipoProduto;
        }

        [HttpPost]
        public async Task<ActionResult> InsertAsync([FromBody] Application.Dtos.Requests.TipoProdutoDto tipoProdutoDto)
        {
            try
            {
                if (tipoProdutoDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceTipoProduto.AddAsync(tipoProdutoDto);
                return Ok("Produto cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] Application.Dtos.Requests.TipoProdutoDto tipoProdutoDto)
        {
            try
            {
                if (tipoProdutoDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceTipoProduto.UpdateAsync(tipoProdutoDto);
                return Ok("Produto atualizado com sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync([FromBody] Application.Dtos.Requests.TipoProdutoDto tipoProdutoDto)
        {
            try
            {
                if (tipoProdutoDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceTipoProduto.RemoveAsync(tipoProdutoDto);
                return Ok("Produto removido com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpGet]
        public async Task<ActionResult<string?>> GetAllAsync()
        {
            return Ok(await _applicationServiceTipoProduto.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string?>> FindByIdAsync(int id)
        {
            return Ok(await _applicationServiceTipoProduto.FindByIdAsync(id));
        }
    }
}
