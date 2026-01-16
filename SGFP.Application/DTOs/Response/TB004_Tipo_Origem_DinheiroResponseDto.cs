using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Response
{
    public class TB004_Tipo_Origem_DinheiroResponseDto
    {
        public int tipoOrigemDinheiro_Id { get; set; }
        public TB003_Categoria_ReceitaResponseDtos TB003_Categoria_ReceitaResponseDtos { get; set; } 
        public string tipo_Nome { get; set; }
        public string tipo_Descricao { get; set; }
    }
}
