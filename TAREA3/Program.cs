try
{
    Console.WriteLine("porfavor Ingrese su primer número:");
    double numero1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ahora ingrese el segundo número:");
    double numero2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Por ultimo el tercer número:");
    double numero3 = Convert.ToDouble(Console.ReadLine());

    double numero = numero1;

    if (numero2 > numero)
    {
        numero = numero2;
    }

    if (numero3 > numero)
    {
        numero = numero3;
    }

    Console.WriteLine("El mayor de los 3 numeros ingresados es: " + numero);
}
catch (FormatException)
{
    Console.WriteLine("Haga el favor de solo colocar numeros");
}
catch (Exception ex)
{
    Console.WriteLine("Se ha producido un error: " + ex.Message);
}