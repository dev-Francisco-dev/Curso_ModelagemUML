
namespace Models
{
    public class Estado
    {
        private int Id { get; set; }
        private string Nome { get; set; } = null!;
        private ICollection<Cidade> cidade { get; set; } = null!;
        public Estado() { }

        public Estado(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override bool Equals(object? obj)
        {
            return obj is Estado estado &&
                   Id == estado.Id &&
                   Nome == estado.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome);
        }
    }
}
