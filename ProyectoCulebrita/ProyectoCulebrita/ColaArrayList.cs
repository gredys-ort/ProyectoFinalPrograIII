using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace ProyectoCulebrita
{
    internal class ColaArrayList
    {
        protected int fin;
        protected int frente;
        protected ArrayList lista;

        public ColaArrayList()
        {
            frente = 0;
            fin = -1;
            lista = new ArrayList();
        }

        public bool colaVacia()
        {
            return frente > fin;
        }

        public void insetar(Point elemento)
        {
            lista.Add(elemento);
            ++fin;
        }

        public Object quitar()
        {
            if (colaVacia())
            {
                throw new Exception("Cola vacía");
            }
            else
            {
                Object temporal = lista[frente];
                lista.RemoveAt(frente);
                fin--;
                return temporal;
            }
        }

        public Object last()
        {
            return lista[fin];
        }

        public int numero()
        {
            return lista.Count;
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
