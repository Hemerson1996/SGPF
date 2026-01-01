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
    public class TB007_ReceitaRepository : BaseRepository<TB007_Receita>, ITB007_ReceitaRepository
    {
        public TB007_ReceitaRepository(AppSGPFContext context) : base(context)
        {
        }
    }
}
