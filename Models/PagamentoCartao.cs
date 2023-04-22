using Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PagamentoCartao : Pagamento
    {
        private int NumeroDeParcela { get; set; }

        public PagamentoCartao()
        {

        }
        public PagamentoCartao(int id, int pedidoId, EstadoPagamento estadoPagamento, Pedido pedido, Cliente cliente) : base(id, pedidoId, estadoPagamento, pedido, cliente)
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is PagamentoCartao cartao &&
                   base.Equals(obj) &&
                   NumeroDeParcela == cartao.NumeroDeParcela;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), NumeroDeParcela);
        }
    }


}
