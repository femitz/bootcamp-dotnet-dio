using System.Globalization;
using Newtonsoft.Json;

namespace OrientacaoObj.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime data)
        {
            
            Id = id;
            Produto = produto;
            Preco = preco;
            Data = data;
        }
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime Data { get; set; }
    }
}