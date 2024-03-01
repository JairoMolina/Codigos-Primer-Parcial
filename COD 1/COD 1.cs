using System;
class Program
{
    static void Main()
    {
        try
        {
            while (true)
            {
                int Num, Sel;

                Console.WriteLine("Ingresa un Número que Deseas Operar: ");
                Num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nBIENVENIDO");
                Console.WriteLine("\nSelecciona una Opción");
                Console.WriteLine("Calcular el Factorial del Número -------> 1");
                Console.WriteLine("Calcular la Raiz Cuadrada Del Numero ---> 2");
                Console.WriteLine("Salir del Programa ---------------------> 3");

                Sel = Convert.ToInt32(Console.ReadLine());

                switch (Sel)
                {
                    case 1:
                        int Facto = 1;

                        if (Num == 0)
                        {
                            Facto = 1;
                        }
                        else
                        {
                            for (int i = 1; i <= Num; i++)
                            {
                                Facto *= i;
                            }
                        }
                        Console.WriteLine($"El factorial de {Num} es: {Facto}\n");
                        break;

                    case 2:
                        double Raiz = Math.Sqrt(Num);

                        Console.WriteLine($"La raiz cuadrada de {Num} es: {Raiz}\n");

                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no valida");
                        break;

                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}