using MekanKesfi.Core.DataAccess.EntityFramework;
using MekanKesfi.DataAccess.Abstract;
using MekanKesfi.DataAccess.Concrete.Context;
using MekanKesfi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.DataAccess.Concrete.EntityFramework
{
    public class EFUrunlerRepository : EFEntityRepositoryBase<Urunler>, IUrunlerRepository
    {
        public EFUrunlerRepository(MekanKesfiContext context) : base(context)
        {
        }

        public async Task<List<Urunler>> GetUrunlerBilgiListe()
        {
            return await Set().Include(x => x.Mekanlar).Include(x => x.Mekanlar.Ilceler)
                .Include(x => x.Mekanlar.Ilceler.Iller).ToListAsync();
        }

        public async Task<Urunler> GetUrunlerDetay(int urunId)
        {
            return await Set().Include(x => x.Mekanlar).Include(x => x.Mekanlar.Ilceler)
                .Include(x => x.Mekanlar.Ilceler.Iller).FirstOrDefaultAsync(x=> x.UrunId == urunId);
        }
    }
}
