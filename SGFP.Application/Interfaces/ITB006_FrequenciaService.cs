using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB006_FrequenciaService
    {
        Task<List<TB006_FrequenciaResponseDto>> GetAll();
        Task<TB006_FrequenciaResponseDto> GetById(int id);
        Task<TB006_FrequenciaResponseDto> Create(TB006_FrequenciaRequestDto frequecia);
        Task<TB006_FrequenciaResponseDto> Update(int id, TB006_FrequenciaRequestDto frequecia);
        Task<TB006_FrequenciaResponseDto> Delete(int id);
    }
}
