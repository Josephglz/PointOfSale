using ControladorDLL;
using Modelo;
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
    public partial class inventario : Form
    {
        private int id_user, lastIDc, lastIDp, notifCount;
        private int opc = 1;
        private DataTable tableModel = new DataTable();
        List<Producto> listaProductos = new List<Producto>();
        List<Categoria> listaCategoria = new List<Categoria>();
        /*===============   [   LOADERS   ]   ===============*/
        public inventario(int id_user)
        {
            this.id_user = id_user;
            InitializeComponent();
        }
        private void inventario_Load(object sender, EventArgs e)
        {
            DataSet user = new DataSet();
            string sql = string.Format("SELECT * FROM Empleados WHERE id_empleado='" + id_user + "';");
            user = Biblioteca.herramientas(sql);
            this.Size = new Size(800, 350);
            string nombre = user.Tables[0].Rows[0]["nombre"].ToString().Trim();
            string apellido = user.Tables[0].Rows[0]["apellido"].ToString().Trim();
            string image = user.Tables[0].Rows[0]["image"].ToString().Trim();
            if (!image.Equals("empty"))
            {
                profilePicture.ImageLocation = image;
            }
            lNombre.Text = nombre + " " + apellido;
            loadCategorias();
        }
        public void loadColumnsTable(int opcion)
        {
            tableModel.Rows.Clear();
            tableModel.Columns.Clear();

            if (opcion == 1)//Productos
            {
                tableModel.Columns.Add("ID");
                tableModel.Columns.Add("Producto");
                tableModel.Columns.Add("Precio");
                tableModel.Columns.Add("Categoría");
                tableModel.Columns.Add("Stock");
                opc = 1;
                loadRowsTable(1);

            }
            else if(opcion == 2)//Categorías
            {
                tableModel.Columns.Add("ID");
                tableModel.Columns.Add("Categoría");
                tableModel.Columns.Add("ID Padre");
                opc = 2;
                loadRowsTable(2);
            }

            TablaProductos.DataSource = tableModel;
            bAdd.Enabled = true;
            bModify.Enabled = true;
            bDelete.Enabled = true;
        }
        public void loadRowsTable(int type)
        {
            if(type == 1)//Productos
            {
                loadProductos();
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    tableModel.Rows.Add(listaProductos.ElementAt(i).getIdProducto(), listaProductos.ElementAt(i).getNombre(), listaProductos.ElementAt(i).getPrecio(), listaProductos.ElementAt(i).getCategoria(), listaProductos.ElementAt(i).getStock());
                }
            }
            else if(type == 2)//Categorias
            {
                loadCategorias();
                for (int i = 0; i < listaCategoria.Count; i++)
                {
                    tableModel.Rows.Add(listaCategoria.ElementAt(i).getIdCategoria(), listaCategoria.ElementAt(i).getCategoria(), listaCategoria.ElementAt(i).getIdParent());
                }
            }
        }
        public void loadProductos()
        {
            DataSet productos = new DataSet();
            listaProductos.Clear();
            productos = Biblioteca.herramientas("SELECT * FROM Productos");
            string nombre, imagen;
            int id, categoria, stock, modo;
            float precio;

            for (int i = 0; i < productos.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(productos.Tables[0].Rows[i]["id_producto"].ToString().Trim());
                nombre = productos.Tables[0].Rows[i]["nombre"].ToString().Trim();
                precio = float.Parse(productos.Tables[0].Rows[i]["precio"].ToString().Trim());
                categoria = Convert.ToInt32(productos.Tables[0].Rows[i]["categoria"].ToString().Trim());
                stock = Convert.ToInt32(productos.Tables[0].Rows[i]["stock"].ToString().Trim());
                modo = Convert.ToInt32(productos.Tables[0].Rows[i]["modo"].ToString().Trim());
                imagen = productos.Tables[0].Rows[i]["image"].ToString().Trim();

                listaProductos.Add(new Producto(id, nombre, precio, categoria, stock, modo, imagen));
                lastIDp = id + 1;
            }
        }
        public void loadCategorias()
        {
            DataSet categorias = new DataSet();
            listaCategoria.Clear();
            cbCategoria.Items.Clear();
            categorias = Biblioteca.herramientas("SELECT * FROM Categorias");
            string categoria;
            int id, idparent;

            for (int i = 0; i < categorias.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(categorias.Tables[0].Rows[i]["id_categoria"].ToString().Trim());
                categoria = categorias.Tables[0].Rows[i]["categoria"].ToString().Trim();
                idparent = Convert.ToInt32(categorias.Tables[0].Rows[i]["id_catparent"].ToString().Trim());

                listaCategoria.Add(new Categoria(id, categoria, idparent));
                lastIDc = id + 1;
                cbCategoria.Items.Add(categoria);
            }
        }
        /*===============   [   METHODS   ]   ===============*/
        public void showFields(int opcion)
        {
            tID.Text = "";
            t2.Text = "";
            t3.Text = "";
            tImagen.Text = "";
            tStock.Text = "";
            mod1.Checked = false;
            mod2.Checked = false;
            if(opcion == 1) //Productos
            {
                lblImagen.Visible = true;
                lblModo.Visible = true;
                lblStock.Visible = true;
                tImagen.Visible = true;
                tStock.Visible = true;
                lblCategoria.Visible = true;
                tCategoria.Visible = false;
                mod1.Visible = true;
                mod2.Visible = true;
                cbCategoria.SelectedIndex = 0;
                cbCategoria.Visible = true;
                tID.Text = lastIDp.ToString();
                lbl_Id.Text = "ID Producto:";
                lblUno.Text = "Nombre Producto:";
                lblDos.Text = "Precio:";
                lblCategoria.Text = "Categoría:";
                lblDatos.Text = "Datos del Producto";
            }
            else if(opcion == 2)//Categoria
            {
                lblImagen.Visible = false;
                lblModo.Visible = false;
                lblStock.Visible = false;
                tImagen.Visible = false;
                tStock.Visible = false;
                mod1.Visible = false;
                mod2.Visible = false;
                lblCategoria.Visible = false;
                tCategoria.Visible = false;
                cbCategoria.Visible = false;
                tID.Text = lastIDc.ToString();
                lbl_Id.Text = "ID Categoria:";
                lblUno.Text = "Nombre Categoria:";
                lblDos.Text = "ID Cat. Padre: ";
                lblDatos.Text = "Datos de la Categoría";
            }
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
        public int getIDCategory()
        {
            for(int i = 0; i < listaCategoria.Count; i++)
            {
                if(cbCategoria.SelectedItem.ToString().Equals(listaCategoria.ElementAt(i).getCategoria()))
                {
                    return i;
                }
            }
            return 0;
        }
        /*===============   [   CONTROLLERS   ]   ===============*/
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void bProducto_Click(object sender, EventArgs e)
        {
            loadColumnsTable(1);
            opc = 1;
            bProducto.BackColor = Color.Teal;
            bCategoria.BackColor = Color.LightSeaGreen;
        }
        private void notifCloseBtn_Click(object sender, EventArgs e)
        {
            notifCount = 0;
            notifPanel.Visible = false;
        }
        private void mod1_CheckedChanged(object sender, EventArgs e)
        {
            if (mod1.Checked)
            {
                mod2.Checked = false;
            }
        }
        private void mod2_CheckedChanged(object sender, EventArgs e)
        {
            if (mod2.Checked)
            {
                mod2.Checked = false;
            }
        }
        private void bDelete_Click(object sender, EventArgs e)
        {
            if (bDelete.Text == "Eliminar")
            {
                if(TablaProductos.SelectedRows.Count > 0)
                {
                    string str;
                    int id = Convert.ToInt32(TablaProductos.SelectedRows[0].Cells["ID"].Value);
                    if(opc == 1) //Productos
                    {
                        str = "ID: " + id +
                            "\nNombre: " + listaProductos.ElementAt(id - 1).getNombre() +
                            "\nCategoria: " + listaCategoria.ElementAt(listaProductos.ElementAt(id - 1).getCategoria()).getCategoria() +
                            "\n\n¿Desea eliminar este Producto?";

                        DialogResult delete = MessageBox.Show(str, "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(delete == DialogResult.Yes)
                        {
                            try
                            {
                                string query = "DELETE FROM Productos WHERE id_producto = '" + id + "';";
                                Biblioteca.herramientas(query);
                                showAlert(3, "Producto Eliminado", 3);
                                loadColumnsTable(1);
                            }
                            catch(Exception error)
                            {
                                showAlert(1, error.Message, 5);
                            }
                        }
                    }
                    else if(opc == 2) //Categorias
                    {
                        str = "ID: " + id +
                            "\nCategoria: " + listaCategoria.ElementAt(id - 1).getCategoria() +
                            "\n\n¿Desea eliminar esta Categoria?";

                        DialogResult delete = MessageBox.Show(str, "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (delete == DialogResult.Yes)
                        {
                            try
                            {
                                string query = "DELETE FROM Categorias WHERE id_categoria = '" + id + "';";
                                Biblioteca.herramientas(query);
                                showAlert(3, "Categoría Eliminada", 3);
                                loadColumnsTable(2);
                            }
                            catch (Exception error)
                            {
                                showAlert(1, error.Message, 5);
                            }
                        }
                    }
                }
                else
                {
                    showAlert(1, "Debes seleccionar un elemento.", 3);
                }
            }
            else if (bDelete.Text == "Cancelar")
            {
                this.Size = new Size(800, 350);
                bAdd.Text = "Agregar";
                bDelete.Text = "Eliminar";
                bModify.Enabled = true;
                bDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
                bAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            }
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            lReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lFecha.Text = DateTime.Now.ToString("dd/MMM/yyyy");
        }
        private void bCategoria_Click(object sender, EventArgs e)
        {
            loadColumnsTable(2);
            opc = 2;
            bCategoria.BackColor = Color.Teal;
            bProducto.BackColor = Color.LightSeaGreen;
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (opc == 1)
            {
                this.Size = new Size(800, 575);
            }
            else if (opc == 2)
            {
                this.Size = new Size(800, 500);
            }
            ///////////////////////////////////////////////////////////////////////////
            if(bAdd.Text == "Agregar")
            {
                showFields(opc);
                bAdd.Text = "Guardar";
                bDelete.Text = "Cancelar";
                bModify.Enabled = false;
                bDelete.IconChar = FontAwesome.Sharp.IconChar.Times;
            }
            else if(bAdd.Text == "Guardar")
            {
                if(opc == 1)
                {
                    if (t2.Text != "" && t3.Text != "" && tImagen.Text != "" && tStock.Text != "" && mod1.Checked || mod2.Checked)
                    {
                        try
                        {
                            int id = Convert.ToInt32(tID.Text);
                            string nombre = t2.Text;
                            float precio = float.Parse(t3.Text);
                            int categoria = getIDCategory();
                            int stock = Convert.ToInt32(tStock.Text);
                            int modo = 0;
                            if (mod1.Checked) { modo = 1; }
                            else if (mod2.Checked) { modo = 2; }
                            string imagen = tImagen.Text;

                            string sql = "INSERT INTO Productos VALUES(" + id + ", '" + nombre + "', " + precio + ", " + categoria + ", " + stock + ", " + modo + ", '" + imagen + "');";
                            Biblioteca.herramientas(sql);
                            loadColumnsTable(1);

                            this.Size = new Size(800, 350);
                            bAdd.Text = "Agregar";
                            bDelete.Text = "Eliminar";
                            bAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
                            bModify.Enabled = true;
                            bDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
                            showAlert(3, "Producto añadido al Inventario.", 3);
                        }
                        catch (Exception error)
                        {
                            showAlert(1, error.Message, 3);
                            Console.WriteLine("[ERROR]: " + error);
                        }
                    }
                }
                else if(opc == 2)
                {
                    if(t2.Text != "" && t3.Text != "")
                    {
                        try
                        {
                            int id = Convert.ToInt32(tID.Text);
                            string categoria = t2.Text;
                            int idparent = Convert.ToInt32(t3.Text);

                            string sql = "INSERT INTO Categorias VALUES(" + id + ", '" + categoria + "', " + idparent + ");";
                            Biblioteca.herramientas(sql);
                            loadColumnsTable(2);

                            this.Size = new Size(800, 350);
                            bAdd.Text = "Agregar";
                            bDelete.Text = "Eliminar";
                            bAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
                            bModify.Enabled = true;
                            bDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
                        }
                        catch (Exception error)
                        {
                            showAlert(1, error.Message, 3);
                            Console.WriteLine("[ERROR]: " + error);
                        }
                    }
                }
            }
        }
    }
}
