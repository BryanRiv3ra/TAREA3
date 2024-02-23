try
{
    Console.WriteLine("Ingrese el servicio que quiere recibir (lavado de auto, cambio de aceite, revisión mecánica):");
    string Servicio = Console.ReadLine().ToLower();
    double Pago = 0;

    switch (Servicio)
    {
        case "lavado de auto":
            Pago = 50;
            break;
        case "cambio de aceite":
            Pago = 25;
            break;
        case "revisión mecánica":
            Pago = 150;
            break;
        default:
            Console.WriteLine("Tipo de servicio no válido.");
            return;
    }
    Console.WriteLine($"El importe a pagar por {Servicio} es: {Pago}");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}