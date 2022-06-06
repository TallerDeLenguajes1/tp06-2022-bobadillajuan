Calculadora calc = new Calculadora(5);
int numero = 0;

Console.WriteLine("--- Calculadora. Valor inicial = 5---");
Console.WriteLine("Selecciones la operacion: ");
while (numero != 10)
{
Console.WriteLine("\n1) Sumar.");
Console.WriteLine("\n2) Restar.");
Console.WriteLine("\n3) Multiplicar.");
Console.WriteLine("\n4) Dividir.");
Console.WriteLine("\n5) Limpiar.");
Console.WriteLine("\n6) Salir.\n");

numero = Convert.ToInt32(Console.ReadLine());

switch (numero)
{
    case 1: 
    Console.WriteLine("\nIngrese operador: ");
    calc.Suma(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine("Resultado: " + calc.Resultado);
    break;

    case 2:
    Console.WriteLine("\nIngrese operador: ");
    calc.Resta(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine("Resultado: " + calc.Resultado);
    break;

    case 3:
    Console.WriteLine("\nIngrese operador: ");
    calc.Multiplicar(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine("Resultado: " + calc.Resultado);
    break;

    case 4:
    Console.WriteLine("\nIngrese operador: ");
    calc.Dividir(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine("Resultado: " + calc.Resultado);
    break;

    case 5:
    calc.Limpiar();
    Console.WriteLine("Resultado: " + calc.Resultado);
    break;

    case 6:
    Console.WriteLine("Fin de la calculadora. Resultado final: ");
    Console.WriteLine("Resultado: " + calc.Resultado);
    numero = 10;
    break;

    

    default:
    Console.WriteLine("\nComando inválido, ingrese nuevamente un comando\n ");
    break;
}
}