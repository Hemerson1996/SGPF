using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGFP.Application.DTOs.Request;
using SGFP.Application.Interfaces;

namespace SGFP.Web.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class Unidade_Produto_CompraController : ControllerBase
    {
        private readonly ITB012_Unidade_Produto_CompraService _unidade_Produto_CompraService;

        public Unidade_Produto_CompraController(ITB012_Unidade_Produto_CompraService unidade_Produto_CompraService)
        {
            _unidade_Produto_CompraService = unidade_Produto_CompraService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tipo = await _unidade_Produto_CompraService.GetAll();
            return Ok(tipo);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tipo = await _unidade_Produto_CompraService.GetById(id);
            return Ok(tipo);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TB012_Unidade_Produto_CompraResquesDto request)
        {
            var tipo = await _unidade_Produto_CompraService.Create(request);
            return Ok(tipo);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TB012_Unidade_Produto_CompraResquesDto request)
        {
            var tipo = await _unidade_Produto_CompraService.Update(id, request);
            return Ok(tipo);
        }


        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tipo = await _unidade_Produto_CompraService.Delete(id);
            return Ok(tipo);
        }
    }
}
