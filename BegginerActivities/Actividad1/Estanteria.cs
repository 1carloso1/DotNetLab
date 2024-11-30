using System;
namespace actividad1
{
    public class Estanteria
    {
        List<string> peliculas = new List<string>();

        public void agregarPeliculas(Object pelicula)
        {
            string peli = pelicula.ToString();
            peliculas.Add(peli);
        }

        public void eliminarPeliculas(Object pelicula)
        {
            string peli = pelicula.ToString();
            peliculas.Remove(peli);
        }

        public void ordenarPeliculas()
        {
            peliculas.Sort();
        }

        public void imprimirPeliculas()
        {
            for(int i = 0; i < peliculas.Count; i++)
            {
                Console.WriteLine(peliculas[i]+"\n");
            }
        }

        public void mostrarInformacionPelicula(Peliculas pelicula)
        {
            Console.WriteLine(pelicula.obtenerDatos());
        }

        public void mostrarUbicacionPelicula(Object pelicula)
        {
            string peli = pelicula.ToString();
            int ubicacion = peliculas.IndexOf(peli);
            if (ubicacion != -1)
            {
                Console.WriteLine($"La ubicacion de {peli} en la estanteria es {ubicacion + 1}\n");
            }
            else {
                Console.WriteLine($"La pelicula '{peli}' no existe en tu coleccion");
            }
            
        }

        public void mostrarUbicacionPeliculas()
        {
            for (int i = 0; i < peliculas.Count; i++)
            {
                string peli = peliculas[i].ToString();
                int ubicacion = peliculas.IndexOf(peli);
                Console.WriteLine($"La ubicacion de {peli} en la estanteria es {i + 1}\n");
            }
        }
    }
}
