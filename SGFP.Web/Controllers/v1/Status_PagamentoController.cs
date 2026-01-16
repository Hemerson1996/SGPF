using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGFP.Application.DTOs.Request;
using SGFP.Application.Interfaces;

namespace SGFP.Web.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class Status_PagamentoController : ControllerBase
    {
        private readonly ITB015_Status_PagamentoService _status_PagamentoService;

        public Status_PagamentoController(ITB015_Status_PagamentoService status_PagamentoService)
        {
            _status_PagamentoService = status_PagamentoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tipo = await _status_PagamentoService.GetAll();
            return Ok(tipo);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tipo = await _status_PagamentoService.GetById(id);
            return Ok(tipo);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TB015_Status_PagamentoRequestDto request)
        {
            var tipo = await _status_PagamentoService.Create(request);
            return Ok(tipo);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TB015_Status_PagamentoRequestDto request)
        {
            var tipo = await _status_PagamentoService.Update(id, request);
            return Ok(tipo);
        }


        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tipo = await _status_PagamentoService.Delete(id);
            return Ok(tipo);
        }
    }
}
