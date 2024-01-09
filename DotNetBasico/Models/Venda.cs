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
        public string Descricao { get; set; }

        public Venda(int id, string descricao, decimal preco)
        {
            Id = id;
            Preco = preco;
            Descricao = descricao;
        }
    }
}
