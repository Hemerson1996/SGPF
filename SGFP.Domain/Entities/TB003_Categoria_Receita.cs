
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB003_Categoria_Receita
    {
        public int categoriaReceita_Id { get; set; }
        public string categoriaReceita_Nome { get; set; }

        public virtual ICollection<TB004_Tipo_Origem_Dinheiro> TB004_Tipo_Origem_Dinheiros { get; set; }


    }
}
