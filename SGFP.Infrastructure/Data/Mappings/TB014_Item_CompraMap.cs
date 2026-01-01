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
    public class TB014_Item_CompraMap : IEntityTypeConfiguration<TB014_Item_Compra>
    {
        public void Configure(EntityTypeBuilder<TB014_Item_Compra> builder)
        {
            builder.ToTable("TB014_ITEM_COMPRA");
            builder.HasKey(x=>x.item_Compra_Id);

            builder.Property(x => x.item_Compra_Id)
                .HasColumnName("ITEM_COMPRA_ID")
                .IsRequired();

            builder.Property(x => x.usuario_Id)
           .HasColumnName("USUARIO_ID")
           .IsRequired();

            builder.Property(x => x.categoria_Produto_Compra_ID)
           .HasColumnName("CATEGORIA_PRODUTO_COMPRA_ID")
           .IsRequired();

            builder.Property(x => x.unidade_Produto_Compra_Id)
           .HasColumnName("UNIDADE_PRODUTO_COMPRA_ID")
           .IsRequired();

            builder.Property(x => x.item_Produto_Compra_Id)
           .HasColumnName("ITEM_PRODUTO_COMPRA_ID")
           .IsRequired();

            builder.Property(x => x.item_Compra_Quantidade)
              .HasColumnName("ITEM_COMPRA_QUANTIDADE")
              .IsRequired();

            builder.Property(x => x.item_Compra_Preco_Unitario)
            .HasColumnName("ITEM_COMPRA_PRECO_UNITARIO")
            .HasColumnType("decimal(18,2)")
            .IsRequired();

            builder.Property(x => x.item_Compra_Total)
           .HasColumnName("ITEM_COMPRA_TOTAL")
           .HasColumnType("decimal(18,2)")
           .IsRequired();

            builder.Property(x => x.item_Compra_Data_Compra)
            .HasColumnName("ITEM_COMPRA_DATA_COMPRA")
            .IsRequired();


            builder.HasOne(x=>x.TB011_Categoria_Produto_Compras)
                .WithMany(x=>x.TB014_Item_Compras)
                .HasForeignKey(x=>x.categoria_Produto_Compra_ID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TB012_Unidade_Produto_Compras)
            .WithMany(x => x.TB014_Item_Compras)
            .HasForeignKey(x => x.unidade_Produto_Compra_Id)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TB013_Item_Produto_Compra)
            .WithMany(x => x.TB014_Item_Compras)
            .HasForeignKey(x => x.item_Produto_Compra_Id)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
