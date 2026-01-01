using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB009_Tipo_Despesa
    {
        public int tipo_Despesa_Id { get; set; }
        public int categoria_Despesa_Id { get; set; }
        public TB008_Categoria_Despesa TB008_Categoria_Despesas { get; set; }
        public string tipo_Despesa_Nome { get; set; }

    }
}
