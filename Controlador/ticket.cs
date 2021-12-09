using ControladorDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public partial class ticket : Form
    {
        private string fecha, hora, total, subtotal, iva, pago, cambio, nombre;
        private int idEmpleado, ID;
        List<string> carrito = new List<string>();
        public ticket(int idEmpleado, string fecha, string hora, string total, string subtotal, string iva, string pago, string cambio, string nombre, List<string> carrito)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
            this.fecha = fecha;
            this.hora = hora;
            this.total = total;
            this.subtotal = subtotal;
            this.iva = iva;
            this.pago = pago;
            this.cambio = cambio;
            this.nombre = nombre;
            this.carrito = carrito;
        }
        public string getCart()
        {
            string cart="";
            for(int i = 0; i < carrito.Count; i++)
            {
                cart = cart + carrito.ElementAt(i) + "|";
            }

            return cart;
        }

        public void generateTicket()
        {
            string query = "SELECT TOP 1 idTicket FROM Tickets ORDER BY idTicket DESC";
            DataSet queryID = Biblioteca.herramientas(query);
            ID = Int32.Parse(queryID.Tables[0].Rows[0]["idTicket"].ToString().Trim()) + 1;

            query = "INSERT INTO Tickets VALUES(" + ID + ",'" + getCart() + "','" + fecha + "','" + hora + "'," + total + "," + pago + "," + idEmpleado + ");";
            Biblioteca.herramientas(query);
        }
        private void ticket_Load(object sender, EventArgs e)
        {
            generateTicket();
            lFecha.Text = fecha;
            lHora.Text = hora;
            lTotal.Text = total;
            lSubtotal.Text = subtotal;
            lIVA.Text = iva;
            lEfectivo.Text = pago;
            lCambio.Text = cambio;
            lblMensaje.Text = "GRACIAS POR SU COMPRA.\nLe atendió: " + nombre;
            lTicket.Text = "TICKET N°: " + ID;

            for (int i = 0; i < carrito.Count; i++)
            {
                string[] datos = carrito.ElementAt(i).Split(',');
                Panel Prod_Panel = new Panel();
                Label Prod_Cant = new Label();
                Label Prod_Name = new Label();
                Label Prod_Precio = new Label();

                Prod_Panel.Controls.Add(Prod_Cant);
                Prod_Panel.Controls.Add(Prod_Name);
                Prod_Panel.Controls.Add(Prod_Precio);
                Prod_Panel.Location = new System.Drawing.Point(3, 3);
                Prod_Panel.Name = "Prod_Panel";
                Prod_Panel.Size = new System.Drawing.Size(304, 20);
                Prod_Panel.TabIndex = 0;

                Prod_Cant.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Prod_Cant.ForeColor = System.Drawing.Color.Black;
                Prod_Cant.Location = new System.Drawing.Point(3, 0);
                Prod_Cant.Name = "Prod_Cant";
                Prod_Cant.Size = new System.Drawing.Size(55, 21);
                Prod_Cant.TabIndex = 50;
                Prod_Cant.Text = datos[2];

                Prod_Name.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Prod_Name.ForeColor = System.Drawing.Color.Black;
                Prod_Name.Location = new System.Drawing.Point(64, 0);
                Prod_Name.Name = "Prod_Name";
                Prod_Name.Size = new System.Drawing.Size(163, 21);
                Prod_Name.TabIndex = 49;
                Prod_Name.Text = datos[0];

                Prod_Precio.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Prod_Precio.ForeColor = System.Drawing.Color.Black;
                Prod_Precio.Location = new System.Drawing.Point(233, 0);
                Prod_Precio.Name = "Prod_Precio";
                Prod_Precio.Size = new System.Drawing.Size(64, 21);
                Prod_Precio.TabIndex = 51;
                Prod_Precio.Text = "$" + datos[1];


                ticket_prPanel.Controls.Add(Prod_Panel);
                Prod_Panel.ResumeLayout(false);
            }

        }
        private void logoTienda_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
