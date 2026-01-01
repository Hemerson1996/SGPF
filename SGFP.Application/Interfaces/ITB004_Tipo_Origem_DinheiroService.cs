using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITB004_Tipo_Origem_DinheiroService
    {
        Task <List<TB004_Tipo_Origem_DinheiroResponseDto>> GetAll();
        Task <TB004_Tipo_Origem_DinheiroResponseDto> GetById(int id);
        Task <TB004_Tipo_Origem_DinheiroResponseDto> Create(TB004_Tipo_Origem_DinheiroRequestDto request);
        Task <TB004_Tipo_Origem_DinheiroResponseDto> Update(int id,TB004_Tipo_Origem_DinheiroRequestDto request);
        Task <TB004_Tipo_Origem_DinheiroResponseDto> Delete(int id);
    }
}
