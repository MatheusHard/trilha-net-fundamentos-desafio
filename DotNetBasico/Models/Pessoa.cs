using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome 
        {
            get
            {
                return _nome.ToUpper();
            }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("NOme não pode ser vazio");
                }
                _nome = value;
            } 
        }
        public int Idade { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome da Pessoa é: {_nome}, tem {Idade} anos de Idade");
        }
    }
}
