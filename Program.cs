using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la calculadora");

        while (true)
        {
            Console.WriteLine("Por favor, elija una opción:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potenciación");
            Console.WriteLine("6. Salir");

            int opcion;
            double num1, num2;

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 6)
            {
                Console.WriteLine("Opción inválida. Por favor, elija una opción del 1 al 6.");
                continue;
            }

            if (opcion == 6)
            {
                Console.WriteLine("Saliendo de la calculadora...");
                break;
            }

            Console.WriteLine("Ingrese el primer número:");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Número inválido. Intente de nuevo.");
                continue;
            }

            Console.WriteLine("Ingrese el segundo número:");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Número inválido. Intente de nuevo.");
                continue;
            }

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("La suma es: " + resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("La resta es: " + resultado);
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("La multiplicación es: " + resultado);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("La división es: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                    }
                    break;
                case 5:
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("La potencia es: " + resultado);
                    break;
            }
        }
    }
}
