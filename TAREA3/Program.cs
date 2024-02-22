try
{
    Console.WriteLine("Ingrese su edad actual:");
    int Edad = Convert.ToInt32(Console.ReadLine());

    if (Edad > 18)
    {
        Console.WriteLine("Feicidades, puedes pasar al club");
    }
    else
    {
        Console.WriteLine("No tienes la edad suficiente para entrar");
    }
}
catch (FormatException)
{
    Console.WriteLine("Coloca solo numeros porfavor");
}
catch (Exception ex)
{
    Console.WriteLine("Se ha producido un error: " + ex.Message);
}