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
    public partial class users : Form
    {
        private DataSet usuarios;
        private int id_user;
        public users(int id_user, DataSet user)
        {
            this.id_user = id_user;
            this.usuarios = user;
            InitializeComponent();
        }
        private void users_Load(object sender, EventArgs e)
        {
            string nombre = usuarios.Tables[0].Rows[0]["nombre"].ToString().Trim();
            string apellido = usuarios.Tables[0].Rows[0]["apellido"].ToString().Trim();
            string image = usuarios.Tables[0].Rows[0]["image"].ToString().Trim();
            if (!image.Equals("empty"))
            {
                profilePicture.ImageLocation = image;
            }
            lNombre.Text = nombre + " " + apellido;
            LoadUsersToTable();
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void clock_Tick(object sender, EventArgs e)
        {
            lReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lFecha.Text = DateTime.Now.ToString("dd/MMM/yyyy");
        }
        private string generateRPass()
        {
            const string src = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#$%&/()=@.,;{}+|°";
            int length = 18;
            var sb = new StringBuilder();
            Random RNG = new Random();
            for (var i = 0; i < length; i++)
            {
                var c = src[RNG.Next(0, src.Length)];
                sb.Append(c);
            }
            return sb.ToString();
        }
        public void LoadUsersToTable()
        {
            DataTable tablaUsers = new DataTable();

            tablaUsers.Columns.Add("ID Empleado");
            tablaUsers.Columns.Add("Nombre");
            tablaUsers.Columns.Add("Apellido");
            tablaUsers.Columns.Add("Rol");
            tablaUsers.Columns.Add("Usuario");
            tablaUsers.Columns.Add("Ult. Conexion");

            tablaUsers.Rows.Add("1", "Joseph", "Gonzalez", "Administrador", "us1jos", "27/nov./2021 - 20:55:31");

            userTable.DataSource = tablaUsers;
        }
    }
}
