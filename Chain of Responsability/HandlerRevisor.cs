using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Chain_of_Responsability
{
    class HandlerRevisor : IHandler
    {
        IHandler sucesor = null;
        public HandlerRevisor(IHandler ss)
        {
            sucesor = ss;
        }
        public bool aprobarNoticia(int palabras)
        {
            bool respuesta;
            if (palabras < 500)
            {
                Console.WriteLine(" Revisor lo aprueba");

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
