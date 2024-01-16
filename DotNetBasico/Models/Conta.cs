using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal saldo);

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo: "+saldo.ToString());

        }
    }
}
