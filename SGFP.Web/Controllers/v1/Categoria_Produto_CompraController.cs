using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGFP.Application.DTOs.Request;
using SGFP.Application.Interfaces;

namespace SGFP.Web.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class Categoria_Produto_CompraController : ControllerBase
    {
        private readonly ITB011_Categoria_Produto_CompraServices _categoria_Produto_CompraServices;

        public Categoria_Produto_CompraController(ITB011_Categoria_Produto_CompraServices categoria_Produto_CompraServices)
        {
            _categoria_Produto_CompraServices = categoria_Produto_CompraServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tipo = await _categoria_Produto_CompraServices.GetAll();
            return Ok(tipo);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tipo = await _categoria_Produto_CompraServices.GetById(id);
            return Ok(tipo);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TB011_Categoria_Produto_CompraRequestDto request)
        {
            var tipo = await _categoria_Produto_CompraServices.Create(request);
            return Ok(tipo);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TB011_Categoria_Produto_CompraRequestDto request)
        {
            var tipo = await _categoria_Produto_CompraServices.Update(id, request);
            return Ok(tipo);
        }


        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tipo = await _categoria_Produto_CompraServices.Delete(id);
            return Ok(tipo);
        }
    }
}
