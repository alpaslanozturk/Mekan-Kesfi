using MekanKesfi.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MekanKesfi.Entities.Concrete
{
    [Table("Iller")]
    public class Iller : IEntity
    {
        [Key]
        public int IlId { get; set; }
        public string IlAd { get; set; }

        public ICollection<Ilceler> Ilceler { get; set; }
    }
}
