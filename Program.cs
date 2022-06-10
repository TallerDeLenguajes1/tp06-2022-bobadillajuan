internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n----- Control de empleados: -----");
        Empleado[] empleado = new Empleado[3];

        empleado[0] = new Empleado("Jorge", "Salcedo", new DateTime(1947, 11, 25), 'C', 'H', new DateTime(2001, 5, 12), 90000, Empleado.Cargo.Ingeniero);
        empleado[1] = new Empleado("Sara", "Nuñez", new DateTime(1988, 5, 27), 'S', 'M', new DateTime(2014, 7, 29), 85000, Empleado.Cargo.Especialista);
        empleado[2] = new Empleado("Pablo", "Rodriguez", new DateTime(1992, 1, 14), 'S', 'H', new DateTime(2018, 5, 12), 70000, Empleado.Cargo.Auxiliar);


        //Bucle para mostrar.
        Console.WriteLine("\n\t\t --- Datos de los empleados ---");
        for (int i = 0; i < 3; i++){
        empleado[i].DatosEmpleados();
        }

        Console.WriteLine("\nTotal: " + SalarioTotal(empleado));

        Console.WriteLine("El/la empleado/a con mayor antiguedad es: ");
        MasAntiguedad(empleado);

        //Método de Salarios
        double SalarioTotal(Empleado[] empleados){
        Console.WriteLine("\n --- Total de pago en concepto de salarios. ---");
        double salarioTotal = 0;
        foreach (Empleado empleado in empleados)
        {
            salarioTotal += empleado.SalarioFinal();
        }
        return salarioTotal;
        }

        

        //Metodo Más Antiguedad 
        void MasAntiguedad(Empleado[] empleados){
        Empleado EmpleadoMasAntiguedad = empleados[0];

        foreach (Empleado empleado in empleados)
        {
          if (EmpleadoMasAntiguedad.Antiguedad(EmpleadoMasAntiguedad.FechaDeIngreso) < empleado.Antiguedad(EmpleadoMasAntiguedad.FechaDeIngreso))
          {
                EmpleadoMasAntiguedad  = empleado;
          }
        }
        EmpleadoMasAntiguedad.DatosEmpleados();
        }
    }
}