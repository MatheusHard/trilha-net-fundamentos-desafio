using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Models
{
    public sealed class Corrente : Conta
    {
        public sealed override void Creditar(decimal valor)
        {
            saldo += valor;   
        }
    }
}
