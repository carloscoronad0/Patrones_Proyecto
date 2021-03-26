using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.State
{
    class Aeropuerto
    {
        private List<Vuelo> Vuelos;

        public int lluvia { get; set; }
        public double neblina { get; set; }

        private int max_Lluvia = 30;
        private double max_Neblina = 3.5;

        public Aeropuerto ()
        { 
            Vuelos = new List<Vuelo>();
            calcular_Valor_Lluvia();
            calcular_Valor_Neblina();
        }

        public void crear_Vuelo()
        {
            Vuelo v = new Vuelo();
            Vuelos.Add(v);
            Console.WriteLine("Vuelo: " + v.numero_Vuelo + " agregado");
        }

        public void calcular_Valor_Lluvia()
        {
            if ((Random_Value.random_Value(1, 100) % 2) == 0)
                lluvia = 0;
            else
                lluvia = Random_Value.random_Value(1, 50);

            Console.WriteLine("Valor de Lluvia: " + lluvia);

            actualizar_Vuelos(lluvia >= max_Lluvia);
        }

        public void calcular_Valor_Neblina()
        {
            if ((Random_Value.random_Value(1, 100) % 2) == 0)
                neblina = 0;
            else
                neblina = (Random_Value.random_Value(1, 50)) / 10;

            Console.WriteLine("Valor de Neblina: " + neblina);

            actualizar_Vuelos(neblina >= max_Neblina);
        }

        private void actualizar_Vuelos(bool es_retraso)
        {
            foreach(Vuelo v in Vuelos)
            {
                if (es_retraso)
                    v.vuelo_En_Retraso();
                else
                    v.vuelo_En_Hora();

                v.get_Estado();
            }
        }

        public void recorrer_Vuelos()
        {
            foreach(Vuelo v in Vuelos)
            {
                v.get_Estado();
            }
        }
    }
}
