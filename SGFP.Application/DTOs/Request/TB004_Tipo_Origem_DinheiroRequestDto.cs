using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Request
{
    public class TB004_Tipo_Origem_DinheiroRequestDto
    {
        public int tipoOrigemDinheiro_Id { get; set; }
        public int categoriaReceita_Id { get; set; }
        public string tipo_Nome { get; set; }
        public string tipo_Descricao { get; set; }
    }
}
