using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface IDashBoardServices
    {
        Task<DashBoardResponseDtos> Valores();
        //double CalcularTotalMensal(IEnumerable<TB007_ReceitaRequestDto> requestDtos, int mes, int ano);
    }
}
