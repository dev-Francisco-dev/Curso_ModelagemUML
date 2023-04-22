using Models.Enum;

namespace Models
{    public class Pagamento
    {
        private int Id { get; set; }
        private int PedidoId { get; set; }
        private EstadoPagamento EstadoPagamento { get; set; }
        private Pedido? Pedido { get; set; }
        private Cliente Cliente { get; set; }
        private Endereco Endereco { get; set; }

        public Pagamento(){
        }

        public Pagamento(int id,int pedidoId, EstadoPagamento estadoPagamento, Pedido pedido, Cliente cliente, Endereco endereco)
        {
            Id = id;
            PedidoId= pedidoId;
            EstadoPagamento = estadoPagamento;
            Pedido = pedido;
            Cliente = cliente;
            Endereco = endereco;
        }

        public override bool Equals(object? obj)
        {
            return obj is Pagamento pagamento &&
                   Id == pagamento.Id &&
                   PedidoId == pagamento.PedidoId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, PedidoId);
        }
    }
}
