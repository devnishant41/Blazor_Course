using App_01_ServerManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace App_01_ServerManagement.Data
{
    public class ServerManagementContext : DbContext
    {
        public ServerManagementContext(DbContextOptions<ServerManagementContext> options) : base(options)
        {

        }

        public DbSet<Server> Servers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Server>().HasData(
                 new Server { ServerId = 1, Name = "SRV-NYC-01", City = "New York" },
            new Server { ServerId = 2, Name = "SRV-LAX-01", City = "London" },
            new Server { ServerId = 3, Name = "SRV-CHI-01", City = "Chicago" },
            new Server { ServerId = 4, Name = "SRV-LON-01", City = "London" },
            new Server { ServerId = 5, Name = "SRV-TKY-01", City = "Tokyo" },
            new Server { ServerId = 6, Name = "SRV-SYD-01", City = "London" },
            new Server { ServerId = 7, Name = "SRV-SIN-01", City = "Chicago" },
            new Server { ServerId = 8, Name = "SRV-FRA-01", City = "Chicago" },
            new Server { ServerId = 9, Name = "SRV-TOR-01", City = "Chicago" },
            new Server { ServerId = 10, Name = "SRV-AMS-01", City = "London" }
                );
        }
    }
}
