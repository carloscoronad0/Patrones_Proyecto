using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.State
{
    class En_Hora : I_Estado
    {
        public void print_Estado(Vuelo v)
        {
            Console.WriteLine("El vuelo: {0} se encuentra en hora, hora de salida: {1}", v.numero_Vuelo, v.hora_salida);
        }
    }
}
