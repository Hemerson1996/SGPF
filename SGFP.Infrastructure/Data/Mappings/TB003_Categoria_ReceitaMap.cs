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
    public class TB003_Categoria_ReceitaMap : IEntityTypeConfiguration<TB003_Categoria_Receita>
    {
        public void Configure(EntityTypeBuilder<TB003_Categoria_Receita> builder)
        {
            builder.ToTable("TB003_CATEGORIA_RECEITA");
            builder.HasKey(x => x.categoriaReceita_Id);

            builder.Property(x => x.categoriaReceita_Id)
                    .HasColumnName("CATEGORIA_RECEITA_ID")
                    .IsRequired();

            builder.Property(x => x.categoriaReceita_Nome)
                    .HasColumnName("CATEGORIA_RECEITA_NOME")
                    .IsRequired();
        }
    }
}
