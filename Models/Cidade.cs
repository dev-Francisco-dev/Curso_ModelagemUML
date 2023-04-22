
namespace Models
{
    public  class Cidade
    {
        private int Id { get; set; } 
        private int EstadoId { get; set; }
        private int EnderecoId { get; set; }
        private string Nome { get; set; } = null!;
        private Estado Estado = null!;

        public Cidade() { }

        public Cidade(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override bool Equals(object? obj)
        {
            return obj is Cidade cidade &&
                   Id == cidade.Id &&
                   EstadoId == cidade.EstadoId &&
                   EnderecoId == cidade.EnderecoId &&   
                   Nome == cidade.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id,EstadoId,EnderecoId, Nome);
        }
    }
}
