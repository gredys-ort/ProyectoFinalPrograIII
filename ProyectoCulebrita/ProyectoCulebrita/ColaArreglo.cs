using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoCulebrita
{
    internal class ColaArreglo
    {
        protected int fin;
        private static int tamaño = 15000;
        protected int frente;
        protected Object[] lista;
        public int c;

        public ColaArreglo()
        {
            frente = 0;
            fin = -1;
            lista = new Object[tamaño];
        }

        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == tamaño - 1;
        }
        public void insetar(Point elemento)
        {
            if (colaLlena())
            {

                throw new Exception("Overflow en la cola");
            }
            else
            {
                c++;
                lista[++fin] = elemento;
            }
        }
        public Object quitar()
        {
            if (colaVacia())
            {
                throw new Exception("Cola vacía");
            }
            else
            {
                c--;
                return lista[frente++];
            }
        }

        public Object last()
        {
            return lista[fin];
        }

        public int numero()
        {
            return c;
        }
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        public Object frenteCola()
        {
            if (colaVacia())
            {

                throw new Exception("Cola vacía");
            }
            else
            {
                return lista[frente++];
            }
        }
    }
}
