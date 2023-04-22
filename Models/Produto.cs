namespace Models
{
    internal class Produto
    {
        private int Id { get; set; }
        private string?  Nome { get; set; }
        private double?  Preco { get; set; }

        private ICollection<Categoria>? Categorias { get;set; }

        public Produto(){}
        public Produto(int id, string nome, double preco)
        {
            this.Id= id;
            this.Nome= nome;
            this.Preco = preco;
        }

        public override bool Equals(object? obj)
        {
            return obj is Produto produto &&
                   Id == produto.Id &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, Preco);
        }
    }
}
