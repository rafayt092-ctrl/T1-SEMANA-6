using System;

namespace T1_VALENTE_HUANCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadas listaCar = new ListaEnlazadas();

            listaCar.AgregaDosCarros("Toyota", 4, 1.5, "Nissan", 4, 1.6);
            listaCar.AgregaDosCarros("Kia", 5, 2.0, "Mercedes", 4, 1.4);
            listaCar.AgregaDosCarros("Ford", 2, 5.0, "Mitshubishi", 4, 2.5);
            listaCar.AgregaDosCarros("Mazda", 4, 2.2, "Honda", 2, 1.8);

            Console.WriteLine("--- CONTENIDO DE LISTA DE CARROS ---");
            Console.WriteLine(listaCar.ToString());

            Console.ReadKey();
        }
    }
}