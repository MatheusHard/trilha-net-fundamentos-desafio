using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }

        [JsonProperty("Descricao")]
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        public Venda(int id, string descricao, decimal preco, DateTime data)
        {
            Id = id;
            Preco = preco;
            Descricao = descricao;
            DataCadastro = data;
        }
    }
}
