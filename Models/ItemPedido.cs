using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemPedido
    {
        public int Quantidade { get; set; }
        public int ProdutoId { get; set;}
        public int PedidoId { get; set;}
        public double Desconto { get; set;}
        public double Preco { get; set;}

        public ItemPedido()
        {

        }
        public override bool Equals(object? obj)
        {
            return obj is ItemPedido pedido &&
                   Quantidade == pedido.Quantidade &&
                   ProdutoId == pedido.ProdutoId &&
                   PedidoId == pedido.PedidoId &&
                   Desconto == pedido.Desconto &&
                   Preco == pedido.Preco;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Quantidade, ProdutoId, PedidoId, Desconto, Preco);
        }
    }
}
