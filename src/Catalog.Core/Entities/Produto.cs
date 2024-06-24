namespace Catalog.Core.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public byte[] Imagem { get; set; }
    }
}
