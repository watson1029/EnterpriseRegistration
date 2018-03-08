using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseRegistration.DataAccess.Context
{
    public class CommercialAffairsDbContext : DbContext
    {
        public CommercialAffairsDbContext(DbContextOptions<CommercialAffairsDbContext> options) : base(options)
        {
        }

        public DbSet<Entity.EX_GONGSHANG_41_SSZTJCXX> EX_GONGSHANG_41_SSZTJCXX { get; set; }

        public DbSet<Entity.EX_GONGSHANG_48_SSZTGDXX> EX_GONGSHANG_48_SSZTGDXX { get; set; }
    }
}
