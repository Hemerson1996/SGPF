using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Interfaces
{
    public interface ITB013_Item_Produto_CompraRepository:IBaseRepository<TB013_Item_Produto_Compra>
    {
        Task<List<TB013_Item_Produto_Compra>> GetAllFull();
    }
}
