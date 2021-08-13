using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento2
{
    class Pedido

    {

      
        public int Hamburguer { get; set; }

        public double preco { get; set; }


        public  double ValorTotalPedido()
            {
            return Hamburguer * preco;
            }
        public void AdicionarProdutos(int qte)
        {
            Hamburguer += qte;
        }
        public override string ToString()
        {
            return

                 " Valor total pedido "
                 
                + ValorTotalPedido().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
