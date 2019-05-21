using MekanKesfi.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MekanKesfi.Entities.Concrete
{
    [Table("Ilceler")]
    public class Ilceler : IEntity
    {
        [Key]
        public int IlceId { get; set; }
        public string IlceAd { get; set; }

        public int IllerId { get; set; }
        public Iller Iller { get; set; }

        public ICollection<Mekanlar> Mekanlar { get; set; }
    }
}
