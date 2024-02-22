using System.Runtime.ConstrainedExecution;

try
{
    string NombreUsuario = "Usuario";
    string ContraseñaV = "contraseña";

    Console.WriteLine("Ingrese su nombre de usuario: ");
    string NombreusuarioI = Console.ReadLine();
    Console.WriteLine("Ingrese su contraseña: ");
    string ContraseñaI = Console.ReadLine();

    if (NombreusuarioI == NombreUsuario && ContraseñaI == ContraseñaV)
    {
        Console.WriteLine("Acceso autorizado");
    }
    else
    {
        Console.WriteLine("usuario o contraseña invalidos, reintente denuevo porfavor");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Se ha producido un error: " + ex.Message);
}