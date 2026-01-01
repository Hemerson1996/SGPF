using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SGFP.Domain.Entities
{
    public class TB011_Categoria_Produto_Compra
    {
        public int categoria_Produto_Compra_ID { get; set; }
        public string categoria_Produto_Compra_Nome { get; set; }

        public virtual ICollection<TB013_Item_Produto_Compra> TB013_Item_Produto_Compras { get; set; }
        public virtual ICollection<TB014_Item_Compra> TB014_Item_Compras { get; set; }

    }
}
