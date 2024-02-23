try { 
Console.WriteLine("Ingrese el tipo de figura geométrica (triángulo, cuadrado o círculo):");
string Figura = Console.ReadLine().ToLower();
double area = 0;

switch (Figura)
{
    case "triangulo":
        Console.WriteLine("Ingrese la base:");
        double basetriangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura:");
        double alturatriangulo = Convert.ToDouble(Console.ReadLine());
        area = 0.5 * basetriangulo * alturatriangulo;
        break;
    case "cuadrado":
        Console.WriteLine("Ingrese el lado del cuadrado:");
        double ladocuadrado = Convert.ToDouble(Console.ReadLine());
        area = ladocuadrado * ladocuadrado;
        break;
    case "circulo":
        Console.WriteLine("Ingrese el radio del círculo:");
        double radiocirculo = Convert.ToDouble(Console.ReadLine());
        area = Math.PI * radiocirculo * radiocirculo;
        break;
    default:
        Console.WriteLine("Figura Geometrica no valida");
        return;
}

Console.WriteLine($"El área de la figura geométrica {Figura} es: {area}");
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese valores numéricos válidos.");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}