using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Response
{
    public class TB009_Tipo_DespesaResponseDto
    {
        public int tipo_Despesa_Id { get; set; }
        public int categoria_Despesa_Id { get; set; }
        public TB008_Categoria_DespesaResponseDtos TB008_Categoria_DespesaResponseDtos { get; set; }
        public string tipo_Despesa_Nome { get; set; }
    }
}
