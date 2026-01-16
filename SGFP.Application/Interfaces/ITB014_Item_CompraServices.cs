using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB014_Item_CompraServices
    {
        Task<List<TB014_Item_CompraResponseDto>> GetAll();
        Task<TB014_Item_CompraResponseDto> GetById(int id);
        Task<TB014_Item_CompraResponseDto> Create(TB014_Item_CompraRequestDto itemCompra);
        Task<TB014_Item_CompraResponseDto> Update(int id, TB014_Item_CompraRequestDto itemCompra);
        Task<TB014_Item_CompraResponseDto> Delete(int id);
    }
}
