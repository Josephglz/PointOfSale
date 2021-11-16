using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public partial class login : Form
    {
        home vHome;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tUser.Text == "admin" && tPass.Text == "admin")
            {
                lError.Visible = false;
                vHome = new home(1); //1 = Admin | 2 = Vendedor
                this.Hide();
                vHome.ShowDialog();
                this.Show();
                clearFields();
            }
            else if(tUser.Text == "vendedor" && tPass.Text == "vendedor")
            {
                lError.Visible = false;
                vHome = new home(2);
                this.Hide();
                vHome.ShowDialog();
                this.Show();
                clearFields();
            }
            else
            {
                lError.Visible = true;
            }
        }

        private void clearFields()
        {
            tUser.Text = "";
            tPass.Text = "";
        }
    }
}
