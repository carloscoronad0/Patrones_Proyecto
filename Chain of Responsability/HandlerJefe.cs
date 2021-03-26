using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Chain_of_Responsability
{
    class HandlerJefe : IHandler
    {
        private IHandler sucesor = null;
        public HandlerJefe(IHandler ss)
        {
            sucesor = ss;
        }
        

        public bool aprobarNoticia(int palabras)
        {
            bool respuesta;
            if (palabras < 1000)
            {
                Console.WriteLine(" Jefe lo aprueba");
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
