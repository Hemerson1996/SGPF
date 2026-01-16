using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Interfaces
{
    public interface ITokenService
    {
       string GerarToken(TB001_Usuario usuario);
    }
}
