using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Request
{
    public class TB013_Item_Produto_CompraRequestDto
    {
        public int item_Produto_Compra_Id { get; set; }
        public string item_Produto_Compra_Nome { get; set; }
        public int categoria_Produto_Compra_ID { get; set; }
    }
}
