﻿
using Calcu.Class;

internal class Program
{
    private static void Main(string[] argumentos)
    {
        //Declaración de variables
        double numero1= 0;
        double numero2 = 0;
        string operacion = "";
        //Calcu.exe 20 + 30
        if (argumentos.Length > 0)
        {
            try
            {
                //Convertimos el primer argumento a un número entero
                numero1 = Convert.ToDouble(argumentos[0]);
                //Convertimos el segundo argumento a un número entero
                numero2 = Convert.ToDouble(argumentos[2]);
            }
            catch (FormatException e)
            {
                Console.WriteLine("El formato de los argumentos no es válido");
                return;
            }
            //Asignamos el tercer argumento a la variable operacion
            operacion = argumentos[1];

            var calcu = new CalculadoraCientifica();
            switch (operacion.ToLower())
            {
                case "+":
                    calcu.Sumar(numero1, numero2);
                    break;
                case "-":
                    calcu.Restar(numero1, numero2);
                    break;
                case "*":
                    calcu.Multiplicar(numero1, numero2);
                    break;
                case "/":
                    calcu.Dividir(numero1, numero2);
                    break;
                case "^":
                    calcu.Potencia(numero1, numero2);
                    break;
                case "v2":
                    calcu.RaizCuadrada(numero1);
                    break;
                default:
                    Console.WriteLine("Operación no válida");
                    break;
            }
            calcu.ImprimirResultado();
        }
        else
        {
            Console.WriteLine("No se han proporcionado argumentos.");
        }       
    }
}