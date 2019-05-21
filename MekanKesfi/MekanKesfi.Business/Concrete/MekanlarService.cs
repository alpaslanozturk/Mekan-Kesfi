using MekanKesfi.Business.Abstract;
using MekanKesfi.DataAccess.Abstract;
using MekanKesfi.Dto.Dto;
using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.Business.Concrete
{
    public class MekanlarService : IMekanlarService
    {
        private IMekanlarRepository _mekanlarRep;

        public MekanlarService(IMekanlarRepository mekanlarRep)
        {
            _mekanlarRep = mekanlarRep;
        }

        public void Add(Mekanlar entity)
        {
            _mekanlarRep.Add(entity);
        }

        public void Delete(Mekanlar entity)
        {
            _mekanlarRep.Delete(entity);
        }

        public async Task<Mekanlar> GetMekan(int mekanId)
        {
            return await _mekanlarRep.GetMekan(mekanId);
        }

        public async Task<List<Mekanlar>> GetMekanListe(string aranan)
        {
            return await _mekanlarRep.GetMekanListe(aranan);
        }

        public void Update(Mekanlar entity)
        {
            _mekanlarRep.Update(entity);
        }
    }
}
