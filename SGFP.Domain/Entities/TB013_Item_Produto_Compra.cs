using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB013_Item_Produto_Compra
    {
        public int item_Produto_Compra_Id {  get; set; }
        public string item_Produto_Compra_Nome {  get; set; }
        public int categoria_Produto_Compra_ID { get; set; }
        public TB011_Categoria_Produto_Compra TB011_Categoria_Produto_Compras { get; set; }
        public virtual ICollection<TB014_Item_Compra> TB014_Item_Compras { get; set; }

    }
}
