using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoCulebrita
{
    internal class ColaListaEnlazada
    {
        public Nodo principio;
        public Nodo final;
        public int c;

        public ColaListaEnlazada()
        {
            principio = null;
            final = null;
        }

        public Object frenteCola()
        {
            if (colaVacia())
            {

                throw new Exception("Cola vacía");
            }
            else
            {
                return principio.elemento;
            }
        }
        public bool colaVacia()
        {
            return principio == null;
        }

        public void insetar(Point dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (colaVacia())
            {
                principio = nuevo;
            }
            else
            {
                final.siguiente = nuevo;
            }
            final = nuevo;
            c++;
        }
        public Object quitar()
        {
            Object temporal;
            if (colaVacia())
            {

                throw new Exception("Cola vacía");
            }
            else
            {
                temporal = principio.elemento;
                principio = principio.siguiente;
                c--;
            }
            return temporal;
        }

        public Object last()
        {
            if (colaVacia())
            {
                throw new Exception("Cola vacía");

            }
            else
            {
                return final.elemento;
            }
        }
        public int numero()
        {
            int n;
            Nodo temporal = principio;
            if (!colaVacia())
            {
                n = 1;
                while (temporal != final)
                {
                    temporal = temporal.siguiente;
                    n++;
                }
            }
            else
            {
                n = 0;
            }
            return n;
        }
    }
}
