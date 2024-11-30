using actividad1;
using actividad2;
int opcionInt;
do
{
    Console.WriteLine("TAREA 2\n" +
        "1.-Actividad 1\n" +
        "2.-Actividad 2\n" +
        "0.-Salir\n" +
        "POR FAVOR ELIJA UNA OPCION");
    String opcion = Console.ReadLine();
    opcionInt = Int32.Parse(opcion);
    switch (opcionInt)
    {
        case 1:
            Peliculas pelicula1 = new Peliculas("Star Wars Capitulo IV", "Ciencia Ficcion", "Gorge Lucas", 1977);
            Peliculas pelicula2 = new Peliculas("Star Wars Capitulo V", "Ciencia Ficcion", "Gorge Lucas", 1980);
            Peliculas pelicula3 = new Peliculas("Star Wars Capitulo VI", "Ciencia Ficcion", "Gorge Lucas", 1983);
            Peliculas pelicula4 = new Peliculas("Star Wars Capitulo I", "Ciencia Ficcion", "Gorge Lucas", 1999);
            Peliculas pelicula5 = new Peliculas("Star Wars Capitulo II", "Ciencia Ficcion", "Gorge Lucas", 2002);
            Peliculas pelicula6 = new Peliculas("Star Wars Capitulo III", "Ciencia Ficcion", "Gorge Lucas", 2005);

            Estanteria estanteria = new Estanteria();
            estanteria.agregarPeliculas(pelicula1);
            estanteria.agregarPeliculas(pelicula2);
            estanteria.agregarPeliculas(pelicula3);
            estanteria.agregarPeliculas(pelicula4);
            estanteria.agregarPeliculas(pelicula5);
            estanteria.agregarPeliculas(pelicula6);
            //Para relizar esta actividad es necesaria la clase Peliculas, ya que s la que prove el objeto que guaarda las peliculas y su info
            //la clase Estanteria es la que se encarga de los metodos para ordenar e invocar las peliculas
            Console.WriteLine("-----La estanteria desordenada queda de la siguiente manera----- \n");
            estanteria.imprimirPeliculas();
            Console.WriteLine("-----La estanteria ordenada queda de la siguiente manera----- \n");
            estanteria.ordenarPeliculas();
            estanteria.imprimirPeliculas();

            Console.WriteLine("-----Informacion de las peliculas----- \n");
            estanteria.mostrarInformacionPelicula(pelicula4);
            estanteria.mostrarInformacionPelicula(pelicula5);
            estanteria.mostrarInformacionPelicula(pelicula6);
            estanteria.mostrarInformacionPelicula(pelicula1);
            estanteria.mostrarInformacionPelicula(pelicula2);
            estanteria.mostrarInformacionPelicula(pelicula3);

            Console.WriteLine("-----Buscar Ubicacion de una pelicula especifica----- \n");
            Console.WriteLine("INGRESE EL NOMBRE COMPLETO DE LA PELICULA QUE BUSCA: ");
            String peliculaEspecifica = Console.ReadLine();
            estanteria.mostrarUbicacionPelicula(peliculaEspecifica);

            Console.WriteLine("-----Ubicacion de todas las peliculas----- \n");
            estanteria.mostrarUbicacionPeliculas();
            break;
        case 2:
            Console.WriteLine("Actividad2");
            Productos producto1 = new Productos("12345", "Negritos", "panecillos", 15, "11/04/2022");
            Productos producto2 = new Productos("12346", "Coca-Cola", "sodas", 15, "11/04/2022");
            Productos producto3 = new Productos("12347", "Pepsi", "sodas", 15, "11/04/2022");
            Productos producto4 = new Productos("12348", "Chocorroles", "panecillos", 13, "11/04/2022");
            Productos producto5 = new Productos("12349", "Jarritos", "sodas", 11, "11/04/2022");
            Productos producto6 = new Productos("12310", "Doritos", "botanas", 17, "11/04/2022");
            Productos producto7 = new Productos("12311", "Cheetos", "botanas", 14.60, "11/04/2022");

            Tiendita tienda = new Tiendita();

            tienda.agregarProducto(producto1);
            tienda.agregarProducto(producto2);
            tienda.agregarProducto(producto3);
            tienda.agregarProducto(producto4);
            tienda.agregarProducto(producto5);
            tienda.agregarProducto(producto6);
            tienda.agregarProducto(producto7);
            Console.WriteLine("-----PRODUCTOS----- \n");
            tienda.mostrarProductos();
            Console.WriteLine("-----COMPRAR-----\n");
            tienda.comprarProductos(producto7, 5);
            tienda.comprarProductos(producto2, 2);
            tienda.comprarProductos(producto4, 1);
            tienda.comprarProductos(producto5, 6);
            Console.WriteLine("-----PRODUCTO MAS VENDIDO-----\n");
            tienda.productoMasVendido();
            break;
    }
}
while (opcionInt != 0);
