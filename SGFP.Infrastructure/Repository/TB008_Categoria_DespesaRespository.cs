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
    public class TB008_Categoria_DespesaRespository : BaseRepository<TB008_Categoria_Despesa>, ITB008_Categoria_DespesaRespository
    {
        public TB008_Categoria_DespesaRespository(AppSGPFContext context) : base(context)
        {
        }
    }
}
