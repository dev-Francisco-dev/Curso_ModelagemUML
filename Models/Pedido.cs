namespace Models
{
    public class Pedido
    {
        private int Id;
        private int ClienteId;
        private DateTime Instant;
        private Pagamento Pagamento;
        private Cliente Cliente;

        public Pedido(int id,int clienteId, DateTime instant, Pagamento pagamento, Cliente cliente)
        {
            Id = id;
            ClienteId = clienteId;
            Instant = instant;
            Pagamento = pagamento;
            Cliente = cliente;
        }

        public override bool Equals(object? obj)
        {
            return obj is Pedido pedido &&
                   Id == pedido.Id &&
                   ClienteId == pedido.ClienteId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, ClienteId);
        }
    }
}
