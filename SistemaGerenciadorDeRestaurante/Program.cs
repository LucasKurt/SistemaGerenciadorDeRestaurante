using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGerenciadorDeRestaurante.Entidades;

namespace SistemaGerenciadorDeRestaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesa mesa1 = new Mesa(1, "mesa 1");
            Mesa mesa2 = new Mesa(2, "mesa 2");
            Mesa mesa3 = new Mesa(3, "mesa 3");

            Garcon garcon1 = new Garcon(1, "Lucas");
            Garcon garcon2 = new Garcon(2, "Paulo");
            Garcon garcon3 = new Garcon(3, "Marcos");

            Prato prato1 = new Prato(1, "Filet de Frango", 20.00, "Arroz, feijão, filet de frango e salada");
            Prato prato2 = new Prato(2, "Bife", 22.00, "Arroz, feijão, bife e salada");
            Prato prato3 = new Prato(3, "Salmão", 30.00, "Arroz, feijão, salmão e salada");
            Prato prato4 = new Prato(4, "Macarrão", 18.00, "macarão com molho de tomate e coxa de frango assada");
            Prato prato5 = new Prato(5, "Picadinho", 20.00, "Arroz, feijão, picadinho e salada");
            Prato prato6 = new Prato(6, "Costela", 25.00, "Arroz, feijão, costela e salada");

            Pedido pedido1 = new Pedido(1, mesa1, garcon1);
            pedido1.Pratos.AddRange(new List<Prato>
            {
                prato1, prato2
            });

            Pedido pedido2 = new Pedido(2, mesa2, garcon2);
            pedido2.Pratos.AddRange(new List<Prato>
            {
                prato3, prato4
            });

            Pedido pedido3 = new Pedido(3, mesa3, garcon3);
            pedido3.Pratos.AddRange(new List<Prato>
            {
                prato5, prato6
            });

            Console.WriteLine(pedido1.ImprimirPedido() + '\n');
            Console.WriteLine(pedido2.ImprimirPedido() + '\n');
            Console.WriteLine(pedido3.ImprimirPedido(true));
            Console.ReadLine();
        }
    }
}
