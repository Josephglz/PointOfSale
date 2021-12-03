using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControladorDLL;
using Modelo;

namespace Controlador
{
    public partial class users : Form
    {
        private DataSet user;
        private int id_user, lastID, notifCount;
        DataTable tablaUsers = new DataTable();
        List<Empleado> empleados = new List<Empleado>();
        /*===============   [   LOADERS   ]   ===============*/
        public users(int id_user, DataSet user)
        {
            this.id_user = id_user;
            this.user = user;
            InitializeComponent();
        }
        private void users_Load(object sender, EventArgs e)
        {
            this.Size = new Size(790, 300);
            string nombre = user.Tables[0].Rows[0]["nombre"].ToString().Trim();
            string apellido = user.Tables[0].Rows[0]["apellido"].ToString().Trim();
            string image = user.Tables[0].Rows[0]["image"].ToString().Trim();
            if (!image.Equals("empty"))
            {
                profilePicture.ImageLocation = image;
            }
            lNombre.Text = nombre + " " + apellido;
            loadEmpleados();
            loadColumnsTable();
        }
        public void loadColumnsTable()
        {
            tablaUsers.Rows.Clear();
            tablaUsers.Columns.Clear();
            tablaUsers.Columns.Add("ID");
            tablaUsers.Columns.Add("Nombre");
            tablaUsers.Columns.Add("Apellido");
            tablaUsers.Columns.Add("Rol");
            tablaUsers.Columns.Add("Usuario");
            tablaUsers.Columns.Add("Ult. Conexion");
            loadUsersTable();

            userTable.DataSource = tablaUsers;
        }
        public void loadUsersTable()
        {
            loadEmpleados();
            for (int i = 0; i < empleados.Count; i++)
            {
                string nombre = empleados.ElementAt(i).getNombre();
                string apellido = empleados.ElementAt(i).getApellido();
                if (nombre.Length >= 20)
                {
                    nombre = nombre.Substring(0, 30);
                }
                if (apellido.Length >= 30)
                {
                    apellido = apellido.Substring(0, 40);
                }
                tablaUsers.Rows.Add(empleados.ElementAt(i).getIdempleado(), nombre, apellido, empleados.ElementAt(i).getRolName(), empleados.ElementAt(i).getUsuario(), empleados.ElementAt(i).getUltConexion());
            }
        }
        public void loadEmpleados()
        {
            DataSet usuarios = new DataSet();
            empleados.Clear();
            usuarios = Biblioteca.herramientas("SELECT * FROM Empleados");
            string nombre, apellido, usuario, password, image, ult;
            int rol, id;
            for (int i = 0; i < usuarios.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(usuarios.Tables[0].Rows[i]["id_empleado"].ToString().Trim());
                nombre = usuarios.Tables[0].Rows[i]["nombre"].ToString().Trim();
                apellido = usuarios.Tables[0].Rows[i]["apellido"].ToString().Trim();
                rol = Convert.ToInt32(usuarios.Tables[0].Rows[i]["rol"].ToString().Trim());
                usuario = usuarios.Tables[0].Rows[i]["usuario"].ToString().Trim();
                password = usuarios.Tables[0].Rows[i]["password"].ToString().Trim();
                image = usuarios.Tables[0].Rows[i]["image"].ToString().Trim();
                ult = usuarios.Tables[0].Rows[i]["lastConn"].ToString().Trim();

                empleados.Add(new Empleado(id, nombre, apellido, rol, usuario, password, ult, image));
                lastID = id+1;
            }
        }
        /*===============   [   METHODS   ]   ===============*/
        private string generateRPass()
        {
            const string src = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789#$%&/()=@+|";
            int length = 10;
            var sb = new StringBuilder();
            Random RNG = new Random();
            for (var i = 0; i < length; i++)
            {
                var c = src[RNG.Next(0, src.Length)];
                sb.Append(c);
            }
            return sb.ToString();
        }
        public void showAlert(int type, string msg, int time)
        {
            notifPanel.Visible = true;

            notifPanel.Location = new Point(
                this.ClientSize.Width / 2 - notifPanel.Size.Width / 2,
                this.ClientSize.Height / 2 - notifPanel.Size.Height / 2);
            notifPanel.Anchor = AnchorStyles.None;
            if (type == 1) //Error
            {
                notifIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                notifIcon.ForeColor = System.Drawing.Color.Red;
                notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(187)))), ((int)(((byte)(173)))));
            }
            else if (type == 2) //Info
            {
                notifIcon.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
                notifIcon.ForeColor = System.Drawing.Color.DarkTurquoise;
                notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            }
            else if (type == 3) //approve
            {
                notifIcon.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                notifIcon.ForeColor = System.Drawing.Color.LimeGreen;
                notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(246)))), ((int)(((byte)(184)))));
            }

            notifLabel.Text = msg;
            notifCount = time;
        }
        public void hideAlert()
        {
            if (notifCount <= 0)
            {
                notifPanel.Visible = false;
            }
            else
            {
                notifCount--;
            }
        }
        public int searchIndex(string username)
        {
            for(int i = 0; i < empleados.Count; i++)
            {
                if(empleados.ElementAt(i).getUsuario().Equals(username))
                {
                    return i;
                }
            }
            return -1;
        }
        /*===============   [   CONTROLLERS   ]   ===============*/
        private void clock_Tick(object sender, EventArgs e)
        {
            lReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lFecha.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            hideAlert();
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ch1_CheckedChanged(object sender, EventArgs e)
        {
            if(ch1.Checked)
            {
                ch2.Checked = false;
            }
        }
        private void tNombre_Leave(object sender, EventArgs e)
        {
            if (bUserAdd.Text == "Guardar")
            {
                if (tNombre.Text != "")
                {
                    tUser.Text = "us" + tID.Text + tNombre.Text.Substring(0, 3).ToLower();
                }
            }
        }
        private void copyUser_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tUser.Text);
            showAlert(2, "Se copió el usuario", 3);
        }
        private void copyPass_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tPass.Text);
            showAlert(2, "Se copió la contraseña", 3);
        }
        private void bUserDelete_Click(object sender, EventArgs e)
        {
            if (bUserDelete.Text == "Eliminar")
            {
                if (userTable.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(userTable.SelectedRows[0].Cells["ID"].Value);
                    string str = "Empleado ID: " + id +
                        "\nNombre: " + empleados.ElementAt(id - 1).getNombre() + " " + empleados.ElementAt(id - 1).getApellido() +
                        "\nRol: " + empleados.ElementAt(id - 1).getRolName() +
                        "\n\n¿Deseas eliminar este empleado?";
                    DialogResult delete = MessageBox.Show(str, "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (delete == DialogResult.Yes)
                    {
                        try
                        {
                            string query = "DELETE FROM Empleados WHERE id_empleado = '" + id + "';";
                            Biblioteca.herramientas(query);
                            showAlert(3, "Usuario Eliminado!", 3);
                            loadColumnsTable();
                        }
                        catch (Exception error)
                        {
                            showAlert(1, error.Message, 5);
                        }
                    }
                }
                else
                {
                    showAlert(1, "Debes seleccionar un empleado.", 5);
                }
            }
            else if(bUserDelete.Text == "Cancelar")
            {
                this.Size = new Size(790, 300);
                bUserAdd.Text = "Agregar";
                bUserDelete.Text = "Eliminar";
                bUserAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
                bUserModify.Enabled = true;
                bUserDelete.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            }
        }
        private void notifCloseBtn_Click(object sender, EventArgs e)
        {
            notifCount = 0;
            notifPanel.Visible = false;
        }
        private void ch2_CheckedChanged(object sender, EventArgs e)
        {
            if(ch2.Checked)
            {
                ch1.Checked = false;
            }
        }
        private void bUserAdd_Click(object sender, EventArgs e)
        {
            if (bUserAdd.Text == "Agregar")
            {
                this.Size = new Size(790, 480);
                bUserAdd.Text = "Guardar";
                bUserDelete.Text = "Cancelar";
                tID.Text = lastID.ToString();
                tNombre.Text = "";
                tApellido.Text = "";
                tUser.Text = "";
                tImagen.Text = "";

                bUserModify.Enabled = false;
                bUserDelete.IconChar = FontAwesome.Sharp.IconChar.Times;

                tPass.Text = generateRPass();
                ch1.Checked = false;
                ch2.Checked = false;
                bUserAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            }
            else if (bUserAdd.Text == "Guardar")
            {
                if (tNombre.Text != "" && tApellido.Text != "" && ch1.Checked || ch2.Checked)
                {
                    try
                    {
                        /*----- [ VARIABLES ] -----*/
                        int id = Convert.ToInt32(tID.Text);
                        string nombre = tNombre.Text;
                        string apellido = tApellido.Text;
                        int rol = 0;
                        if (ch1.Checked) { rol = 1; }
                        else if (ch2.Checked) { rol = 2; }
                        string usuario = tUser.Text;
                        string passw = tPass.Text;
                        string image = tImagen.Text;
                        /*----- [ CONSULTA ] -----*/
                        string sql = "INSERT INTO Empleados VALUES(" + id + ", '" + nombre + "', '" + apellido + "', " + rol + ", '" + usuario + "', '" + passw + "', '" + image + "', 'none');";
                        Biblioteca.herramientas(sql);
                        loadColumnsTable();

                        this.Size = new Size(790, 300);
                        bUserAdd.Text = "Agregar";
                        bUserDelete.Text = "Eliminar";
                        bUserAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
                        bUserModify.Enabled = true;
                        bUserDelete.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
                    }
                    catch (Exception error)
                    {
                        showAlert(1, error.Message, 3);
                        Console.WriteLine("[ERROR]: " + error);
                    }
                }
                else
                {
                    showAlert(1, "Faltan datos por llenar.", 3);
                }
            }
            else if (bUserAdd.Text == "Modificar")
            {
                if (tNombre.Text != "" && tApellido.Text != "" && ch1.Checked || ch2.Checked)
                {
                    try
                    {
                        int id = Convert.ToInt32(tID.Text);
                        string nombre = tNombre.Text;
                        string apellido = tApellido.Text;
                        int rol = 0;
                        if (ch1.Checked) { rol = 1; }
                        else if (ch2.Checked) { rol = 2; }
                        string image = tImagen.Text;

                        empleados.ElementAt(searchIndex(tUser.Text)).setApellido(apellido);
                        empleados.ElementAt(searchIndex(tUser.Text)).setRol(rol);
                        empleados.ElementAt(searchIndex(tUser.Text)).setImage(image);
                        empleados.ElementAt(searchIndex(tUser.Text)).setNombre(nombre);
                        /*----- [ CONSULTA ] -----*/
                        string sql = "UPDATE Empleados SET nombre='" + nombre + "', apellido='" + apellido + "', rol=" + rol + ", image='" + image + "' WHERE id_empleado='" + id + "';";
                        Biblioteca.herramientas(sql);
                        loadColumnsTable();

                        this.Size = new Size(790, 300);
                        bUserAdd.Text = "Agregar";
                        bUserDelete.Text = "Eliminar";
                        bUserAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
                        bUserModify.Enabled = true;
                        bUserDelete.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
                    }
                    catch (Exception error)
                    {
                        showAlert(1, error.Message, 3);
                    }
                }
                else
                {
                    showAlert(1, "Faltan datos por llenar.", 3);
                }
            }
        }
        private void bUserModify_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count > 0)
            {
                if (bUserAdd.Text == "Agregar")
                {
                    this.Size = new Size(790, 480);
                    bUserAdd.Text = "Modificar";
                    bUserDelete.Text = "Cancelar";
                    bUserModify.Enabled = false;
                    bUserDelete.IconChar = FontAwesome.Sharp.IconChar.Times;
                    bUserAdd.IconChar = FontAwesome.Sharp.IconChar.Save;

                    tID.Text = Convert.ToInt32(userTable.SelectedRows[0].Cells["ID"].Value).ToString();
                    tNombre.Text = userTable.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    tApellido.Text = userTable.SelectedRows[0].Cells["Apellido"].Value.ToString();
                    string rName = userTable.SelectedRows[0].Cells["Rol"].Value.ToString();
                    if(rName.Equals("Administrador"))
                    {
                        ch1.Checked = true;
                        ch2.Checked = false;
                    }
                    else
                    {
                        ch2.Checked = true;
                        ch1.Checked = false;
                    }
                    tImagen.Text = empleados.ElementAt(searchIndex(userTable.SelectedRows[0].Cells["Usuario"].Value.ToString())).getImage();
                    tUser.Text = empleados.ElementAt(searchIndex(userTable.SelectedRows[0].Cells["Usuario"].Value.ToString())).getUsuario();
                    tPass.Text = empleados.ElementAt(searchIndex(userTable.SelectedRows[0].Cells["Usuario"].Value.ToString())).getPassword();
                }
            }
        }
    }
}
