using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGFP.Application.DTOs.Request;
using SGFP.Application.Interfaces;
using SGFP.Domain.Interfaces;

namespace SGFP.Web.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ReceitaController : ControllerBase
    {
        private readonly ITB007_ReceitaService _receitaService;

        public ReceitaController(ITB007_ReceitaService receitaService)
        {
            _receitaService = receitaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
        
            var receita = await _receitaService.GetAll();
            return Ok(receita);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var categoria = await _receitaService.GetById(id);
            return Ok(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TB007_ReceitaRequestDto request)
        {
            var categoria = await _receitaService.Create(request);
            return Ok(categoria);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TB007_ReceitaRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoria = await _receitaService.Update(id, request);

            if (categoria == null)
                return NotFound();

            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoria = await _receitaService.Delete(id);

            if (categoria == null)
                return NotFound();

            return Ok(categoria);
        }
    }
}
