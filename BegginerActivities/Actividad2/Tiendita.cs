using System;

namespace actividad2{
    public class Tiendita {

        List<string> inventario = new List<string>();
        List<string> registroVentas = new List<string>();
        List<string> registroCategorias = new List<string>();
        List<int> vecesRepetidas = new List<int>();

        public void agregarProducto(Productos producto)
        {
            string nombre = producto.ToString();
            inventario.Add(nombre);
        }

        public void mostrarProductos()
        {
            for (int i = 0; i < inventario.Count; i++)
            {
                Console.WriteLine(inventario[i] + "\n");
            }
        }

        public void comprarProductos(Productos producto, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                registroVentas.Add(producto.ToString());
                registroCategorias.Add(producto.categoria);
            }
            double total = producto.getPrecio()*cantidad;
            Console.WriteLine($"Compraste {cantidad} {producto.ToString()}. El total de tu compra es ${total}");
        }

        public void productoMasVendido() {
    if (registroVentas.Count == 0) {
        Console.WriteLine("No hay ventas registradas.");
        return;
    }

    Dictionary<string, int> conteoVentas = new Dictionary<string, int>();

    foreach (var producto in registroVentas) {
        if (!conteoVentas.ContainsKey(producto)) {
            conteoVentas[producto] = 0;
        }
        conteoVentas[producto]++;
    }
    int maxVentas = 0;
    string productoMasVendido = "";

    foreach (var venta in conteoVentas) {
        if (venta.Value > maxVentas) {
            maxVentas = venta.Value;
            productoMasVendido = venta.Key;
        }
    }

    Console.WriteLine($"El producto más vendido es '{productoMasVendido}' con {maxVentas} unidades vendidas.\n");
}

    }
}
