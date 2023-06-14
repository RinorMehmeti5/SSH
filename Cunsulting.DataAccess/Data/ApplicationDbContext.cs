using Microsoft.EntityFrameworkCore;
using Consult.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Consult.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Lendet> Lendet { get; set; }
        public DbSet<Konsultimet> Konsultimet { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Departament> Departamentet{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Lendet>().HasData(
                new Lendet { Lid = 100, Lname = "Algjebra lineare dhe kalkulus 1", Ldescription = "Kjo lende ka 7 kredi" },
                new Lendet { Lid = 101, Lname = "Fizika 1", Ldescription = "Kjo lende ka 6 kredi" },
                new Lendet { Lid = 103, Lname = "Bazat e inxhinierise elektrike 1", Ldescription = "Kjo lende ka 7 kredi" }
                );

            modelBuilder.Entity<Departament>().HasData(
            new Departament { Id = 10, Name = "Inxhinieri Kompjuterike dhe Softuerike" },
            new Departament { Id = 11, Name = "Elektronikë, Automatikë dhe Robotikë" },
            new Departament { Id = 12, Name = "Teknologjite e Informacionit dhe Komunikimit"},
            new Departament { Id = 13, Name = "Elektroenergjetike" }
            );
            modelBuilder.Entity<Konsultimet>().HasData(
               new Konsultimet
               {
                   Kid = 1,
                   Ktitle = "Konsultimi 1",
                   KkohaEFillimit = new DateTime(2023, 06, 08, 16, 00, 00),
                   KkohaEMbarimit = new DateTime(2023, 06, 08, 16, 30, 00),
                   Kpershkrimi = "Konsultime nga lenda e Fizikës",
                   KLid = 100
               },
               new Konsultimet
               {
                   Kid = 2,
                   Ktitle = "Konsultimi 2",
                   KkohaEFillimit = new DateTime(2023, 06, 08, 17, 00, 00),
                   KkohaEMbarimit = new DateTime(2023, 06, 08, 17, 30, 00),
                   Kpershkrimi = "Konsultime nga lenda e Siguris",
                   KLid = 100
               },
               new Konsultimet
               {
                   Kid = 3,
                   Ktitle = "Konsultimi 3",
                   KkohaEFillimit = new DateTime(2023, 06, 09, 16, 00, 00),
                   KkohaEMbarimit = new DateTime(2023, 06, 09, 16, 30, 00),
                   Kpershkrimi = "Konsultime nga lenda e Matematikes",
                   KLid = 103
               },
               new Konsultimet
               {
                   Kid = 4,
                   Ktitle = "Konsultimi 4",
                   KkohaEFillimit = new DateTime(2023, 06, 10, 16, 00, 00),
                   KkohaEMbarimit = new DateTime(2023, 06, 10, 16, 30, 00),
                   Kpershkrimi = "Konsultime nga lenda e Sinjaleve",
                   KLid = 103
               }
               );
        }
    }
}
