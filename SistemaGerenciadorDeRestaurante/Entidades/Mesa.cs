namespace SistemaGerenciadorDeRestaurante
{
    internal class Mesa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Mesa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}