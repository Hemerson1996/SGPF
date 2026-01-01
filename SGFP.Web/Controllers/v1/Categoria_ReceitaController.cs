using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SGFP.Application.DTOs.Request;
using SGFP.Application.Interfaces;
using SGFP.Domain.Interfaces;

namespace SGFP.Web.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    public class Categoria_ReceitaController : ControllerBase
    {
        private readonly ITB003_Categoria_ReceitaServices _categoria_ReceitaServices;

        public Categoria_ReceitaController(ITB003_Categoria_ReceitaServices categoria_ReceitaServices)
        {
            _categoria_ReceitaServices = categoria_ReceitaServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categoria = await _categoria_ReceitaServices.GetAll();
            return Ok(categoria);

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var categoria = await _categoria_ReceitaServices.GetById(id);
            return Ok(categoria);
        }

        [HttpPost]
        public  async Task<IActionResult> Create([FromBody] TB003_Categoria_ReceitaRequestDtos request)
        {
            var categoria = await _categoria_ReceitaServices.Create(request);
            return Ok(categoria);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id,[FromBody] TB003_Categoria_ReceitaRequestDtos request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoria = await _categoria_ReceitaServices.Update(id,request);

            if (categoria == null)
                return NotFound();

            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoria = await _categoria_ReceitaServices.Delete(id);

            if (categoria == null)
                return NotFound();

            return Ok(categoria);
        }
    }
}
