using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Flyweigth
{
    class Noticias
    {
        private Flyweight_Factory Nacional;
        private Flyweight_Factory Local;
        private Flyweight_Factory Deporte;
        private Flyweight_Factory Cultura;
        private Flyweight_Factory Salud;

        public Noticias()
        {
            Nacional = new Flyweight_Factory();
            Local = new Flyweight_Factory();
            Deporte = new Flyweight_Factory();
            Cultura = new Flyweight_Factory();
            Salud = new Flyweight_Factory();
        }

        public void agregar_Noticia()
        {
            Console.WriteLine("Porfavor ingrese el titulo de la noticia: ");
            string titulo = Console.ReadLine();

            Noticia n = new Noticia(titulo);
            n.actualizar_Aprobacion(verificar_Aprobacion());

            string s = "s";
            int eleccion;

            while(s == "s")
            {
                Console.WriteLine("Seleccione la categoria a la que desea agregar la noticia\n " +
                    "1.- Nacional \n " +
                    "2.- Local \n " +
                    "3.- Deporte \n " +
                    "4.- Cultura \n " +
                    "5.- Salud \n " +
                    "6.- Si ya no desea escoger mas categorias");

                eleccion = Convert.ToInt32(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Nacional.agregar_Noticia(n);
                        break;
                    case 2:
                        Local.agregar_Noticia(n);
                        break;
                    case 3:
                        Deporte.agregar_Noticia(n);
                        break;
                    case 4:
                        Cultura.agregar_Noticia(n);
                        break;
                    case 5:
                        Salud.agregar_Noticia(n);
                        break;
                    case 6:
                        s = eleccion.ToString();
                        break;
                    default:
                        Console.WriteLine("Porfavor seleccione un valor valido");
                        break;
                }
            }
        }

        public void recorrer_Noticias()
        {
            Console.WriteLine("NACIONAL\n");
            Nacional.recorrer_Categoria();

            Console.WriteLine("LOCAL\n");
            Local.recorrer_Categoria();

            Console.WriteLine("DEPORTE\n");
            Deporte.recorrer_Categoria();

            Console.WriteLine("CULTURA\n");
            Cultura.recorrer_Categoria();

            Console.WriteLine("SALUD\n");
            Salud.recorrer_Categoria();
        }

        private bool verificar_Aprobacion()
        {
            Random random = new Random();
            return ((random.Next(1, 100) % 2) == 0);
        }
    }
}
