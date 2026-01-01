using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB012_Unidade_Produto_Compra
    {
        public int unidade_Produto_Compra_Id {  get; set; }
        public string unidade_Produto_Compra_Nome { get; set; }

        public virtual ICollection<TB014_Item_Compra> TB014_Item_Compras { get; set; }

    }
}
