using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Controlador;


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

        private void loader_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(loaderbar.Value < 100)
            {
                loaderbar.Value += 2;
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
