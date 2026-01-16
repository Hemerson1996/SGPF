using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Response
{
    public class LoginResponseDto
    {
        public string Token { get; set; }
        public DateTime ExpiraEm { get; set; }
        public string Role { get; set; }
    }
}
