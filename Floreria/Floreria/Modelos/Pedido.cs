
namespace Floreria.Modelos
{
    public class Pedido
    {

        public List<ArregloFloral> _arreglos = new List<ArregloFloral>();
        public double Total { get; set; }
        public bool DescuentoAplicado { get; set; } // no entiendo como iria esto


        public Pedido(List<ArregloFloral> arreglosflorales)
        {
            _arreglos = arreglosflorales;
        }


        public void CalcularCostoFinal()
        {

            double total = 0;
            
            foreach (ArregloFloral arreglo in _arreglos)
            {
                total += arreglo.ObtenerCostoArreglo();
                Console.WriteLine("----------------------------------------------");

            }

            Console.WriteLine($"El total consta de ${total}");
            Console.WriteLine("----------------------------------------------");

            double CostoConDescuento = total;

            if (_arreglos.Count > 4 )

            {
                CostoConDescuento -= CostoConDescuento * 0.1;
                
                Console.WriteLine($"Descuento Total: ${CostoConDescuento}");
            }

            Console.WriteLine("----------------------------------------------");

        }

    }
}
