
public class Empleado{

    
    // public string nombre;
    // public string apellido;
    public DateTime fechaNacimiento; 
    public char estadoCivil; 
    public char genero;
    public DateTime fechaIngreso;
    public double sueldoBasico;
    enum cargos{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public void Antiguedad(DateTime ingreso){

        
        //Probando
        DateTime fechaActual = new DateTime(2022, 5, 24);
        TimeSpan antiguedad = fechaActual.Subtract(ingreso);
        Console.WriteLine(antiguedad.ToString());  

    }

 

}