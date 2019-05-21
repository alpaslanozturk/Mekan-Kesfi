using MekanKesfi.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MekanKesfi.Entities.Concrete
{
    [Table("Mekanlar")]
    public class Mekanlar : IEntity
    {
        public Mekanlar()
        {
            Fotograflar = new HashSet<Fotograflar>();
        }

        [Key]
        public int MekanId { get; set; }
        public string MekanAd { get; set; }
        public string MekanAdres { get; set; }
        public string Telefon { get; set; }
        public string EMail { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }

        public int IlcelerId { get; set; }
        public Ilceler Ilceler { get; set; }

        public string KullanicilarId { get; set; }
        public Kullanicilar Kullanicilar { get; set; }

        public ICollection<Reklamlar> Reklamlar { get; set; }
        public ICollection<Urunler> Urunler { get; set; }
        public ICollection<Fotograflar> Fotograflar { get; set; }
    }
}
