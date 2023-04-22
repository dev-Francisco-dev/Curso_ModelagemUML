
namespace Models
{
    public class Telefone
    {
        private int Id { get; set; }
        private int ClienteId { get; set; }
        private string Numero { get; set; } = null!;
        private Cliente Cliente { get; set; }


        public Telefone(){}

        public Telefone(int id,int clientId, string numero)
        {
            Id = id;
            ClienteId = clientId;
            Numero = numero;
        }

        public override bool Equals(object? obj)
        {
            return obj is Telefone telefone &&
                   Id == telefone.Id &&
                   Numero == telefone.Numero &&
                   ClienteId == telefone.ClienteId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Numero, ClienteId);
        }
    }

    
}
