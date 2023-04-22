
using Models.Enum;

namespace Models
{
    public class Cliente
    {
        private int Id { get; set; }
        private string Nome { get; set; } = null!;
        private string Email { get; set; } = null!;
        private string CpfouCnpj { get; set; } = null!;
        private ICollection<Pedido> Pedidos { get; set; } = null!;
        private TipoCliente? TipoCliente { get; set; }
        private ICollection<Telefone>? Telefones { get; set; }
        private ICollection<Endereco>? Enderecos { get; set;}

        public Cliente() { }

        public Cliente(int id, string nome, string email, string cpfouCnpj, TipoCliente tipoCliente)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CpfouCnpj = cpfouCnpj;
            TipoCliente = tipoCliente;
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente &&
                   Id == cliente.Id &&
                   Nome == cliente.Nome &&
                   Email == cliente.Email &&
                   CpfouCnpj == cliente.CpfouCnpj &&
                   TipoCliente == cliente.TipoCliente;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, Email, CpfouCnpj, TipoCliente);
        }
    }
}
