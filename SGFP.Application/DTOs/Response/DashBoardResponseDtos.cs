using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Response
{
    public class DashBoardResponseDtos
    {
        public TotalDto Total { get; set; } = new ();
        public class TotalDto
        {
            public decimal TotalReceita { get; set; }
            public decimal TotalDebito { get; set; }

        }
    }
}
