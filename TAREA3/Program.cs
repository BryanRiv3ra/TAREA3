using System.Runtime.ConstrainedExecution;

try
{
<<<<<<< Updated upstream
    Console.WriteLine("Ingrese el precio del producto que desea llevar");
    double Producto = Convert.ToDouble(Console.ReadLine());
    if (Producto > 100)
    {
        Double Descuento = Producto  * 0.10;
        Double PrecioFinal = Producto - Descuento;
        Console.WriteLine("Su producto aplica al 10% de descuento:" + "El precio final es " + PrecioFinal);
    }
    else
    {
        Console.WriteLine("Su producto no aplica al 10% de descuento debido a que su valor es: " + Producto);
    }
}
catch (FormatException)
{
    Console.WriteLine("Coloca solo precios de productos porfavor");
}
catch (Exception ex)
{
    Console.WriteLine("Se ha producido un error: " + ex.Message);
=======
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
    Console.WriteLine("Porfavor solo valores numericos.");
}
catch (Exception ex)
{
    Console.WriteLine("A habido un Error inesperado: " + ex.Message);
>>>>>>> Stashed changes
}