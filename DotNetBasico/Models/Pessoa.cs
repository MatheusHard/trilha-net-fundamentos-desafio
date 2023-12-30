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
        private int _idade;

        public  Pessoa() { }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }


        public string Nome 
        {
            get => _nome.ToUpper();
            
            set  
            {
                if (value == "")
                {
                    throw new ArgumentException("NOme não pode ser vazio");
                }
                _nome = value;
            } 
        }
        public int Idade {
            get => _idade;

            set 
            {
                if (value < 0) {
                    throw new ArgumentException("Idade deve ser maior que zero");
            }
                _idade = value;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome da Pessoa é: {_nome}, tem {_idade} anos de Idade");
        }
    }
}
