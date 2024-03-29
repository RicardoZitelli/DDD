﻿using DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Services.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class ProductController(IApplicationServiceProduct applicationServiceProduct) : Controller
    {
        private readonly IApplicationServiceProduct _applicationServiceProduct = applicationServiceProduct;

        [HttpPost("InsertAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

        [HttpPut("UpdateAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

        [HttpDelete("DeleteAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

        [HttpGet("GetAllAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<string?>> GetAllAsync()
        {
            return Ok(await _applicationServiceProduct.GetAllAsync());
        }

        [HttpGet("FindByIdASync/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<string?>> FindByIdAsync([FromRoute] int id)
        {
            return Ok(await _applicationServiceProduct.FindByIdAsync(id));
        }
    }
}
