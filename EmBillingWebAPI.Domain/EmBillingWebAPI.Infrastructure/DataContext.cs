using EmBillingWebAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Infrastructure
{
    public class DataContext: Microsoft.EntityFrameworkCore.DbContext
    {

        public DataContext(DbContextOptions<DataContext>options):base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRoleAccess> UserRoleAccess { get; set; }
        public DbSet<ClaimType> ClaimTypes { get; set; }

        public DbSet<Rule> Rules { get; set; }

        public DbSet<Reference> References { get; set; }

        public DbSet<PolicyRule> PolicyRules { get; set; }

        public DbSet<ReferenceTypes> ReferenceTypes { get; set; }

        public DbSet<Policies> Policies { get; set; }

        public DbSet<Navigation> Navigation { get; set; }

        public DbSet<ReferenceTypeCorrelations> ReferenceTypeCorrelations { get; set; }

        public DbSet<ReferenceCorrelations> ReferenceCorrelations { get; set; }


    }
}
