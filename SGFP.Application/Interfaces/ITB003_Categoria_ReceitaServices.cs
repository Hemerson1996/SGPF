using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB003_Categoria_ReceitaServices
    {
        Task<List<TB003_Categoria_ReceitaResponseDtos>> GetAll();
        Task<TB003_Categoria_ReceitaResponseDtos> GetById(int id);
        Task<TB003_Categoria_ReceitaResponseDtos> Create(TB003_Categoria_ReceitaRequestDtos categoria);
        Task<TB003_Categoria_ReceitaResponseDtos> Update(int id,TB003_Categoria_ReceitaRequestDtos categoria);
        Task<TB003_Categoria_ReceitaResponseDtos> Delete(int id);
    }
}
