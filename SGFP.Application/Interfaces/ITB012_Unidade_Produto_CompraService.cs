using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB012_Unidade_Produto_CompraService
    {
        Task<List<TB012_Unidade_Produto_CompraResponseDto>> GetAll();
        Task<TB012_Unidade_Produto_CompraResponseDto> GetById(int id);
        Task<TB012_Unidade_Produto_CompraResponseDto> Create(TB012_Unidade_Produto_CompraResquesDto unidadeProdutoCompra);
        Task<TB012_Unidade_Produto_CompraResponseDto> Update(int id, TB012_Unidade_Produto_CompraResquesDto unidadeProdutoCompra);
        Task<TB012_Unidade_Produto_CompraResponseDto> Delete(int id);
    }
}
