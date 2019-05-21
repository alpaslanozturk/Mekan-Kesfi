using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MekanKesfi.Business.Abstract;
using MekanKesfiWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static MekanKesfi.Dto.Dto.IllerDTO;
using static MekanKesfi.Dto.Dto.MekanlarDTO;
using static MekanKesfi.Dto.Dto.ReklamlarDTO;
using static MekanKesfi.Dto.Dto.UrunlerDTO;

namespace MekanKesfiWebUI.Controllers
{
    public class MekanlarController : Controller
    {
        private IMekanlarService _serviceMekan;
        private MekanlarViewModel _model;
        private IUrunlerService _serviceUrun;
        private IMapper _mapper;
        private IReklamlarService _serviceReklam;
        private IIllerService _serviceIl;
        private IIlcelerService _serviceIlce;

        public MekanlarController(IMekanlarService serviceMekan, MekanlarViewModel model,
            IUrunlerService serviceUrun, IMapper mapper, IReklamlarService serviceReklam,
            IIllerService serviceIl, IIlcelerService serviceIlce)
        {
            _serviceMekan = serviceMekan;
            _model = model;
            _serviceUrun = serviceUrun;
            _mapper = mapper;
            _serviceReklam = serviceReklam;
            _serviceIl = serviceIl;
            _serviceIlce = serviceIlce;
        }

        public async Task<IActionResult> Liste(string aranan)
        {
            _model.MekanListe = _mapper.Map<List<MekanlarListeDTO>>(await _serviceMekan.GetMekanListe(aranan));           
            
            return View(_model);
        }


        public async Task<IActionResult> Detay(int mekanId)
        {
            _model.MekanDetay = _mapper.Map<MekanlarDetayDTO>(await _serviceMekan.GetMekan(mekanId));
            _model.UrunListe = _mapper.Map<List<UrunMekanDTO>>(await _serviceUrun.GetMekanUrun(mekanId));
            _model.ReklamListe = _mapper.Map<List<ReklamMekanDTO>>(await _serviceReklam.GetReklamMekan(mekanId));
            return View(_model);
        }
      
    }
}