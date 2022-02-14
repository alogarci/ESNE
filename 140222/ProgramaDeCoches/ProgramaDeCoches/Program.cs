using System;

namespace ProgramaDeCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche c1 = new Coche();
            c1.marca = "BMW";
            c1.velocidad = 0;
            c1.numPasajeros = 3;

            Coche c2 = new Coche();
            c2.marca = "Mercedes";
            c2.velocidad = 50;
            c2.numPasajeros = 3;

            c1.Acelerar();

            for (int i = 0; i < 100; ++i)
                c2.Acelerar();

            Console.WriteLine("El {0} va a una velocidad de {1}", c1.marca, c1.velocidad);
            Console.WriteLine("El {0} va a una velocidad de {1}", c2.marca, c2.velocidad);

        }
    }
}
