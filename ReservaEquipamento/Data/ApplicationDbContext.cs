using Microsoft.EntityFrameworkCore;
using ReservaEquipamento.Models;

namespace ReservaEquipamento.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ReservaModel> Reservas { get; set; }

    }
}
