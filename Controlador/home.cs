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
    public partial class home : Form
    {
        private int role = 0;
        private int id_user = 0;
        private DataSet usuarios;
        private DataSet productos;

        public home() { }

        public home(int role, int id_user, DataSet user, DataSet productos)
        {
            this.role = role;
            this.id_user = id_user;
            this.usuarios = user;
            this.productos = productos;
            InitializeComponent();
            PanelProductos.AutoScroll = false;
            PanelProductos.HorizontalScroll.Enabled = false;
            PanelProductos.HorizontalScroll.Visible = false;
            PanelProductos.HorizontalScroll.Maximum = 0;
            PanelProductos.AutoScroll = true;
        }

        private void home_Load(object sender, EventArgs e)
        {
            switch (role)
            {
                case 1:
                {
                    lRol.Text = "Administrador";
                    break;
                }
                case 2:
                {
                    lRol.Text = "Vendedor";
                    break;
                }
            }
            string nombre = usuarios.Tables[0].Rows[0]["nombre"].ToString().Trim();
            string apellido = usuarios.Tables[0].Rows[0]["apellido"].ToString().Trim();
            lNombre.Text = nombre + " " + apellido;
            AbrirForms<calculadora>();
        }
        private void AbrirForms<T>() where T : Form, new()
        {
            Form formulario = panelCalculadora.Controls.OfType<T>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new T();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;

                panelCalculadora.Controls.Add(formulario);
                panelCalculadora.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void cerrarForms<T>() where T : Form, new()
        {
            Form formulario = panelCalculadora.Controls.OfType<T>().FirstOrDefault();

            if (formulario != null)
            {
                formulario.Close();
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lReloj.Text = DateTime.Now.ToString("HH:mm"); 
            lFecha.Text = DateTime.Now.ToString("dd/MMM/yyyy");
        }
        static string getAbbreviatedName(int month)
        {
            DateTime date = new DateTime(2020, month, 1);

            return date.ToString("MMM");
        }

        private void tCodigo_Enter(object sender, EventArgs e)
        {
            tCodigo.Text = "";
        }
    }
}
