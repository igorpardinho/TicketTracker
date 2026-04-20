using Microsoft.EntityFrameworkCore;
using TicketTracker.API.Models;

namespace TicketTracker.API.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
    }
}
