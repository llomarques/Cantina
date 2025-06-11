using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina
{
    internal class PersistenciaProduto
    {
        public static List<Produto> ProdutosEstoque = new List<Produto>() {
             new Produto("Coxinha", 5.00, false),
             new Produto("Pastel de Carne", 6.00, true),
             new Produto("Pastel de Queijo", 5.50, true),
             new Produto("Refrigerante Lata", 4.50, false),
             new Produto("Suco Natural (300ml)", 3.00, false),
             new Produto("Pão de Queijo", 3.50, false),
             new Produto("Hambúrguer Simples", 8.00, true),
             new Produto("Hambúrguer com Queijo", 9.00, true),
             new Produto("X-tudo", 12.00, true),
             new Produto("Água Mineral (500ml)", 2.50, false)

    };
        }
}                                                                         