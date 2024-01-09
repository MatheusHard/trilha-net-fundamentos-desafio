using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Models
{
    public class ClasseGenerica<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void Add(T obj)
        {
            if(contador+1 < array.Length)
            { 
            array[contador] = obj;
            }
            contador++;
        }
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
