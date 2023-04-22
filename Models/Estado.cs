
namespace Models
{
    internal class Estado
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private ICollection<Cidade> cidade { get; set; }

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
