using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGFP.Application.DTOs.Request;
using SGFP.Application.Interfaces;

namespace SGFP.Web.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class FrequenciaController : ControllerBase
    {
        private readonly ITB006_FrequenciaService _frequenciaService;

        public FrequenciaController(ITB006_FrequenciaService frequenciaService)
        {
            _frequenciaService = frequenciaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categoria = await _frequenciaService.GetAll();
            return Ok(categoria);

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var categoria = await _frequenciaService.GetById(id);
            return Ok(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TB006_FrequenciaRequestDto request)
        {
            var categoria = await _frequenciaService.Create(request);
            return Ok(categoria);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TB006_FrequenciaRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoria = await _frequenciaService.Update(id, request);

            if (categoria == null)
                return NotFound();

            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoria = await _frequenciaService.Delete(id);

            if (categoria == null)
                return NotFound();

            return Ok(categoria);
        }
    }
}
