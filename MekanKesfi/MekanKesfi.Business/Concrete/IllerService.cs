using MekanKesfi.Business.Abstract;
using MekanKesfi.DataAccess.Abstract;
using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.Business.Concrete
{
    public class IllerService : IIllerService
    {
        private IIllerRepository _illerRep;

        public IllerService(IIllerRepository illerRep)
        {
            _illerRep = illerRep;
        }

        public async Task<List<Iller>> GetIller()
        {
            return await _illerRep.GetList();
        }
    }
}
