try
{ 
    Console.WriteLine("Ingrese un número del 1 al 7:");
    int numeroDia = Convert.ToInt32(Console.ReadLine());

    string dia = "";
    switch (numeroDia)
    {
        case 1:
            dia = "Lunes";
            break;
        case 2:
            dia = "Martes";
            break;
        case 3:
            dia = "Miércoles";
            break;
        case 4:
            dia = "Jueves";
            break;
        case 5:
            dia = "Viernes";
            break;
        case 6:
            dia = "Sábado";
            break;
        case 7:
            dia = "Domingo";
            break;
        default:
            Console.WriteLine("Número de día no válido.");
            return;
    }

    Console.WriteLine($"El día de la semana correspondiente a {numeroDia} es: {dia}");
}
catch (FormatException)
{
    Console.WriteLine("Ingrese solo numeros validos.");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}