try
{
    Console.WriteLine("ingrese la figura geometrica que desea calcular (cuadrado, triangulo o circulo)");
    string Figura = Console.ReadLine();
    double area = 0;

    switch (Figura)
    {
        case "triangulo":
            Console.WriteLine("Ingrese la base: ");
            double basetriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura:");
            double alturatriangulo = Convert.ToDouble(Console.ReadLine());
            area = 0.5 * basetriangulo * alturatriangulo;
            break;
        case "cuadrado":
            Console.WriteLine("Ingrese el lado:");
            double lado = Convert.ToDouble(Console.ReadLine());
            area = lado * lado;
            break;
        case "circulo":
            Console.WriteLine("Ingrese el radio:");
            double radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radio * radio;
            break;
        default:
            Console.WriteLine("Tipo de figura geométrica no válido.");
            return;
    }

    Console.WriteLine("El área de: " + Figura + "es: " + area);
}
catch (FormatException)
{
    Console.WriteLine("Solamente valores numeros porfavor");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}