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
        public loader()
        {
            InitializeComponent();
            vLogin = new login();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(loaderbar.Value < 100)
            {
                loaderbar.Value += 5;
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
