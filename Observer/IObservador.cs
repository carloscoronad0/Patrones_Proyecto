using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Observer
{
    abstract class IObservador
    {
        public string Nombre { get; set; }
        public IObservador(string n)
        {
            Nombre = n;
           
        }
        public abstract void actualizar(Noticia n);

    }
}
