
public class Empleado
    {
    public enum Cargo
        {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }

    public string Nombre;
    public string Apellido;
    public DateTime FechaDeNacimiento;
    public char EstadoCivil;
    public char Genero;
    public DateTime FechaDeIngreso;
    public double Sueldo;
    public Cargo CargoAsignado;

    public Empleado(string nombre, string apellido, DateTime fechaDeNacimiento, char estadoCivil, char genero, DateTime fechaDeIngreso, double sueldo, Cargo cargo){

        if(!string.IsNullOrEmpty(nombre)){
        Nombre = nombre;
        }else{
        Nombre = "Indefinido";  
        }

        if(!string.IsNullOrEmpty(nombre)){
        Apellido = apellido;
        }else{
        Apellido = "Indefinido";  
        }

        FechaDeNacimiento = fechaDeNacimiento;
        EstadoCivil = estadoCivil;
        FechaDeIngreso = fechaDeIngreso;
        Sueldo = sueldo;
        Genero = genero;
        CargoAsignado = cargo;

    }

    public void DatosEmpleados(){
        Console.WriteLine("\nNombre: " + Nombre);
        Console.WriteLine("\nApellido: " + Apellido);
        Console.WriteLine("\nFecha de Nacimiento: " + FechaDeNacimiento.ToString("dd-MM-yyyy"));
        Console.WriteLine("\nGenero: " + Genero);
        Console.WriteLine("\nFecha de Ingreso: " + FechaDeIngreso.ToString("dd-MM-yyyy"));
        Console.WriteLine("\nCargo: " + CargoAsignado);

        Console.WriteLine("\n\nEdad: " + EdadCalcular(FechaDeNacimiento));
        Console.WriteLine("\nAntigüedad: " + Antiguedad(FechaDeIngreso));
        Console.WriteLine("\nAños faltantes para jubilarse: " + Jubilacion(FechaDeNacimiento, Genero));
        Console.WriteLine("\nSalario: " + SalarioFinal());

    }

    public int EdadCalcular(DateTime fechaDeNacimiento){
        
        int edad;
        edad = DateTime.Now.Year - fechaDeNacimiento.Year;
        return edad;
    }

    public int Antiguedad(DateTime fechaDeIngreso){

        int antiguedad;
        antiguedad = DateTime.Now.Year - fechaDeIngreso.Year;
        return antiguedad;

    }

    public int Jubilacion(DateTime fechaDeNacimiento, char genero){
        
        int edad = EdadCalcular(fechaDeNacimiento);
        int aniosFaltantes;
        
        if (genero == 'H')
        {
            if(edad > 65){
                aniosFaltantes = 0;
            }else{
                aniosFaltantes = 65 - edad;
            }
        }else{
            if(edad > 60){
                aniosFaltantes = 0;
            }else{
                aniosFaltantes = 60 - edad;
            }
        }
        return aniosFaltantes;
    }

    

    public double SalarioFinal(){

        double salarioFinal = 0, adicional = 0;
        int antiguedad = Antiguedad(FechaDeIngreso);

        if (antiguedad < 20)
        {
            adicional = Sueldo * (antiguedad/100);
        }else{
            if (antiguedad >= 20)
            {
                adicional = Sueldo *0.25;
    
            }
        }

        if (CargoAsignado == Cargo.Ingeniero || CargoAsignado == Cargo.Especialista){
            adicional = adicional + (adicional/100);
        }

        if (EstadoCivil == 'C'){
            adicional = adicional + 15000;
        }


        salarioFinal = adicional + Sueldo;
        return salarioFinal;
    }






}
