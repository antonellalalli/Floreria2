
namespace Floreria.Modelos
{
    public class ArregloFloral
    {
        private List<Flor> _flores= new List<Flor>();
        public double Total { get; set; }


        public ArregloFloral(List<Flor> flores)
        {
            _flores = flores;
        }

        public double ObtenerCostoArreglo()
        {
            double costo = 0;
        
            foreach (Flor flor in _flores)
            {
                Console.WriteLine($"- {flor.Tipo}\n"); // para que en el metodo del cliente se muestren las flores de su arreglo floral

                costo += flor.Costo;

            }
             
              return costo;
        }

    }
}
