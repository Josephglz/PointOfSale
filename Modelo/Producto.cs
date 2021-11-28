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
        private float precio;
        private int categoria;
        private int stock;
        private int modo;
        private string image;
        /*=========== [ CONSTRUCTOR ] ===========*/

        public Producto()
        {
        }

        public Producto(int idProducto, string nombre, float precio, int categoria, int stock, int modo, string image)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
            this.stock = stock;
            this.modo = modo;
            this.image = image;
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

        public void setPrecio(float precio)
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

        public void setPerm(int modo)
        {
            this.modo = modo;
        }

        public void setImage(string image)
        {
            this.image = image;
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

        public float getPrecio()
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

        public int getPerm()
        {
            return modo;
        }

        public string getImage()
        {
            return image;
        }

        /*=========== [ TOSTRING ] ===========*/
        public override string ToString()
        {
            return "\n_________________________\n" +
            "ID Producto = " + idProducto + "\n" +
            "Nombre = " + nombre + "\n" +
            "Precio = " + precio + "\n" +
            "Categoria = " + categoria + "\n" +
            "Stock = " + stock + "\n" +
            "Modo = " + modo;
        }
    }
}
