try
{
    Console.WriteLine("Ingrese la calificación de su examen porfavor:");
    int calificacion = Convert.ToInt32(Console.ReadLine());
    switch (calificacion)
    {
        case >= 90 and <= 100:
            Console.WriteLine("Felicidades eres sobresaliente");
            break;
        case >= 80 and <= 89:
            Console.WriteLine("Felicidades eres mejor al primedio");
            break;
        case >= 70 and <= 79:
            Console.WriteLine("Felicidades aprobaste");
            break;
        case >= 60 and <= 69:
            Console.WriteLine("Lamentablemente no aprobaste");
            break;
        default:
            Console.WriteLine("Calificación no válida.");
            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese una calificación válida.");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}
    