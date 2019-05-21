using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MekanKesfi.Entities.Concrete
{
    public class Roller : IdentityRole
    {
        public ICollection<Kullanicilar> Kullanicilar { get; set; }
    }
}
