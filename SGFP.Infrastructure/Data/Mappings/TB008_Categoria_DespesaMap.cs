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
    public class TB008_Categoria_DespesaMap : IEntityTypeConfiguration<TB008_Categoria_Despesa>
    {
        public void Configure(EntityTypeBuilder<TB008_Categoria_Despesa> builder)
        {
            builder.ToTable("TB008_CATEGORIA_DESPESA");
            builder.HasKey(x=>x.categoria_Despesa_Id);

            builder.Property(x => x.categoria_Despesa_Id)
                .HasColumnName("CATEGORIA_DESPESA_ID")
                .IsRequired();

            builder.Property(x => x.categoria_Despesa_Nome)
                .HasColumnName("CATEGORIA_DESPESA_NOME")
                .IsRequired();

            builder.Property(x => x.categoria_Despesa_Descricao)
               .HasColumnName("CATEGORIA_DESPESA_DESCRICAO")
               .IsRequired();
        }
    }
}
