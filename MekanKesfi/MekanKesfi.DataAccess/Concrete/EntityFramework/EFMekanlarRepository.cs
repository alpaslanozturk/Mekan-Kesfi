using MekanKesfi.Core.DataAccess.EntityFramework;
using MekanKesfi.DataAccess.Abstract;
using MekanKesfi.DataAccess.Concrete.Context;
using MekanKesfi.Dto.Dto;
using MekanKesfi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.DataAccess.Concrete.EntityFramework
{
    public class EFMekanlarRepository : EFEntityRepositoryBase<Mekanlar> , IMekanlarRepository
    {

        public EFMekanlarRepository(MekanKesfiContext context) : base(context)
        {
        }

        public async Task<Mekanlar> GetMekan(int mekanId)
        {
            return await Set().Include(x => x.Ilceler).Include(x => x.Ilceler.Iller)
                .Include(x => x.Fotograflar).Include(x=> x.Kullanicilar).FirstOrDefaultAsync(x=> x.MekanId == mekanId);
        }

        public async Task<List<Mekanlar>> GetMekanListe(string aranan)
        {
            if (!String.IsNullOrEmpty(aranan))
            {
                return await Set().Where(x=> x.MekanAd.Contains(aranan)).Include(x => x.Ilceler)
                    .Include(x => x.Ilceler.Iller).Include(x => x.Fotograflar)
                    .Include(x => x.Kullanicilar).ToListAsync();
            }
            return await Set().Include(x => x.Ilceler).Include(x => x.Ilceler.Iller)
                .Include(x => x.Fotograflar).Include(x=> x.Kullanicilar).ToListAsync();
        }
    }
}
