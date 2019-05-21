using MekanKesfi.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MekanKesfi.Entities.Concrete
{
    [Table("Fotograflar")]
    public class Fotograflar : IEntity
    {
        [Key]
        public int FotografId { get; set; }
        public string FotografYol { get; set; }
        public bool AnaFotograf { get; set; }

        public int MekanlarId { get; set; }
        public Mekanlar Mekanlar { get; set; }
    }
}
