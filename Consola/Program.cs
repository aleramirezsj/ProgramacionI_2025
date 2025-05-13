
using Consola.Class;

internal class Program
{
    private static void Main(string[] args)
    {
        //var prueba= new PruebaSintaxis1();
        //prueba.ImprimirSaludo("Alejandro Ramirez");
        //prueba.ImprimirDeudaFactura();
        var calcu = new Calculadora();
        calcu.Sumar(10, 20);
        calcu.ImprimirResultado();
    }
}