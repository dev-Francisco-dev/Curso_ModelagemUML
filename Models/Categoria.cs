namespace Models
{
    public class Categoria
    {
        private int Id { get; set; }
        private string Nome { get; set; } = null!;
        ICollection<Produto>? Produtos { get; set; }

        public Categoria() { }

        public Categoria(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public override bool Equals(object? obj)
        {
            return obj is Categoria categoria &&
                   Id == categoria.Id &&
                   Nome == categoria.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome);
        }
    }
}