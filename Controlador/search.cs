using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Controlador
{
    public partial class search : Form
    {
        List<Producto> listaProductos = new List<Producto>();
        public search(List<Producto> productos)
        {
            this.listaProductos = productos;
            InitializeComponent();
        }
        public int searchProduct(int opc, string value)
        {
            if(opc == 1)//ID
            {
                int id = Convert.ToInt32(value);
                for(int i = 0; i < listaProductos.Count; i++)
                {
                    if(listaProductos.ElementAt(i).getIdProducto() == id)
                    {
                        return i;
                    }
                }
            }
            else if(opc == 2) //Nombre
            {
                for(int i = 0; i < listaProductos.Count; i++)
                {
                    if(listaProductos.ElementAt(i).getNombre().Equals(value))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public void showFields()
        {
            prod_image.Visible = true;
            prod_id.Visible = true;
            prod_name.Visible = true;
            prod_precio.Visible = true;
            prod_categoria.Visible = true;
            prod_stock.Visible = true;
            prod_modo.Visible = true;
        }
        public void hideFields()
        {
            prod_image.Visible = false;
            prod_id.Visible = false;
            prod_name.Visible = false;
            prod_precio.Visible = false;
            prod_categoria.Visible = false;
            prod_stock.Visible = false;
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            int idx;
            if(cb1.Checked)//ID
            {
                idx = searchProduct(1, TBusqueda.Text);
                if(idx != -1)
                {
                    showFields();
                    lError.Visible = false;
                    prod_image.ImageLocation = listaProductos.ElementAt(idx).getImage();
                    prod_id.Text = "ID: " + listaProductos.ElementAt(idx).getIdProducto();
                    prod_name.Text = listaProductos.ElementAt(idx).getNombre();
                    prod_precio.Text = "Precio: $" + listaProductos.ElementAt(idx).getPrecio();
                    prod_categoria.Text = "Categoría: " + listaProductos.ElementAt(idx).getCategoria();
                    prod_stock.Text = "Stock: " + listaProductos.ElementAt(idx).getStock();
                    if(listaProductos.ElementAt(idx).getPerm() == 2)
                    {
                        prod_modo.Visible = true;
                    }
                }
                else
                {
                    lError.Text = "No se encontró el ID del producto.";
                    lError.Visible = true;
                    hideFields();
                }
            }
            else if(cb2.Checked)//Nombre
            {
                idx = searchProduct(2, TBusqueda.Text);
                if (idx != -1)
                {
                    showFields();
                    lError.Visible = false;
                    prod_image.ImageLocation = listaProductos.ElementAt(idx).getImage();
                    prod_id.Text = "ID: " + listaProductos.ElementAt(idx).getIdProducto();
                    prod_name.Text = listaProductos.ElementAt(idx).getNombre();
                    prod_precio.Text = "Precio: $" + listaProductos.ElementAt(idx).getPrecio();
                    prod_categoria.Text = "Categoría: " + listaProductos.ElementAt(idx).getCategoria();
                    prod_stock.Text = "Stock: " + listaProductos.ElementAt(idx).getStock();
                    if (listaProductos.ElementAt(idx).getPerm() == 2)
                    {
                        prod_modo.Visible = true;
                    }
                }
                else
                {
                    lError.Text = "No se encontró el Nombre del producto.";
                    lError.Visible = true;
                    hideFields();
                }
            }
            else
            {
                lError.Text = "Seleccione un método de Búsqueda.";
                lError.Visible = true;
            }
        }
        private void search_Load(object sender, EventArgs e)
        {
            hideFields();
        }
        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2.Checked)
            {
                cb2.Checked = false;
            }
        }
        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                cb1.Checked = false;
            }
        }
        private void TBusqueda_Enter(object sender, EventArgs e)
        {
            TBusqueda.Text = "";
        }
    }
}
