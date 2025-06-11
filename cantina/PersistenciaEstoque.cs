using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina
{
    internal class PersistenciaEstoque
    {
        public static List<Estoque> ListaEstoque = new List<Estoque>();

        public static void IniciarEstoque()
        {
            foreach (var produto in PersistenciaProduto.ProdutosEstoque)
            {
                Estoque estoque = new Estoque
                {
                    produto = produto,
                    Quantidade = 0 // Inicializa a quantidade como zero
                };
                ListaEstoque.Add(estoque);
            }
        }

    }
}
