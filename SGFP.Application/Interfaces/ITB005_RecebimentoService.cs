using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB005_RecebimentoService
    {
        Task<List<TB005_RecebimentoResponseDto>> GetAll();
        Task<TB005_RecebimentoResponseDto> GetById(int id);
        Task<TB005_RecebimentoResponseDto> create(TB005_RecebimentoRequestDto request);
        Task<TB005_RecebimentoResponseDto> update(int id,TB005_RecebimentoRequestDto request);
        Task<TB005_RecebimentoResponseDto> delete(int id);
    }
}
