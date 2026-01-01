using Microsoft.AspNetCore.Mvc;
using SGFP.Application.DTOs.Request;
using SGFP.Application.Interfaces;
using System.Threading.Tasks;

namespace SGFP.Web.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class Tipo_Origem_DinheiroController : Controller
    {
        private readonly ITB004_Tipo_Origem_DinheiroService _tipo_Origem_DinheiroService;

        public Tipo_Origem_DinheiroController(ITB004_Tipo_Origem_DinheiroService tipo_Origem_DinheiroService)
        {
            _tipo_Origem_DinheiroService = tipo_Origem_DinheiroService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tipo = await _tipo_Origem_DinheiroService.GetAll();
            return Ok(tipo);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tipo = await _tipo_Origem_DinheiroService.GetById(id);
            return Ok(tipo);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TB004_Tipo_Origem_DinheiroRequestDto request)
        {
            var tipo = await _tipo_Origem_DinheiroService.Create(request);
            return Ok(tipo);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TB004_Tipo_Origem_DinheiroRequestDto request)
        {
            var tipo = await _tipo_Origem_DinheiroService.Update(id,request);
            return Ok(tipo);
        }


        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tipo = await _tipo_Origem_DinheiroService.Delete(id);
            return Ok(tipo);
        }
    }
}
