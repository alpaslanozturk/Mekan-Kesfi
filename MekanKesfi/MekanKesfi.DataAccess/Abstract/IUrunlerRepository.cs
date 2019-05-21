using MekanKesfi.Core.DataAccess;
using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.DataAccess.Abstract
{
    public interface IUrunlerRepository : IEntityRepositoryBase<Urunler>
    {
        Task<List<Urunler>> GetUrunlerBilgiListe();

        Task<Urunler> GetUrunlerDetay(int urunId);
    }
}
