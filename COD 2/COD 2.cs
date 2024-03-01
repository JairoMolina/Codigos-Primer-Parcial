using System;
class Program
{
    static void Main()
    {
        try
        {
            double Num1, Num2, Resul = 0;
            char Opera;

            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("Ingrese el primer numero:");
            Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese el segundo número:");
            Num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese el operador matemático (+, -, *, /):");
            Opera = Convert.ToChar(Console.ReadLine());

            switch (Opera)
            {
                case '+':
                    Resul = Num1 + Num2;
                    break;
                case '-':
                    Resul = Num1 - Num2;
                    break;
                case '*':
                    Resul = Num1 * Num2;
                    break;
                case '/':

                    if (Num2 != 0)
                    {
                        Resul = (double) Num1 / Num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            Console.WriteLine($"\nEl resultado de la operación {Num1} {Opera} {Num2} es: {Resul}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error inesperado: " + ex.Message);
        }
    }
}