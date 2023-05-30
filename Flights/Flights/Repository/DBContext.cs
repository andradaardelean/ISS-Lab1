using Flights.Model;
using Microsoft.EntityFrameworkCore;

namespace Flights.Repository
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Flight> flights { get; set; }
        public DbSet<Ticket> tickets { get; set; }
        
        public DbSet<Request> requests { get; set; }
    }
}