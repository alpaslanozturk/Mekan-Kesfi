using MekanKesfi.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MekanKesfi.Dto.Dto.IlcelerDTO;
using static MekanKesfi.Dto.Dto.IllerDTO;
using static MekanKesfi.Dto.Dto.MekanlarDTO;
using static MekanKesfi.Dto.Dto.ReklamlarDTO;
using static MekanKesfi.Dto.Dto.UrunlerDTO;

namespace MekanKesfiWebUI.Models
{
    public class MekanlarViewModel
    {
        public List<MekanlarListeDTO> MekanListe { get; set; }
        public MekanlarDetayDTO MekanDetay { get; set; }
        public List<UrunMekanDTO> UrunListe { get; set; }
        public List<ReklamMekanDTO> ReklamListe { get; set; }
    }
}
