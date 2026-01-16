using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Response
{
    public class TB007_ReceitaResponseDto
    {
        public int receita_Id { get; set; }
        public int usuario_Id { get; set; }
        public int Tipo_Origem_Dinheiro_Id { get; set; }
        public TB004_Tipo_Origem_DinheiroResponseDto TB004_Tipo_Origem_DinheiroResponseDtos { get; set; }
        public int recebimento_Id { get; set; }
        public int frequencia_Id { get; set; }
        public decimal receita_Valor { get; set; }

        public DateTime data_Inicio { get; set; }
        public DateTime? data_Fim { get; set; }
        public bool ativo { get; set; }
    }
}
