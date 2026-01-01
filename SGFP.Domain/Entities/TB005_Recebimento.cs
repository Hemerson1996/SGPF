using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB005_Recebimento
    {
        public int recebimento_Id { get; set; }
        public string recebimento_Nome { get; set; }
        public string recebimento_Descricao { get; set; }

        public virtual ICollection<TB007_Receita> TB007_Receitas { get; set; }
    }
}
