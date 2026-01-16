using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB004_Tipo_Origem_Dinheiro
    {
        public int tipoOrigemDinheiro_Id {  get; set; }
        public int categoriaReceita_Id { get; set; }
        public TB003_Categoria_Receita TB003_Categoria_Receita { get; set; } 
        public string tipo_Nome { get; set; }
        public string tipo_Descricao { get; set; }

        public virtual ICollection<TB007_Receita> TB007_Receitas { get; set; }


    }
}
