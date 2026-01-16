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
    public class TB012_Unidade_Produto_CompraRepository : BaseRepository<TB012_Unidade_Produto_Compra>, ITB012_Unidade_Produto_CompraRepository
    {
        public TB012_Unidade_Produto_CompraRepository(AppSGPFContext context) : base(context)
        {
        }
    }
}
