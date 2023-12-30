using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public void Add(Pessoa pessoa) 
        {
            Alunos.Add(pessoa);
        }
        public int CountAlunosMatriculados()
        {
            return Alunos.Count;
        }
        public bool Remove(Pessoa pessoa) 
        {
            return Alunos.Remove(pessoa);
        }
        public void Listar() 
        {
            Console.WriteLine($"----- Curso de {Nome} ------");
            foreach (Pessoa item in Alunos)
            {
                Console.WriteLine(item.Nome);
            }
        }
    }
}
