using MekanKesfi.Core.DataAccess;
using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.DataAccess.Abstract
{
    public interface IMekanlarRepository : IEntityRepositoryBase<Mekanlar>
    {
        Task<List<Mekanlar>> GetMekanListe(string aranan);

        Task<Mekanlar> GetMekan(int mekanId);
    }


}
