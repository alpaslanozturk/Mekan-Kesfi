using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MekanKesfi.Dto.Dto
{
    public class MekanlarDTO
    {
        public class MekanlarDetayDTO
        {
            public int MekanId { get; set; }
            public string MekanAd { get; set; }
            public string MekanAdres { get; set; }
            public string EMail { get; set; }
            public decimal Lat { get; set; }
            public decimal Lng { get; set; }
            public string IlAd { get; set; }
            public string IlceAd { get; set; }
            public string MekanSahibiAd { get; set; }
            public List<Fotograflar> FotoList { get; set; }
        }

        public class MekanlarListeDTO
        {
            public int MekanId { get; set; }
            public string MekanAd { get; set; }
            public string MekanFoto { get; set; }
            public string MekanAdres { get; set; }
            public string IlAd { get; set; }
            public string IlceAd { get; set; }
            public string MekanSahibiAd { get; set; }
        }
    }
}
