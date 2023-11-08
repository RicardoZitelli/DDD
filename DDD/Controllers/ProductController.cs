﻿using DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Services.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IApplicationServiceProduct _applicationServiceProduct
            ;
        public ProductController(IApplicationServiceProduct applicationServiceProduct)
        {
            _applicationServiceProduct = applicationServiceProduct;
        }

        [HttpPost]
        public async Task<ActionResult> InsertAsync([FromBody] Application.Dtos.Requests.ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceProduct.AddAsync(productDto);
                return Ok("Product successfully registered");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] Application.Dtos.Requests.ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceProduct.UpdateAsync(productDto);
                return Ok("Product successfully updated");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync([FromBody] Application.Dtos.Requests.ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                {
                    return NotFound();
                }
                await _applicationServiceProduct.RemoveAsync(productDto);
                return Ok("Product successfully removed");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpGet]
        public async Task<ActionResult<string?>> GetAllAsync()
        {
            return Ok(await _applicationServiceProduct.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string?>> FindByIdAsync(int id)
        {
            return Ok(await _applicationServiceProduct.FindByIdAsync(id));
        }
    }
}