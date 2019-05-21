using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MekanKesfiWebUI.Models
{
    public class LoginViewModel
    {
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public bool BeniHatirla { get; set; }
    }
}
