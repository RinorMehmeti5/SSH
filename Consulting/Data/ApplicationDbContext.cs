using Consulting.Models;
using Microsoft.EntityFrameworkCore;

namespace Consulting.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
             
        }
        public DbSet<Lendet> Lendet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lendet>().HasData(
                new Lendet { Lid = 100, Lname = "Algjebra lineare dhe kalkulus 1", Ldescription = "Kjo lende ka 7 kredi" },
                new Lendet { Lid = 101, Lname = "Fizika 1", Ldescription = "Kjo lende ka 6 kredi" },
                new Lendet { Lid = 103, Lname = "Bazat e inxhinierise elektrike 1", Ldescription = "Kjo lende ka 7 kredi" }
                );

        }
    }
}
