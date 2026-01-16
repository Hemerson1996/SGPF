using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB015_Status_PagamentoService
    {
        Task<List<TB015_Status_PagamentoResponseDto>> GetAll();
        Task<TB015_Status_PagamentoResponseDto> GetById(int id);
        Task<TB015_Status_PagamentoResponseDto> Create(TB015_Status_PagamentoRequestDto statusPagamento);
        Task<TB015_Status_PagamentoResponseDto> Update(int id, TB015_Status_PagamentoRequestDto statusPagamento);
        Task<TB015_Status_PagamentoResponseDto> Delete(int id);
    }
}
