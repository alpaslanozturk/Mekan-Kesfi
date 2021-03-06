﻿using MekanKesfi.Core.DataAccess.EntityFramework;
using MekanKesfi.DataAccess.Abstract;
using MekanKesfi.DataAccess.Concrete.Context;
using MekanKesfi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MekanKesfi.DataAccess.Concrete.EntityFramework
{
    public class EFReklamlarRepository : EFEntityRepositoryBase<Reklamlar>, IReklamlarRepository
    {
        public EFReklamlarRepository(MekanKesfiContext context) : base(context)
        {

        }
    }
}
