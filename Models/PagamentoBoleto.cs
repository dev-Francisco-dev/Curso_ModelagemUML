using Models.Enum;

namespace Models
{
    public class PagamentoBoleto : Pagamento
    {        
        private DateTime DataVencimento { get; set; }
        private DateTime DataPagamento { get; set; }

        public PagamentoBoleto(){            
        }

        public PagamentoBoleto(int id, int pedidoId,DateTime dataVencimento, DateTime dataPagamento, EstadoPagamento estadoPagamento, Pedido pedido, Cliente cliente, Endereco endereco) : base(id, pedidoId, estadoPagamento, pedido, cliente, endereco)
        {            
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
        }
        public override bool Equals(object? obj)
        {
            return obj is PagamentoBoleto boleto &&
                   base.Equals(obj) &&                   
                   DataVencimento == boleto.DataVencimento &&
                   DataPagamento == boleto.DataPagamento;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), DataVencimento, DataPagamento);
        }
    }     
}
