using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB011_Categoria_Produto_CompraServices
    {
        Task<List<TB011_Categoria_Produto_CompraResponseDto>> GetAll();
        Task<TB011_Categoria_Produto_CompraResponseDto> GetById(int id);
        Task<TB011_Categoria_Produto_CompraResponseDto> Create(TB011_Categoria_Produto_CompraRequestDto categoiriaProdutoCompra);
        Task<TB011_Categoria_Produto_CompraResponseDto> Update(int id, TB011_Categoria_Produto_CompraRequestDto categoiriaProdutoCompra);
        Task<TB011_Categoria_Produto_CompraResponseDto> Delete(int id);
    }
}
