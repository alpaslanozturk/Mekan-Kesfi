using System;
using System.Collections.Generic;
using System.Text;

namespace MekanKesfi.Dto.Dto
{
    public class UrunlerDTO
    {
        public class UrunMekanDTO
        {
            public int UrunId { get; set; }
            public string UrunAd { get; set; }
            public decimal UrunFiyat { get; set; }
            public string MekanAd { get; set; }
            public string IlAd { get; set; }
            public string IlceAd { get; set; }
            public string UrunFoto { get; set; }
        }

        public class UrunDetayDTO
        {
            public int UrunId { get; set; }
            public string UrunAd { get; set; }
            public decimal UrunFiyat { get; set; }
            public string UrunFoto { get; set; }
            public string MekanAd { get; set; }
            public string IlAd { get; set; }
            public string IlceAd { get; set; }
            public int MekanId { get; set; }
        }
    }
}
