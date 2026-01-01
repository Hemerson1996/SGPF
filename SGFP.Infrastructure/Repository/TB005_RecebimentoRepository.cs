using SGFP.Domain.Entities;
using SGFP.Domain.Interfaces;
using SGFP.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Infrastructure.Repository
{
    public class TB005_RecebimentoRepository : BaseRepository<TB005_Recebimento>, ITB005_RecebimentoRepository
    {
        public TB005_RecebimentoRepository(AppSGPFContext context) : base(context)
        {
        }
    }
}
