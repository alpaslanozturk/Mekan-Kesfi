using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MekanKesfi.Business.Abstract;
using MekanKesfiWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using static MekanKesfi.Dto.Dto.UrunlerDTO;

namespace MekanKesfiWebUI.Controllers
{
    public class UrunlerController : Controller
    {
        private IMekanlarService _serviceMekan;
        private UrunlerViewModel _model;
        private IUrunlerService _serviceUrun;
        private IMapper _mapper;

        public UrunlerController(IMekanlarService serviceMekan, UrunlerViewModel model,
            IUrunlerService serviceUrun, IMapper mapper)
        {
            _serviceMekan = serviceMekan;
            _model = model;
            _serviceUrun = serviceUrun;
            _mapper = mapper;
        }

        public async Task< IActionResult> Liste()
        {
            _model.UrunListe = _mapper.Map<List<UrunMekanDTO>>(await _serviceUrun.GetUrunListe());
            return View(_model);
        }

        public async Task<IActionResult> UrunDetay(int urunId)
        {
            _model.UrunDetay = _mapper.Map<UrunDetayDTO>(await _serviceUrun.GetUrunDetay(urunId));
            return View(_model);
        }

    }
}