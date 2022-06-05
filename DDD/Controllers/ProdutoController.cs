using DDD.Application.Dtos;
using DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Services.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;
        public ProdutoController(IApplicationServiceProduto applicationServiceCliente)
        {
            _applicationServiceProduto = applicationServiceCliente;
        }

        [HttpPost]
        public ActionResult Insert([FromBody] ProdutoDto produtoDto)
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

                throw ex;
            }

        }

        [HttpPut]
        public ActionResult Update([FromBody] ProdutoDto produtoDto)
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

                throw ex;
            }

        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
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

                throw ex;
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
