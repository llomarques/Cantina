using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina
{
    public static class PersistenciaPedido
    {
        public static List<Pedido> Pedidos = new List<Pedido>();
    }

    public class Pedido
    {
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoConsumo { get; set; }
    }
}
