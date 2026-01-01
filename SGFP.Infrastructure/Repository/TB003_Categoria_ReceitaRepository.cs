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
    public class TB003_Categoria_ReceitaRepository : BaseRepository<TB003_Categoria_Receita>, ITB003_Categoria_ReceitaRepository
    {
        public TB003_Categoria_ReceitaRepository(AppSGPFContext context) : base(context)
        {
        }
    }
}
