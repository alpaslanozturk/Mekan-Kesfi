using MekanKesfi.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MekanKesfi.Entities.Concrete
{
    [Table("Urunler")]
    public class Urunler : IEntity
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public decimal UrunFiyat { get; set; }
        public string UrunFoto { get; set; }

        public int MekanlarId { get; set; }
        public Mekanlar Mekanlar { get; set; }
    }
}
