using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Observer
{
    class SistemaCentralRural
    {
        private List<IObservador> provincias;
        private List<Noticia> noticias;
        public SistemaCentralRural()
        {
            provincias = new List<IObservador>();
            noticias = new List<Noticia>();

        }
        public void nuevaNoticia(Noticia n )
        {
            Console.WriteLine("Se agrego una nueva noticia " + n.Titulo);
            noticias.Add(n);
            this.notificar(n);
        }

        public void añadirProvicnias(IObservador observador)
        {
            //si no está en la lista, lo adiciono
            if (!provincias.Contains(observador))
                provincias.Add(observador);
            else
                Console.WriteLine("La provincia " + observador.Nombre + " ya está suscrito");
        }
        public void eliminarProvicnia(IObservador observador)
        {
            //verificamos si está y lo eliminamos si es true
            if (provincias.Contains(observador))
                provincias.Remove(observador);
            else
                Console.WriteLine("La provincia " + observador.Nombre + " no es suscriptor de " );

        }
        public void notificar(Noticia n)
        {

            foreach (IObservador o in provincias)
            {
                //llamo al método actualizar de todos los elementos de la lista y paso al sujeto actual como parámetro
                o.actualizar(n);
            }

            Console.WriteLine("--------------------\n");
        }
    }
}
