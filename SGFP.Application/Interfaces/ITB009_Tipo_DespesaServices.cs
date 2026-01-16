using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB009_Tipo_DespesaServices
    {
        Task<List<TB009_Tipo_DespesaResponseDto>> GetAll();
        Task<TB009_Tipo_DespesaResponseDto> GetById(int id);
        Task<TB009_Tipo_DespesaResponseDto> Create(TB009_Tipo_DespesaRequestDto tipoDespesa);
        Task<TB009_Tipo_DespesaResponseDto> Update(int id, TB009_Tipo_DespesaRequestDto tipoDespesa);
        Task<TB009_Tipo_DespesaResponseDto> Delete(int id);
    }
}
