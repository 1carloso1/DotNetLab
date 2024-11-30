using System;

namespace actividad2
{
	public class Productos
	{
		string _noProductos;
		string _nombre;
		string _categoria;
		double _precio;
		string _caducidad;
		public Productos(string noProducto, string nombre, string categoria, double precio, string caducidad)
		{
			this._noProductos = noProducto;
			this._nombre = nombre;
			this._categoria = categoria;
			this._precio = precio;
			this._caducidad = caducidad;
		}

		public int intProducto { set; get; }
		public string nombre { set; get; }
		public string categoria { set; get; }
		public double getPrecio() { 
			return this._precio;
			}
		public string caducidad { set; get; }

		public string obtenerDatos()
        {
			return $"No. Producto: {this._noProductos}, Nombre: {this._nombre}, Categoria: {this._categoria}, Precio: ${this._precio}, Caducidad: {this._caducidad}";
        }

		public override string ToString()
		{
			return this._nombre;
		}
	}
}
