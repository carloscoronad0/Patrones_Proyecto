using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.Flyweigth
{
    interface I_Flyweight
    {
        void actualizar_Aprobacion(bool desicion);
        string get_Titulo();
        bool is_Publicacion_Aprobada();

        void get_Info_Noticia();
    }
}
