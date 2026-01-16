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
    public class TB015_Status_PagamentosMap : IEntityTypeConfiguration<TB015_Status_Pagamentos>
    {
        public void Configure(EntityTypeBuilder<TB015_Status_Pagamentos> builder)
        {
            builder.ToTable("TB015_STATUS_PAGAMENTO");
            builder.HasKey(x => x.status_Pagamento_Id);

            builder.Property(x => x.status_Pagamento_Id)
            .HasColumnName("STATUS_PAGAMENTO_ID")
            .IsRequired();

            builder.Property(x => x.status_Pagamento_Nome)
            .HasColumnName("STATUS_PAGAMENTO_NOME")
            .IsRequired();

            builder.Property(x => x.status_Pagamento_Status)
            .HasColumnName("STATUS_PAGAMENTO_STATUS")
            .IsRequired();
        }
    }
}
