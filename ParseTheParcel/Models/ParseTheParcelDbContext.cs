using Microsoft.EntityFrameworkCore;
using ParseTheParcel.Models.ParseTheParcelModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ParseTheParcel.Models
{
    public class ParseTheParcelDbContext: DbContext
    {
        public DbSet<ParseTheParcelRule> parseTheParcelRules { get; set; }
        public ParseTheParcelDbContext(DbContextOptions<ParseTheParcelDbContext> options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
