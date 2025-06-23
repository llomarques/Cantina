using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina
{
    internal class Estoque
    {
        public Produto produto { get; set; }
        public int Quantidade { get; set; }

        public void AdicionarQuantidade ( int quantidade)
        {
            if (quantidade <= 0)
            {
                throw new ArgumentException("Produto inválido ou quantidade deve ser maior que zero.");
            }
           
            Quantidade += quantidade;
            
        }

        public void RemoverQuantidade(int quantidade)
        {
            if (quantidade <= Quantidade && quantidade > 0 )
            {
                Quantidade -= quantidade;
            }

            

        }

        public override string ToString()
        {
            return $"{produto.Descricao} - Quantidade: {Quantidade}";
        }
    }
}
