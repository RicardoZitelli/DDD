using DDD.Application;
using DDD.Application.Dtos.Responses;
using DDD.Application.Interfaces;
using DDD.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Services.Controllers
{
    public class CorreiosApiController(IApplicationServiceCorreiosApi applicationServiceCorreiosApi, IConfiguration configuration) : Controller
    {

        private readonly IApplicationServiceCorreiosApi _applicationServiceCorreiosApi = applicationServiceCorreiosApi;
        private readonly IConfiguration _configuration = configuration;

        [HttpGet("GetToken")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CorreiosToken))]        
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<CorreiosTokenDTO>>> GetAllAsync()
        {
            string baseUrl = _configuration["ExternalApis:Correios:base"];
            string username = _configuration["ExternalApis:Correios:username"];
            string password = _configuration["ExternalApis:Correios:password"];

            return Ok(await _applicationServiceCorreiosApi.GetCorreiosToken($"{baseUrl}/token/v1/autentica",
                username,
                password));
        }
    }
}
