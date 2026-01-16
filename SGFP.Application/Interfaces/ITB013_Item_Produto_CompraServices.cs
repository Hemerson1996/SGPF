using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB013_Item_Produto_CompraServices
    {
        Task<List<TB013_Item_Produto_CompraResponseDto>> GetAll();
        Task<TB013_Item_Produto_CompraResponseDto> GetById(int id);
        Task<TB013_Item_Produto_CompraResponseDto> Create(TB013_Item_Produto_CompraRequestDto itemProdutoCompra);
        Task<TB013_Item_Produto_CompraResponseDto> Update(int id, TB013_Item_Produto_CompraRequestDto itemProdutoCompra);
        Task<TB013_Item_Produto_CompraResponseDto> Delete(int id);
    }
}
