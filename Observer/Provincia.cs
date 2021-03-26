using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Observer
{
    class Provincia : IObservador
    {
        public Provincia(string n):base(n)
        {

        }
        public override void actualizar(Noticia z)
        {
            Console.WriteLine("Se informa a la provincia de " + this.Nombre + " la siguiente Noticia" + z.Titulo) ;

        }
    }
}
