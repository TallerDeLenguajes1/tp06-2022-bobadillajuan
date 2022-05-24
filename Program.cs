// See https://aka.ms/new-console-template for more information

Calculadora calc = new Calculadora(5);
int numero = 0;

Console.WriteLine("--- Calculadora. Valor inicial = 5---");
Console.WriteLine("Selecciones la operacion: ");
while (numero != 10)
{
numero = int.Parse(Console.ReadLine());
switch (numero)
{
    case 1: 
    calc.Suma(5);
    Console.WriteLine(calc.Resultado);
    break;

    case 2:
    calc.Resta(6);
    Console.WriteLine(calc.Resultado);
    break;

    case 3:
    calc.Multiplicar(2);
    Console.WriteLine(calc.Resultado);
    break;

    case 4:
    calc.Dividir(3);
    Console.WriteLine(calc.Resultado);
    break;

    case 5:
    calc.Limpiar();
    Console.WriteLine(calc.Resultado);
    break;

    default:
    Console.WriteLine("Fin de la calculadora. Resultado final: ");
    Console.WriteLine(calc.Resultado);
    numero = 10;
    break;
}
}
