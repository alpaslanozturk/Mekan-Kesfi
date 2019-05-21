using MekanKesfi.Business.Abstract;
using MekanKesfi.DataAccess.Abstract;
using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.Business.Concrete
{
    public class IlcelerService : IIlcelerService
    {
        private IIlcelerRepository _ilcelerRep;

        public IlcelerService(IIlcelerRepository ilcelerRep)
        {
            _ilcelerRep = ilcelerRep;
        }

        public async Task<List<Ilceler>> GetIlcelerArama(int ilId)
        {
            return await _ilcelerRep.GetList(x=> x.IllerId == ilId);
        }
    }
}
