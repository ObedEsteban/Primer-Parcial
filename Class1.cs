using System; // es un tipo de libreria que me va permitir usar algunos tipos de datos

class Program // es una entrada que me permite inicializar mi aplicacion 
{
    static void Main(string[] args) // igual que el clas program me permite iniciar la logica de mi aplicacion 
    {
        // El programa debe solicitar al usuario que ingrese un número entero positivo N mayor que cero.
        Console.Write("Ingrese un número entero positivo mayor que cero: "); // me imprime un texto en pantalla 
        int N = int.Parse(Console.ReadLine()); // in parse me sirve para convertir los caracteres de tipo string en enteros y el console me sirve para almacenar 

        // El programa debe declarar una variable entera llamada "suma" y asignarle el valor cero.

        int suma = 0; // defino caracter de tipo entero 

        //Utilizando una estructura de control adecuada, el programa debe calcular la suma de los primeros N números enteros positivos y almacenar el resultado en la variable "suma".

        for (int i = 1; i <= N; i++) // for es un buble que nos permite evaluar situaciiones verdaderas o falsas repetidas veces y me sirve para incremetar el valor en cada evaluacion del bucle 
        {
            suma += i; // me sumara los valores
        }

        // Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla todos los números enteros positivos menores o iguales que N.
        Console.ForegroundColor = ConsoleColor.Yellow;// es una propiedad que me permite establecer distintos colores en mi pantalla
        Console.WriteLine("\nNúmeros enteros positivos menores o iguales que " + N + ":"); //me jala el valor 
        for (int i = 1; i <= N; i++) // todos los valores del 1 menores o iguales a el numero en pantalla
        {
            Console.Write(i + " ");// alamacena los numeros
        }
        Console.WriteLine();

        // Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla todos los números enteros impares menores o iguales que N.
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nNúmeros enteros impares menores o iguales que " + N + ":");
        for (int i = 1; i <= N; i += 2)// es como poner 1 mas 2 la variable aumentara de dos en dos 
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla la tabla de multiplicar del número N, desde el 1 hasta el 10.
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nTabla de multiplicar de " + N + ":"); //me sirve par aseparar los valores
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(N + " x " + i + " = " + N * i);//me imprime los simboles y la operacion 
        }

        // Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla la secuencia de números enteros positivos que comienzan en N y se incrementan en 2 hasta que se alcance un valor mayor que 20
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nSecuencia de números enteros positivos que comienzan en " + N + " y se incrementan en 2 hasta que se alcance un valor mayor que 20:");
        int j = N;
        while (j <= 22) // cuando j que es el numero ingresado sean menor o igual a 22 me aumenta de dos en dos 
        {
            Console.Write(j + " ");// me almacenara
            j += 2; // le va ir sumando 2
        }
        Console.WriteLine();

        // El programa debe imprimir en la pantalla el valor de la variable "suma" al final del proceso.
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nLa suma de los primeros " + N + " números enteros positivos es: " + suma);
        Console.ResetColor();
    }

}