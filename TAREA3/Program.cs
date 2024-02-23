try
{
    Console.WriteLine("Ingrese un número del 1 al 5 en letra (uno, dos, tres, cuatro, cinco):");
    string Letra = Console.ReadLine().ToLower();

    int Digito = 0;
    switch (Letra)
    {
        case "uno":
            Digito = 1;
            break;
        case "dos":
            Digito = 2;
            break;
        case "tres":
            Digito = 3;
            break;
        case "cuatro":
            Digito = 4;
            break;
        case "cinco":
            Digito = 5;
            break;
        default:
            Console.WriteLine("Número en letra no válido.");
            return;
    }

    Console.WriteLine($"El número en dígito es: {Digito}");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}