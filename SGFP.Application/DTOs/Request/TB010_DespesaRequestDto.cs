using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Request
{
    public class TB010_DespesaRequestDto
    {
        public int despesa_Id { get; set; }
        public int usuario_Id { get; set; }
        public int categoria_Despesa_Id { get; set; }
        public int frequencia_Id { get; set; }
        public int status_Pagamento_Id { get; set; }
        public string despesa_Descricao { get; set; }
        public decimal despesa_Valor { get; set; }
        public DateTime data_Vencimento { get; set; }

        public DateTime data_Inicio { get; set; }
        public DateTime? data_Fim { get; set; }
        public bool ativo { get; set; }
    }
}
