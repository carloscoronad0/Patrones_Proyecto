using Patrones_Proyecto.State;
using Patrones_Proyecto.Flyweigth;
using System;

namespace Patrones_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Aeropuerto a = new Aeropuerto();
            Noticias n = new Noticias();

            string s = "s";
            int eleccion;

            while (s == "s")
            {
                Console.WriteLine("1.- State \n" +
                    "2.- Noticias \n" +
                    "5.- Terminar ejecucion");

                eleccion = Convert.ToInt32(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        int elec_2;
                        while(eleccion == 1)
                        {
                            Console.WriteLine("Que desea hacer: \n" +
                                "1.- Agregar Vuelo \n" +
                                "2.- Calcular la Lluvia \n " +
                                "3.- Calcular la Neblina \n " +
                                "4.- Recorrer Vuelos \n" +
                                "5.- Salir");
                            elec_2 = Convert.ToInt32(Console.ReadLine());

                            switch (elec_2)
                            {
                                case 1:
                                    a.crear_Vuelo();
                                    break;
                                case 2:
                                    a.calcular_Valor_Lluvia();
                                    break;
                                case 3:
                                    a.calcular_Valor_Neblina();
                                    break;
                                case 4:
                                    a.recorrer_Vuelos();
                                    break;
                                case 5:
                                    eleccion = elec_2;
                                    break;
                                default:
                                    Console.WriteLine("Ingrese un valor valido");
                                    break;
                            }
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        int elec_3;
                        while (eleccion == 1)
                        {
                            Console.WriteLine("Que desea hacer: \n" +
                                "1.- Agregar Noticia \n" +
                                "2.- Recorrer Noticias \n " +
                                "3.- Salir");
                            elec_3 = Convert.ToInt32(Console.ReadLine());

                            switch (elec_3)
                            {
                                case 1:
                                    Console.Clear();
                                    n.agregar_Noticia();
                                    break;
                                case 2:
                                    n.recorrer_Noticias();
                                    break;
                                case 3:
                                    eleccion = elec_3;
                                    break;
                                default:
                                    Console.WriteLine("Ingrese un valor valido");
                                    break;
                            }
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        s = eleccion.ToString();
                        break;

                    default:
                        Console.WriteLine("Porfavor seleccione un valor valido");
                        break;
                }
            }
        }
    }
}
