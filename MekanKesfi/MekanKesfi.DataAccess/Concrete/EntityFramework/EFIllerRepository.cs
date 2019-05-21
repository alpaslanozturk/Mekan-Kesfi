using MekanKesfi.Core.DataAccess.EntityFramework;
using MekanKesfi.DataAccess.Abstract;
using MekanKesfi.DataAccess.Concrete.Context;
using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MekanKesfi.DataAccess.Concrete.EntityFramework
{
    public class EFIllerRepository : EFEntityRepositoryBase<Iller>, IIllerRepository
    {
        public EFIllerRepository(MekanKesfiContext context) : base(context)
        {

        }
    }
}
