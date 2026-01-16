using Microsoft.AspNetCore.Mvc;
using SGFP.Application.DTOs.Request;
using SGFP.Application.Interfaces;

namespace SGFP.Web.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class Categoria_DespesaController:ControllerBase
    {
        private readonly ITB008_Categoria_DespesaServices _categoria_DespesaServices;

        public Categoria_DespesaController(ITB008_Categoria_DespesaServices categoria_DespesaServices)
        {
            _categoria_DespesaServices = categoria_DespesaServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var receita = await _categoria_DespesaServices.GetAll();
            return Ok(receita);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var categoria = await _categoria_DespesaServices.GetById(id);
            return Ok(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TB008_Categoria_DespesaRequestDtos request)
        {
            var categoria = await _categoria_DespesaServices.Create(request);
            return Ok(categoria);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TB008_Categoria_DespesaRequestDtos request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoria = await _categoria_DespesaServices.Update(id, request);

            if (categoria == null)
                return NotFound();

            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoria = await _categoria_DespesaServices.Delete(id);

            if (categoria == null)
                return NotFound();

            return Ok(categoria);
        }
    }
}
