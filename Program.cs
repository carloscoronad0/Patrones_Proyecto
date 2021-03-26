using Patrones_Proyecto.Chain_of_Responsability;
using System;

namespace Patrones_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            HandlerDirector director = new HandlerDirector();
            HandlerJefe jefe = new HandlerJefe(director);
            HandlerRevisor revisor = new HandlerRevisor(jefe);
            HandlerEditor editor = new HandlerEditor(revisor);
            
        }
    }
}
