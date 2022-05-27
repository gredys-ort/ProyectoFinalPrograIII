using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCulebrita
{
    internal class Nodo
    {
        public Object elemento;
        public Nodo siguiente;

        public Nodo(Object elemento)
        {
            this.elemento = elemento;
            siguiente = null;
        }
    }
}
