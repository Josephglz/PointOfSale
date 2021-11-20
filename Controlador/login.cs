using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ControladorDLL;

namespace Controlador
{
    public partial class login : Form
    {
        home vHome;
        DataSet productos;

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
        public login(DataSet productos)
        {
            InitializeComponent();
            this.productos = productos;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("SELECT * FROM Empleados WHERE usuario='{0}' AND password='{1}'", tUser.Text.Trim(), tPass.Text.Trim());
                DataSet connect = Biblioteca.herramientas(query);

                string username = connect.Tables[0].Rows[0]["usuario"].ToString().Trim();
                string password = connect.Tables[0].Rows[0]["password"].ToString().Trim();
                int rol = Int32.Parse(connect.Tables[0].Rows[0]["rol"].ToString().Trim());
                int id = Int32.Parse(connect.Tables[0].Rows[0]["id_empleado"].ToString().Trim());

                if (username == tUser.Text.Trim() && password == tPass.Text.Trim())
                {
                    lError.Visible = false;
                    vHome = new home(rol, id, connect, productos);
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
            catch (Exception error)
            {
                Console.WriteLine("[Consola]: Ocurrió un error: " + error.Message);
                lError.Visible = true;
            }
            /*if (tUser.Text == "admin" && tPass.Text == "admin")
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
            }*/
        }

        private void clearFields()
        {
            tUser.Text = "";
            tPass.Text = "";
        }
    }
}
