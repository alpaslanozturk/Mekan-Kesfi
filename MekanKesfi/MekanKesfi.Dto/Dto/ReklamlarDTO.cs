using System;
using System.Collections.Generic;
using System.Text;

namespace MekanKesfi.Dto.Dto
{
    public class ReklamlarDTO
    {
        public class ReklamMekanDTO
        {
            public int ReklamId { get; set; }
            public string ReklamDetay { get; set; }
            public string ReklamFoto { get; set; }
            public DateTime ReklamBitis { get; set; }
        }
    }
}
