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
        public int categoriaReceita_Id { get; set; }   
        public TB003_Categoria_Receita TB003_Categoria_Receitas { get; set; }

        public int recebimento_Id { get; set; }
        public TB005_Recebimento TB005_Recebimentos { get; set; }

        public int frequencia_Id { get; set; }
        public TB006_Frequencia TB006_Frequencias { get; set; }
        public double receita_Valor { get; set; }
    }
}
