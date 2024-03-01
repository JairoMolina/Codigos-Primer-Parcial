using System;
class Program
{
    static void Main()
    {
        Random Random = new Random();
        int Num = Random.Next(1, 101);
        int IntFin = 0, Int;
        string Ent;

        Console.WriteLine("BIENVENIDO");
        Console.WriteLine("Adivina el Numero Secreto!!!");

        try
        {
            do
            {
                Console.WriteLine("Introduce un numero entre el 1 y 100:");
                Ent = Console.ReadLine();

                if (!int.TryParse(Ent, out Int))
                {
                    Console.WriteLine("Ingresa un numero valido.");
                    continue;
                }

                IntFin++;

                if (Int < Num)
                {
                    Console.WriteLine("\nEl numero es mayor.");
                }
                else if (Int > Num)
                {
                    Console.WriteLine("\nEl numero es menor.");
                }
                else
                {
                    Console.WriteLine($"\nHas adivinado el número {Num} en solo {IntFin} intentos!!!");
                }
            } while (Int != Num);

            Console.WriteLine("Gracias por jugar :D.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ha ocurrido un error: " + ex.Message);
        }
    }
}