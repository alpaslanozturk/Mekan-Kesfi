using MekanKesfi.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MekanKesfi.Entities.Concrete
{
    [Table("Reklamlar")]
    public class Reklamlar : IEntity
    {
        [Key]
        public int ReklamId { get; set; }
        public string ReklamDetay { get; set; }
        public string ReklamFoto { get; set; }
        public DateTime ReklamBitis { get; set; }

        public int MekanlarId { get; set; }
        public Mekanlar Mekanlar { get; set; }
    }
}
