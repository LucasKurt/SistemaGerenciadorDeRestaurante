namespace SistemaGerenciadorDeRestaurante.Entidades
{
    internal class Prato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Prato(int id, string nome, double preco, string descricao = "Sem descrição")
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }
    }
}