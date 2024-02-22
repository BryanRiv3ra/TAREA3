using System.Runtime.ConstrainedExecution;

try
{
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
}