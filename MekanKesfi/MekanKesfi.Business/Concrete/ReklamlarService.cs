using MekanKesfi.Business.Abstract;
using MekanKesfi.DataAccess.Abstract;
using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.Business.Concrete
{
    public class ReklamlarService : IReklamlarService
    {
        private IReklamlarRepository _reklamRep;

        public ReklamlarService(IReklamlarRepository reklamRep)
        {
            _reklamRep = reklamRep;
        }

        public async Task<List<Reklamlar>> GetReklamMekan(int mekanId)
        {
            return await _reklamRep.GetList(x => x.MekanlarId == mekanId);
        }
    }
}
