using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int Qtd, string erro) LerArquivo(string caminho) 
        {
			try {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count(), "");
			}
			catch (Exception e) {

                return (false, new string[0], 0, e.Message);

            }
        }
    }
}
