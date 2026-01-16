using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGFP.Application.Interfaces;

namespace SGFP.Web.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class DashBoardController : ControllerBase
    {
        private readonly IDashBoardServices _dashBoardServices;

        public DashBoardController(IDashBoardServices dashBoardServices)
        {
            _dashBoardServices = dashBoardServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tipo = await _dashBoardServices.Valores();
            return Ok(tipo);
        }

    }
}
