using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MekanKesfi.Entities.Concrete
{
    public class Kullanicilar : IdentityUser
    {

        public ICollection<Mekanlar> Mekanlar { get; set; }
    }
}
