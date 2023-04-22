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

        public PagamentoCartao(int id, int numeroDePArcelas, EstadoPagamento estadoPagamento, Pedido pedido, Cliente cliente, Endereco endereco) : base(id, estadoPagamento, pedido, cliente, endereco)
        {
            NumeroDeParcela = numeroDePArcelas;
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
