using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB010_Despesa
    {
        public int despesa_Id { get; set; }
        public int usuario_Id { get; set; }
        public int categoria_Despesa_Id { get; set; }
        public TB008_Categoria_Despesa TB008_Categoria_Despesas { get; set; }
        public string despesa_Descricao { get; set; }
        public decimal despesa_Valor { get; set; }
        public DateTime data_Vencimento { get; set; }

    }
}
