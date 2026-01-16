using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB007_Receita
    {
        public int receita_Id { get; set; }
        public int usuario_Id { get; set; }
        public int tipo_Origem_Dinheiro_Id { get; set; }   
        public TB004_Tipo_Origem_Dinheiro TB004_Tipo_Origem_Dinheiros { get; set; }

        public int recebimento_Id { get; set; }
        public TB005_Recebimento? TB005_Recebimentos { get; set; }

        public int frequencia_Id { get; set; }
        public TB006_Frequencia? TB006_Frequencias { get; set; }
        public decimal receita_Valor { get; set; }
        public DateTime data_Inicio { get; set; }
        public DateTime? data_Fim { get; set; }
        public bool ativo { get; set; }
    }
}
