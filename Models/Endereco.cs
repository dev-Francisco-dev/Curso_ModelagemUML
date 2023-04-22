
namespace Models
{
    public class Endereco
    {
        private int Id { get; set; }
        private int ClientId { get; set; }
        private string Logradouro { get; set; } = null!;
        private string? Numero{ get; set; }
        private string? Complemento { get; set; }
        private string Bairro { get; set; } = null!;
        private string Cep { get; set; } = null!;
        private Cidade Cidade { get; set; } = null!;
        private Cliente Cliente { get; set; } = null!;

        public Endereco()
        {

        }

        public Endereco(int id,int clientId, string logradouro, string numero, string complemento, string bairro, string cep, Cidade cidade, Cliente cliente)
        {
            Id = id;
            ClientId = clientId;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Cliente= cliente;
            Cidade = cidade;
        }

        public override bool Equals(object? obj)
        {
            return obj is Endereco endereco &&
                   Id == endereco.Id &&
                   ClientId == endereco.ClientId &&
                   Logradouro == endereco.Logradouro &&
                   Numero == endereco.Numero &&
                   Complemento == endereco.Complemento &&
                   Bairro == endereco.Bairro &&
                   Cep == endereco.Cep &&
                   EqualityComparer<Cliente>.Default.Equals(Cliente, endereco.Cliente);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, ClientId, Logradouro, Numero, Complemento, Bairro, Cep, Cidade);
        }
    }

}
