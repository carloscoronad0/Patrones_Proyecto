using Patrones_Proyecto.Chain_of_Responsability;
using Patrones_Proyecto.Observer;
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


            Provincia arque = new Provincia("Arque");
            Provincia mizque = new Provincia("Mizque");
            Provincia arani = new Provincia("Arani");
            Provincia Carrasco = new Provincia("Carrasco");
            Provincia tiraque = new Provincia("Tiraque");

        }
    }
}
