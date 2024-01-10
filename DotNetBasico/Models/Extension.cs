using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Models
{
    public static class Extension
    {
        public static bool EhPar(this int value)
        {
            return value % 2 == 0;
        }

    }
}
