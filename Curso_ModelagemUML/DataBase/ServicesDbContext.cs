using Microsoft.EntityFrameworkCore;
using Models;

namespace Modelagem.API.DataBase
{
    public class ServicesDbContext : DbContext
    {
        public ServicesDbContext(DbContextOptions<ServicesDbContext> options) : base(options) {}
        
        public DbSet<Categoria> Pategorias { get; set; }
        public DbSet<Cidade> Pidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<PagamentoBoleto> PagamentosBoleto { get; set; }
        public DbSet<PagamentoCartao> PagamentosCartao { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
    }
}
