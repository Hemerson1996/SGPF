using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB007_ReceitaService
    {
        Task<List<TB007_ReceitaResponseDto>> GetAll();
        Task<TB007_ReceitaResponseDto> GetById(int id);
        Task<TB007_ReceitaResponseDto> Create(TB007_ReceitaRequestDto receita);
        Task<TB007_ReceitaResponseDto> Update(int id, TB007_ReceitaRequestDto receita);
        Task<TB007_ReceitaResponseDto> Delete(int id);
    }
}
