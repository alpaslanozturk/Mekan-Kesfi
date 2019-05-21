using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.Business.Abstract
{
    public interface IIllerService
    {
        Task<List<Iller>> GetIller();
    }
}
