using System;

namespace Treinamento2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido p = new Pedido();

            p.preco = 8.00;

            string nome;
            

            Console.WriteLine("Quantos Hamburguers deseja?");

            p.Hamburguer = int.Parse(Console.ReadLine());


            Console.WriteLine("o total do seu pedido é " + p);

            Console.WriteLine("Deseja pedir mais hamuburguer?");
            Console.WriteLine("S / N");
            nome = Console.ReadLine();
            
            while (nome.ToUpper() != "N")
            {
                Console.WriteLine("Digite a quantidade de hamburguer a adicionar ao seu pedido");
                int qte = int.Parse(Console.ReadLine());//o que for digitado sera armazenado na variavel qte

                

                Console.WriteLine("Deseja pedir mais hamuburguer?");
                Console.WriteLine("S / N");
                p.AdicionarProdutos(qte);
                
                nome = Console.ReadLine();
                

               

            }

            Console.WriteLine("o total do seu pedido é " + p);
        }
    }
}
