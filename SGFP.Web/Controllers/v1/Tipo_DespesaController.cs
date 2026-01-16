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
    public class Tipo_DespesaController : ControllerBase
    {
        private readonly ITB009_Tipo_DespesaServices _tipo_DespesaServices;

        public Tipo_DespesaController(ITB009_Tipo_DespesaServices tipo_DespesaServices)
        {
            _tipo_DespesaServices = tipo_DespesaServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tipo = await _tipo_DespesaServices.GetAll();
            return Ok(tipo);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tipo = await _tipo_DespesaServices.GetById(id);
            return Ok(tipo);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TB009_Tipo_DespesaRequestDto request)
        {
            var tipo = await _tipo_DespesaServices.Create(request);
            return Ok(tipo);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TB009_Tipo_DespesaRequestDto request)
        {
            var tipo = await _tipo_DespesaServices.Update(id, request);
            return Ok(tipo);
        }


        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tipo = await _tipo_DespesaServices.Delete(id);
            return Ok(tipo);
        }
    }
}
