using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaDeCoches
{
    class Coche:MedioTransporte
    {
        public Motor motorCoche;
        public int velocidad;
        public string marca;

        public void Frenar()
        {
            if (velocidad > 0)
                velocidad--;
        }
        public void Acelerar()
        {
            velocidad++;
        }
            
    }
}
