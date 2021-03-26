using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Flyweigth
{
    class Noticia : I_Flyweight
    {
        private string titulo;
        public bool Publicacion_Aprobada;

        public Noticia (string t)
        {
            titulo = t;
            Publicacion_Aprobada = false;
        }

        public void actualizar_Aprobacion(bool desicion)
        {
            Publicacion_Aprobada = desicion;
        }

        public bool is_Publicacion_Aprobada()
        {
            return Publicacion_Aprobada;
        }

        public string get_Titulo()
        {
            return titulo;
        }

        public void get_Info_Noticia()
        {
            Console.WriteLine("Titulo: {0} Aprobada: {1}", titulo, Publicacion_Aprobada);
        }
    }
}
