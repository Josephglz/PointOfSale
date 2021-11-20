using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private double precio;
        private int categoria;
        private int stock;
        private bool perm;
        /*=========== [ CONSTRUCTOR ] ===========*/

        public Producto()
        {
        }

        public Producto(int idProducto, string nombre, double precio, int categoria, int stock, bool perm)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
            this.stock = stock;
            this.perm = perm;
        }

        /*=========== [ SETTERS ] ===========*/
        public void setIdProducto(int idProducto)
        {
            this.idProducto = idProducto;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public void setCategoria(int categoria)
        {
            this.categoria = categoria;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }

        public void setPerm(bool perm)
        {
            this.perm = perm;
        }

        /*=========== [ GETTERS ] ===========*/
        public int getIdProducto()
        {
            return idProducto;
        }

        public string getNombre()
        {
            return nombre;
        }

        public double getPrecio()
        {
            return precio;
        }

        public int getCategoria()
        {
            return categoria;
        }

        public int getStock()
        {
            return stock;
        }

        public bool getPerm()
        {
            return perm;
        }

        /*=========== [ TOSTRING ] ===========*/
        public override string ToString()
        {
            return "\n_________________________" +
            "ID Producto = " + idProducto +
            "Nombre = " + nombre +
            "Precio = " + precio +
            "Categoria = " + categoria +
            "Stock = " + stock +
            "Permiso = " + perm;
        }
    }
}
