using Microsoft.EntityFrameworkCore;
using Models;

namespace Modelagem.API.DataBase
{
    public class ServicesDbContext : DbContext
    {
        public ServicesDbContext(DbContextOptions<ServicesDbContext> options) : base(options) 
        {

        }

        public DbSet<Pedido> pedidos { get; set; }
    }
}
