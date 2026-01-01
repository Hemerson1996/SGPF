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
    public class TB004_Tipo_Origem_DinheiroMap : IEntityTypeConfiguration<TB004_Tipo_Origem_Dinheiro>
    {
        public void Configure(EntityTypeBuilder<TB004_Tipo_Origem_Dinheiro> builder)
        {
            builder.ToTable("TB004_TIPO_ORIGEM_DINHEIRO");
            builder.HasKey(x=>x.tipoOrigemDinheiro_Id);

            builder.Property(x => x.tipoOrigemDinheiro_Id)
                    .HasColumnName("TIPO_ORIGEM_DINHEIRO_ID")
                    .IsRequired();

            builder.Property(x => x.categoriaReceita_Id)
                     .HasColumnName("CATEGORIA_RECEITA_ID")
                     .IsRequired();

            builder.Property(x => x.tipo_Nome)
                   .HasColumnName("TIPO_NOME")
                   .IsRequired();

            builder.Property(x => x.tipo_Descricao)
                  .HasColumnName("TIPO_DESCRICAO")
                  .IsRequired();

            builder.HasOne(x=>x.TB003_Categoria_Receita)
                .WithMany(x=>x.TB004_Tipo_Origem_Dinheiros)
                .HasForeignKey(x=>x.categoriaReceita_Id)
                .OnDelete(DeleteBehavior.Restrict);

        
        }
    }
}
