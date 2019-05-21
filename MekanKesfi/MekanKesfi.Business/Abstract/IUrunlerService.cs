using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.Business.Abstract
{
    public interface IUrunlerService
    {
        Task<List<Urunler>> GetMekanUrun(int mekanId);
        Task<List<Urunler>> GetUrunListe();
        Task<List<Urunler>> GetUrunlerBilgiListe();
        Task<Urunler> GetUrunDetay(int urunId);
    }
}
