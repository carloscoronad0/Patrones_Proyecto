using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Proyecto.State
{
    class Random_Value
    {
        public static int random_Value(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }
    }
}
