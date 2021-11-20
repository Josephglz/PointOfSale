using System;
using System.Data;
using System.Windows.Forms;
using Controlador;
using ControladorDLL;

namespace Vista
{
    public partial class loader : Form
    {
        private login vLogin;
        private DataSet productos;
        public loader()
        {
            InitializeComponent();
            string query = string.Format("SELECT * FROM Productos");
            DataSet productos = Biblioteca.herramientas(query);
            vLogin = new login(productos);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(loaderbar.Value < 100)
            {
                loaderbar.Value += 10;
            }
            else
            {
                vLogin.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
