namespace Sabadoanimado.Models
{
    public class concessionaria
    {
        public int id { get; set; }

        public string marca { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }

        public float preco { get; set; }
        public int estoque { get; set; }
    }
}
