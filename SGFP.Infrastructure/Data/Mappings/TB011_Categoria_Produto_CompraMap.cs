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
    public class TB011_Categoria_Produto_CompraMap : IEntityTypeConfiguration<TB011_Categoria_Produto_Compra>
    {
        public void Configure(EntityTypeBuilder<TB011_Categoria_Produto_Compra> builder)
        {
            builder.ToTable("TB011_CATEGORIA_PRODUTO_COMPRA");
            builder.HasKey(x=>x.categoria_Produto_Compra_ID);

            builder.Property(x => x.categoria_Produto_Compra_ID)
                .HasColumnName("CATEGORIA_PRODUTO_COMPRA_ID")
                .IsRequired();

            builder.Property(x => x.categoria_Produto_Compra_Nome)
              .HasColumnName("CATEGORIA_PRODUTO_COMPRA_NOME")
              .IsRequired();
        }
    }
}
