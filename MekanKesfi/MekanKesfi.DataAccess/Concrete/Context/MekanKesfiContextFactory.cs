using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MekanKesfi.DataAccess.Concrete.Context
{
    public class MekanKesfiContextFactory : IDesignTimeDbContextFactory<MekanKesfiContext>
    {
        public MekanKesfiContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MekanKesfiContext>();
            optionsBuilder.UseSqlServer(@"Server=ALP-EXPER\SQLEXPRESS;Database=MekanKesfiDB;Trusted_Connection=true;");
            return new MekanKesfiContext(optionsBuilder.Options);
        }
    }
}
