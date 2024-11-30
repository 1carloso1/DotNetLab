using System;

namespace actividad1
{
    public class Peliculas 
    {
        private string _nombre;
        private string _genero;
        private string _director;
        private int _anio;
        public Peliculas(string nombre, string genero, string director, int anio) 
        {
            this._nombre = nombre;
            this._genero = genero;
            this._director = director;
            this._anio = anio;
        }

        public string nombre { set; get; }
        public string genero { set; get; }
        public string director { set; get; }
        public int anio { set; get; }

        public string obtenerDatos() 
        {

            return $"Nombre de la pelicula: {this._nombre}, Genero: {this._genero}, Director {this._director}, Año: {this._anio} \n";
        }
        public override string ToString()
        {
            return this._nombre;
        }
    }
}
