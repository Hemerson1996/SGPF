using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Request
{
    public class TB014_Item_CompraRequestDto
    {
        public int item_Compra_Id { get; set; }
        public int usuario_Id { get; set; }
        public int categoria_Produto_Compra_ID { get; set; }
        public int unidade_Produto_Compra_Id { get; set; }
        public int item_Produto_Compra_Id { get; set; }
        public int item_Compra_Quantidade { get; set; }
        public double item_Compra_Preco_Unitario { get; set; }
        public double item_Compra_Total { get; set; }
        public DateTime item_Compra_Data_Compra { get; set; }
    }
}
