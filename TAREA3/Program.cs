try
{
    Console.WriteLine("Ingrese un numero : ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if ( numero % 2 == 0)
    {
        Console.WriteLine("Su numero es par");
    }
    else
    {
        Console.WriteLine("su numero es impar");
    }
}
catch (FormatException)
{
    Console.WriteLine("Ingresar solamente numeros porfavor");
}
catch (Exception ex)
{
    Console.WriteLine("Se ha producido un error: " + ex.Message);
}