using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.Business.Abstract
{
    public interface IMekanlarService
    {
        Task< List<Mekanlar>> GetMekanListe(string aranan);

        Task<Mekanlar> GetMekan(int mekanId);

        void Add(Mekanlar entity);

        void Update(Mekanlar entity);

        void Delete(Mekanlar entity);

    }
}
