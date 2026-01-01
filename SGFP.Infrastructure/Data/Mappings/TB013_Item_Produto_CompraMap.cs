using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Infrastructure.Data.Mappings
{
    public class TB013_Item_Produto_CompraMap : IEntityTypeConfiguration<TB013_Item_Produto_Compra>
    {
        public void Configure(EntityTypeBuilder<TB013_Item_Produto_Compra> builder)
        {
            builder.ToTable("TB013_ITEM_PRODUTO_COMPRA");
            builder.HasKey(x => x.item_Produto_Compra_Id);

            builder.Property(x => x.item_Produto_Compra_Id)
                .HasColumnName("ITEM_PRODUTO_COMPRA_ID")
                .IsRequired();

            builder.Property(x => x.categoria_Produto_Compra_ID)
            .HasColumnName("CATEGORIA_PRODUTO_COMPRA_ID")
            .IsRequired();

            builder.Property(x => x.item_Produto_Compra_Nome)
              .HasColumnName("ITEM_PRODUTO_COMPRA_NOME")
              .IsRequired();

           

            builder.HasOne(x=>x.TB011_Categoria_Produto_Compras)
                .WithMany(x=>x.TB013_Item_Produto_Compras)
                .HasForeignKey(x=>x.categoria_Produto_Compra_ID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
