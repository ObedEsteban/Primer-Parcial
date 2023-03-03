using System;// me permite acceder a todos los datos de tipo system para no estarlos declarando 

class Program
{
    static void Main(string[] args)
    {
        // El programa debe solicitar al usuario que ingrese un número entero positivo N mayor que cero.
        Console.Write("Ingrese un número entero positivo mayor que cero: ");
        int N = int.Parse(Console.ReadLine()); 

        // El programa debe declarar una variable entera llamada "suma" y asignarle el valor cero.

        int suma = 0;

        //Utilizando una estructura de control adecuada, el programa debe calcular la suma de los primeros N números enteros positivos y almacenar el resultado en la variable "suma".
        
        for (int i = 1; i <= N; i++)
        {
            suma += i;
        }

        // Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla todos los números enteros positivos menores o iguales que N.
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nNúmeros enteros positivos menores o iguales que " + N + ":");
        for (int i = 1; i <= N; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla todos los números enteros impares menores o iguales que N.
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nNúmeros enteros impares menores o iguales que " + N + ":");
        for (int i = 1; i <= N; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla la tabla de multiplicar del número N, desde el 1 hasta el 10.
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nTabla de multiplicar de " + N + ":");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(N + " x " + i + " = " + N * i);
        }

        // Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla la secuencia de números enteros positivos que comienzan en N y se incrementan en 2 hasta que se alcance un valor mayor que 20
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nSecuencia de números enteros positivos que comienzan en " + N + " y se incrementan en 2 hasta que se alcance un valor mayor que 20:");
        int j = N;
        while (j <= 22)
        {
            j += 2;
            Console.Write(j + " ");
            
        }
        Console.WriteLine();

        // El programa debe imprimir en la pantalla el valor de la variable "suma" al final del proceso.
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nLa suma de los primeros " + N + " números enteros positivos es: " + suma);
        Console.ResetColor();
    }
    
}