using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Flyweigth
{
    class Flyweight_Factory
    {
        private List<I_Flyweight> Noticias;

        public Flyweight_Factory()
        {
            Noticias = new List<I_Flyweight>();
        }

        public void agregar_Noticia(I_Flyweight n)
        {
            if (n.is_Publicacion_Aprobada())
            {
                bool existe = false;
                foreach(I_Flyweight f in Noticias)
                {
                    if (f.get_Titulo() == n.get_Titulo())
                    {
                        existe = true;
                    }
                }

                if (existe)
                {
                    Console.WriteLine("La Noticia ya se encuentra agregada");
                }
                else
                {
                    Noticias.Add(n);
                }
            }
        }

        public void recorrer_Categoria()
        {
            foreach(I_Flyweight n in Noticias)
            {
                n.get_Info_Noticia();
            }
        }

        public I_Flyweight this[int index]
        {
            get { return Noticias[index]; }
        }
    }
}
