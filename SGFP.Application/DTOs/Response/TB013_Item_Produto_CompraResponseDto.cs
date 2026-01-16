using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Response
{
    public class TB013_Item_Produto_CompraResponseDto
    {
        public int item_Produto_Compra_Id { get; set; }
        public string item_Produto_Compra_Nome { get; set; }
        public int categoria_Produto_Compra_ID { get; set; }
        public TB011_Categoria_Produto_CompraResponseDto TB011_Categoria_Produto_CompraResponseDto { get; set; }
    }
}
