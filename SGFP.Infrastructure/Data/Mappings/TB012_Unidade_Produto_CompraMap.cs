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
    public class TB012_Unidade_Produto_CompraMap : IEntityTypeConfiguration<TB012_Unidade_Produto_Compra>
    {
        public void Configure(EntityTypeBuilder<TB012_Unidade_Produto_Compra> builder)
        {
            builder.ToTable("TB012_UNIDADE_PRODUTO_COMPRA");
            builder.HasKey(x => x.unidade_Produto_Compra_Id);

            builder.Property(x => x.unidade_Produto_Compra_Id)
                .HasColumnName("UNIDADE_PRODUTO_COMPRA_ID")
                .IsRequired();

            builder.Property(x => x.unidade_Produto_Compra_Nome)
              .HasColumnName("UNIDADE_PRODUTO_COMPRA_NOME")
              .IsRequired();
        }
    }
}

