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
        public ActionResult Insert([FromBody] Application.Dtos.Requests.TipoProdutoDto tipoProdutoDto)
        {
            try
            {
                if (tipoProdutoDto == null)
                {
                    return NotFound();
                }
                _applicationServiceTipoProduto.Add(tipoProdutoDto);
                return Ok("Produto cadastrado com sucesso");
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPut]
        public ActionResult Update([FromBody] Application.Dtos.Requests.TipoProdutoDto tipoProdutoDto)
        {
            try
            {
                if (tipoProdutoDto == null)
                {
                    return NotFound();
                }
                _applicationServiceTipoProduto.Update(tipoProdutoDto);
                return Ok("Produto atualizado com sucesso");
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Application.Dtos.Requests.TipoProdutoDto tipoProdutoDto)
        {
            try
            {
                if (tipoProdutoDto == null)
                {
                    return NotFound();
                }
                _applicationServiceTipoProduto.Remove(tipoProdutoDto);
                return Ok("Produto removido com sucesso");
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpGet]
        public ActionResult<string?> GetAll()
        {
            return Ok(_applicationServiceTipoProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string?> FindById(int id)
        {
            return Ok(_applicationServiceTipoProduto.FindById(id));
        }
    }
}
