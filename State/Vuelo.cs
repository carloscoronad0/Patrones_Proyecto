using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.State
{
    class Vuelo
    {
        public int hora_salida { get; set; }
        public int numero_Vuelo { get; set; }

        I_Estado estado_Actual;

        I_Estado en_Hora;
        I_Estado retrasado;

        public Vuelo()
        {
            hora_salida = Random_Value.random_Value(1, 24);
            numero_Vuelo = Random_Value.random_Value(10000, 99999);

            en_Hora = new En_Hora();
            retrasado = new Restrasado();

            estado_Actual = en_Hora;
        }

        public void vuelo_En_Retraso()
        {
            estado_Actual = retrasado;
        }

        public void vuelo_En_Hora()
        {
            estado_Actual = en_Hora;
        }

        public void get_Estado()
        {
            estado_Actual.print_Estado(this);
        }
    }
}
