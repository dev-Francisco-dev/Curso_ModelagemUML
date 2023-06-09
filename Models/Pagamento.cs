﻿using Models.Enum;

namespace Models
{    public class Pagamento
    {
        private int Id { get; set; }
        private int PedidoId { get; set; }
        private EstadoPagamento EstadoPagamento { get; set; } = null!;
        private Pedido? Pedido { get; set; }
        private Cliente Cliente { get; set; }      

        public Pagamento(){
        }

        public Pagamento(int id,int pedidoId, EstadoPagamento estadoPagamento, Pedido pedido, Cliente cliente)
        {
            Id = id;
            PedidoId= pedidoId;
            EstadoPagamento = estadoPagamento;
            Pedido = pedido;
            Cliente = cliente;            
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
