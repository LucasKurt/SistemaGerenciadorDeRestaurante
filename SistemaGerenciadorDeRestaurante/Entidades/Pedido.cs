using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorDeRestaurante.Entidades
{
    internal class Pedido
    {
        public int Id { get; set; }
        public Mesa Mesa { get; set; }
        public Garcon Garcon { get; set; }
        public List<Prato> Pratos { get; } = new List<Prato>();

        public Pedido(int id, Mesa mesa, Garcon garcon)
        {
            Id = id;
            Mesa = mesa;
            Garcon = garcon;
        }

        private double CalcularTotal()
        {
            double total = 0;
            foreach (var prato in Pratos)
            {
                total += prato.Preco;
            }
            return total;
        }

        public string ImprimirPedido(bool gorjeta = false)
        {
            string pedido = $"Pedido n° {Id} - Garçon: {Garcon.Nome} - {Mesa.Nome}\nPratos:\n";
            string pratos = "";
            foreach (var prato in Pratos)
            {
                pratos += $"     - {prato.Nome,-20} R$ {prato.Preco:N2}\n";
            }
            pratos += $"\n     Total {CalcularTotal(),25:N2}";
            string totalComGorjeta = "";
            if (gorjeta)
            {
                totalComGorjeta = $"\n     Gorjeta {CalcularTotal() * 0.1,23:N2}";
                totalComGorjeta += $"\n     Total com Gorjeta {CalcularTotal() * 1.1,13:N2}";
            }
            return pedido + pratos + totalComGorjeta;
        }
    }
}
