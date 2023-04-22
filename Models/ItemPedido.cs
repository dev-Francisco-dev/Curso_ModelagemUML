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
    }
}
