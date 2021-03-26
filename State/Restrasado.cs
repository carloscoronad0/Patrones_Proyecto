using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.State
{
    class Restrasado : I_Estado
    {
        public void print_Estado(Vuelo v)
        {
            Console.WriteLine("El vuelo: {0} se encuentra retrasado, posible hora de salida: {1}", v.numero_Vuelo, (v.hora_salida + 1));
        }
    }
}
