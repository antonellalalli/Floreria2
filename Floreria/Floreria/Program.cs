namespace Floreria.Modelos
{
    class Program
    {
        static void Main()
        {
            Flor Girasol = new Flor("Girasol", 250);
            Flor Margarita = new Flor("Margarita", 300);
            Flor Jazmin = new Flor("Jazmin", 500);
            Flor Rosa = new Flor("Rosa", 150);


            ArregloFloral nuevoArreglo = new ArregloFloral(new List<Flor> { Girasol, Girasol, Margarita, Jazmin });

            ArregloFloral nuevoArreglo2 = new ArregloFloral(new List<Flor> { Rosa, Girasol, Margarita, Jazmin });

            ArregloFloral nuevoArreglo3 = new ArregloFloral(new List<Flor> {Margarita, Jazmin });

            ArregloFloral nuevoArreglo4 = new ArregloFloral(new List<Flor> { Girasol, Jazmin });

            ArregloFloral nuevoArreglo5 = new ArregloFloral(new List<Flor> { Girasol, Margarita, Jazmin });

            Pedido nuevoPedido = new Pedido(new List<ArregloFloral> { nuevoArreglo, nuevoArreglo2, nuevoArreglo3, nuevoArreglo4, nuevoArreglo5 });
            
            Cliente Antonella = new Cliente("Antonella Lalli", nuevoPedido);
            Antonella.MostrarResumenPedido();
            nuevoPedido.CalcularCostoFinal();



        }
    }
}
