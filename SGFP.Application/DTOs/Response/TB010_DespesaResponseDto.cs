using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Response
{
    public class TB010_DespesaResponseDto
    {
        public int despesa_Id { get; set; }
        public int usuario_Id { get; set; }
        public int categoria_Despesa_Id { get; set; }
        public TB008_Categoria_DespesaResponseDtos TB008_Categoria_DespesaResponseDtos { get; set; }
        public TB006_FrequenciaResponseDto TB006_FrequenciaResponseDtos {get; set; }
        public TB015_Status_PagamentoResponseDto TB015_Status_PagamentoResponseDtos {get; set; }
        public string despesa_Descricao { get; set; }
        public decimal despesa_Valor { get; set; }
        public DateTime data_Vencimento { get; set; }

        public DateTime data_Inicio { get; set; }
        public DateTime? data_Fim { get; set; }
        public bool ativo { get; set; }
    }
}
