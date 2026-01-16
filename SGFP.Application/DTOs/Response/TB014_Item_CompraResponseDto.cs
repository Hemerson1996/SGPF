using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Response
{
    public class TB014_Item_CompraResponseDto
    {
        public int item_Compra_Id { get; set; }
        public int usuario_Id { get; set; }
        public int categoria_Produto_Compra_ID { get; set; }
        public TB011_Categoria_Produto_CompraResponseDto TB011_Categoria_Produto_CompraResponseDto { get; set; }
        public int unidade_Produto_Compra_Id { get; set; }
        public TB012_Unidade_Produto_CompraResponseDto TB012_Unidade_Produto_CompraResponseDto { get; set; }
        public int item_Produto_Compra_Id { get; set; }
        public TB013_Item_Produto_CompraResponseDto TB013_Item_Produto_CompraResponseDto { get; set; }
        public int item_Compra_Quantidade { get; set; }
        public double item_Compra_Preco_Unitario { get; set; }
        public double item_Compra_Total { get; set; }
        public DateTime item_Compra_Data_Compra { get; set; }
    }
}
