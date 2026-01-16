using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Request
{
    public class TB009_Tipo_DespesaRequestDto
    {
        public int tipo_Despesa_Id { get; set; }
        public int categoria_Despesa_Id { get; set; }
        public string tipo_Despesa_Nome { get; set; }
    }
}
