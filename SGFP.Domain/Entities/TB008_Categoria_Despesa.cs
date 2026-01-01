using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB008_Categoria_Despesa
    {
        public int categoria_Despesa_Id {  get; set; }
        public string categoria_Despesa_Nome { get; set; }
        public string categoria_Despesa_Descricao { get; set; }

        public virtual ICollection<TB009_Tipo_Despesa> TB009_Tipo_Despesa { get; set; }
        public virtual ICollection<TB010_Despesa> TB011_Despesas { get; set; }

    }
}
