using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoCulebrita
{
    internal class RunArrayList
    {
        public static void CorrerArray()
        {
            string respuesta = "s";

            while (respuesta.Equals("s"))
            {
                var punteo = 0;
                var velocidad = 100; //modificar estos valores y ver qué pasa ******Si se aumenta el valor la culebrita se moverá más lento
                var posiciónComida = Point.Empty;
                var tamañoPantalla = new Size(60, 20);
                var culebrita = new ColaArrayList();
                var longitudCulebra = 3; //modificar estos valores y ver qué pasa ******Si se modifica este valor el tamaño inicial de la culebra será diferente
                var posiciónActual = new Point(0, 9); //modificar estos valores y ver qué pasa *****´Cmabiará el lugar donde aparece la culebrita cuando empieza el juego
                culebrita.insetar(posiciónActual);
                var dirección = CArrayList.Direction.Derecha; //modificar estos valores y ver qué pasa ******Cambiará la dirección a la que se mueve la culebra al inicio del juego

                CArrayList.DibujaPantalla(tamañoPantalla);
                CArrayList.MuestraPunteo(punteo);

                while (CArrayList.MoverLaCulebrita(culebrita, posiciónActual, longitudCulebra, tamañoPantalla))
                {
                    Thread.Sleep(velocidad);
                    dirección = CArrayList.ObtieneDireccion(dirección);
                    posiciónActual = CArrayList.ObtieneSiguienteDireccion(dirección, posiciónActual);

                    if (posiciónActual.Equals(posiciónComida))
                    {
                        Console.Beep(); //******Aquí emite el beep que pide el inge
                        posiciónComida = Point.Empty;
                        longitudCulebra++; //modificar estos valores y ver qué pasa ******La culebra crecerá mas cada vez que coma
                        punteo += 10; //modificar estos valores y ver qué pasa ****Los puntos aumentaran más o menos cada vez que coma (Dependiendo del valor que se coloque)
                        CArrayList.MuestraPunteo(punteo);
                        velocidad -= 3;//Aquí se aumenta la velocidad como pide el inge
                    }

                    if (posiciónComida == Point.Empty) //entender qué hace esta linea
                    {
                        posiciónComida = CArrayList.MostrarComida(tamañoPantalla, culebrita);
                    }
                }

                Console.ResetColor();
                Console.SetCursorPosition(tamañoPantalla.Width / 2 - 4, tamañoPantalla.Height / 2);
                Console.Write("End Game!!\n");
                Thread.Sleep(2000);
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("New Game? s/n");
                respuesta = Console.ReadLine();

            }
        }
    }
}
