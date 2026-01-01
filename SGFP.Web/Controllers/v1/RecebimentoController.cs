using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGFP.Application.DTOs.Request;
using SGFP.Application.Interfaces;

namespace SGFP.Web.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class RecebimentoController : ControllerBase
    {
        private readonly ITB005_RecebimentoService _recebimentoService;

        public RecebimentoController(ITB005_RecebimentoService recebimentoService)
        {
            _recebimentoService = recebimentoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var recebimento = await _recebimentoService.GetAll();
            return Ok(recebimento);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAll(int id)
        {
            var recebimento = await _recebimentoService.GetById(id);
            return Ok(recebimento);
        }

        [HttpPost]
        public async Task<IActionResult> create([FromBody] TB005_RecebimentoRequestDto request)
        {
            var recebimento = await _recebimentoService.create(request);
            return Ok(recebimento);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> update(int id, [FromBody] TB005_RecebimentoRequestDto request)
        {
            var recebimento = await _recebimentoService.update(id,request);
            return Ok(recebimento);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var recebimento = await _recebimentoService.delete(id);
            return Ok(recebimento);
        }
    }
}
