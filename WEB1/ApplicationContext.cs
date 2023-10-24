using Microsoft.EntityFrameworkCore;
using WEB1.Models;

namespace WEB1
{

    public class ApplicationContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; } = null!;
        public DbSet<Worker> Workers { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>().HasData(
                    new Clients { FirstName = "Denys", MiddleName = "Serhiyovych", LastName = "Petrushchenko", PhoneNumber = "0971565481" },
                    new Clients { FirstName = "Kyrylo", MiddleName = "Volodymyrovich", LastName = "Kalushenko", PhoneNumber = "0668910456" },
                    new Clients { FirstName = "Mykola", MiddleName = "Victorych", LastName = "Pron", PhoneNumber = "0937842857" }
            );
            modelBuilder.Entity<Worker>().HasData(
                    new Worker { ID = Guid.NewGuid().ToString(), FirstName = "Mykhailo", MiddleName = "Andriiovych", LastName = "Hlevatsky", Worker_Phone_Number = "0989381314" }
                    //new Clients { FirstName = "Kyrylo", MiddleName = "Volodymyrovich", LastName = "Kalushenko", PhoneNumber = "0668910456" },
                    //new Clients { FirstName = "Mykola", MiddleName = "Victorych", LastName = "Pron", PhoneNumber = "0937842857" }
            );
        }
    }

}
