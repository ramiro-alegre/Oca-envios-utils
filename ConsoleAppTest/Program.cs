using Oca.envios.Entidades;
using Oca.envios.Servicios.Oca;

namespace ConsoleAppTest
{
    internal class Program
    {
        // * Proyecto para testear las metodos de HttpOca.
        static void Main(string[] args)
        {
            HttpOca httpOca = new HttpOca();
            var test = httpOca.ObtenerSucursalesOca(TipoServicio.VentaEstampillas, true);
            Console.WriteLine("Total de sucursales: " + test.Count);
        }
    }
}