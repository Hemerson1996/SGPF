using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB008_Categoria_DespesaServices
    {
        Task<List<TB008_Categoria_DespesaResponseDtos>> GetAll();
        Task<TB008_Categoria_DespesaResponseDtos> GetById(int id);
        Task<TB008_Categoria_DespesaResponseDtos> Create(TB008_Categoria_DespesaRequestDtos despesa);
        Task<TB008_Categoria_DespesaResponseDtos> Update(int id, TB008_Categoria_DespesaRequestDtos despesa);
        Task<TB008_Categoria_DespesaResponseDtos> Delete(int id);
    }
}
