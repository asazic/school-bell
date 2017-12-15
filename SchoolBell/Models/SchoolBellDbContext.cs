using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBell.Models
{
    public class SchoolBellDbContext : DbContext
    {
        public DbSet<Bell> Bells { get; set; }
        public DbSet<Scheduler> Schedulers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Bell>()
                .HasRequired(x => x.Scheduler)
                .WithMany(x=>x.Bells)
                .HasForeignKey(x => x.Scheduler_ID);
        }
    }
}
