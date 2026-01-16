using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB006_Frequencia
    {
        public int frequencia_Id { get; set; }
        public string frequencia_Nome { get; set; }
        public string frequencia_Descricao { get; set; }

        public virtual ICollection<TB007_Receita> TB007_Receitas { get; set; }
        public virtual ICollection<TB010_Despesa> TB010_Despesas { get; set; }
    }
}
