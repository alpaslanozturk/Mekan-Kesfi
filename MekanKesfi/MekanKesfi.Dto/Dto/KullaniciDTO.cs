using System;
using System.Collections.Generic;
using System.Text;

namespace MekanKesfi.Dto.Dto
{
    public class KullaniciDTO
    {
        public class RegisterDTO
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
        public class LoginDTO
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
