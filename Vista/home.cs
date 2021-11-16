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
        public home(int role) //1 = Admin | 2 = Vendedor
        {
            this.role = role;
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            if (role == 1)
            {
                lRol.Text = "Administrador";
                lNombre.Text = "Joseph Gonzalez";
            }
            else if(role == 2)
            {
                lRol.Text = "Vendedor";
                lNombre.Text = "Felipe Ramirez";
            }
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
    }
}
