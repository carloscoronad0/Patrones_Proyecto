using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Chain_of_Responsability
{
    class HandlerEditor : IHandler
    {
        private IHandler sucesor = null;
        public HandlerEditor(IHandler ss)
        {
            this.sucesor = ss;
        }
        public bool aprobarNoticia(int palabras)
        {
            bool respuesta;
            if (palabras < 300)
            {
                Console.WriteLine(" Edito lo aprueba");

                respuesta = true;
            }
            else
            {
                respuesta = sucesor.aprobarNoticia(palabras);
            }
            return respuesta;
        }
    }
}
