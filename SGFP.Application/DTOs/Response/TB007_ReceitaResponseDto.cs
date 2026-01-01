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
        public int categoriaReceita_Id { get; set; }
        public int recebimento_Id { get; set; }
        public int frequencia_Id { get; set; }
        public double receita_Valor { get; set; }
    }
}
