using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Chain_of_Responsability
{
    class HandlerDirector : IHandler
    {
        public HandlerDirector()
        {
        }
        public bool aprobarNoticia(int palabras)
        {
            bool respuesta;
            Console.WriteLine(" Director lo aprueba");

            respuesta = true;
            return respuesta;
        }
    }
}
