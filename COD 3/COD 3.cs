using System;
class Program
{
    static void Main()
    {
        try
        {
            int Num;
            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("Ingrese un número para generar la tabla de multiplicar:");
            Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nTabla de multiplicar del {Num}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Num} x {i} = {Num * i}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error inesperado: " + ex.Message);
        }
    }
}