

namespace Floreria.Modelos
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public Pedido Pedido { get;  set; }

        public Cliente( string nombre, Pedido pedido)
        {
            Nombre = nombre;
            Pedido = pedido;
        }

        public void MostrarResumenPedido()
        {
            Console.WriteLine($"Pedido del cliente {Nombre}\n--------------------------------------------- ");
        
        }

    }
}
