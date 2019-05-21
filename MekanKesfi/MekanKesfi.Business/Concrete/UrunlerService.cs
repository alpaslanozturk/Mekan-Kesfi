using MekanKesfi.Business.Abstract;
using MekanKesfi.DataAccess.Abstract;
using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.Business.Concrete
{
    public class UrunlerService : IUrunlerService
    {
        private IUrunlerRepository _repoUrun;

        public UrunlerService(IUrunlerRepository repoUrun)
        {
            _repoUrun = repoUrun;
        }

        public async Task<List<Urunler>> GetMekanUrun(int mekanId)
        {
            return await _repoUrun.GetList(x=> x.MekanlarId == mekanId);
        }

        public async Task<Urunler> GetUrunDetay(int urunId)
        {
            return await _repoUrun.GetUrunlerDetay(urunId);
        }

        public async Task<List<Urunler>> GetUrunlerBilgiListe()
        {
            return await _repoUrun.GetUrunlerBilgiListe();
        }

        public async Task<List<Urunler>> GetUrunListe()
        {
            return await _repoUrun.GetList();
        }
    }
}
