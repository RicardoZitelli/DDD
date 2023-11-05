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
        public ActionResult Insert([FromBody] Application.Dtos.Requests.ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                _applicationServiceProduto.Add(produtoDto);
                return Ok("Produto cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(error: string.Format("Erro: {ex}",ex.Message));
            }

        }

        [HttpPut]
        public ActionResult Update([FromBody] Application.Dtos.Requests.ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                _applicationServiceProduto.Update(produtoDto);
                return Ok("Produto atualizado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(error: string.Format("Erro: {ex}", ex.Message));
            }

        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Application.Dtos.Requests.ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                _applicationServiceProduto.Remove(produtoDto);
                return Ok("Produto removido com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(error: string.Format("Erro: {ex}", ex.Message));
            }

        }

        [HttpGet]
        public ActionResult<string?> GetAll()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string?> FindById(int id)
        {
            return Ok(_applicationServiceProduto.FindById(id));
        }
    }
}
