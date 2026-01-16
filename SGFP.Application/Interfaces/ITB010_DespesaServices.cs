using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB010_DespesaServices
    {
        Task<List<TB010_DespesaResponseDto>> GetAll();
        Task<TB010_DespesaResponseDto> GetById(int id);
        Task<TB010_DespesaResponseDto> Create(TB010_DespesaRequestDto dispesa);
        Task<TB010_DespesaResponseDto> Update(int id, TB010_DespesaRequestDto dispesa);
        Task<TB010_DespesaResponseDto> Delete(int id);
    }
}
