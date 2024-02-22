try
{
    Console.WriteLine("Ingrese el monto del prestamo que desea realizar");
    double Prestamo = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese su edad porfavor");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (Prestamo < 5000 || edad > 60)
    {
        Console.WriteLine("usted aplica al prestamo, Felicidades");
    }
    else
    {
        Console.WriteLine("Lamentablemente no cumple con los requisitos para el prestamo");
    }
}
catch (FormatException)
{
    Console.WriteLine("Ingresar solo lo solicitado porfavor");
}
catch (Exception ex)
{
    Console.WriteLine("Se ha producido un error: " + ex.Message);
}