
using Emtec.EmBilling.Forecast.Api.Models.Domain_Library;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emtec.EmBilling.Forecast.Abstractions
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //users comes from Infra models 
        public DbSet<User> Users { get; set; }
        //public DbSet<Role> Roles { get; set; }
    }
}
