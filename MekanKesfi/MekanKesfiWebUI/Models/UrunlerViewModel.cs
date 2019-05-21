using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MekanKesfi.Dto.Dto.UrunlerDTO;

namespace MekanKesfiWebUI.Models
{
    public class UrunlerViewModel
    {
        public List<UrunMekanDTO> UrunListe { get; set; }
        public UrunDetayDTO UrunDetay { get; set; }
    }
}
