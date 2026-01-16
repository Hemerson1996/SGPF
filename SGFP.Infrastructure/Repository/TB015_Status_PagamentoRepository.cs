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
    public class TB015_Status_PagamentoRepository : BaseRepository<TB015_Status_Pagamentos>, ITB015_Status_PagamentoRepository
    {
        public TB015_Status_PagamentoRepository(AppSGPFContext context) : base(context)
        {
        }
    }
}
