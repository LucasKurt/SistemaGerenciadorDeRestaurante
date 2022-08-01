using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorDeRestaurante.Entidades
{
    internal class Garcon
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Garcon(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
