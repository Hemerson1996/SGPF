using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Interfaces
{
    public interface ITB014_Item_CompraRepository:IBaseRepository<TB014_Item_Compra>
    {
        Task<List<TB014_Item_Compra>> GetAllFull();
    }
}
