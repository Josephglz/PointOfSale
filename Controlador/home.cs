using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Modelo;
using ControladorDLL;
using System.Net;
using System.Drawing;

namespace Controlador
{
    public partial class home : Form
    {
        private int role = 0;
        private int id_user = 0;
        private DataSet usuarios;
        DataSet queryProductos = new DataSet();
        private List<Producto> listaProductos;
        /*---------- VARIABLES MISC ----------*/
        public int notifCount = 7;
        private int totProducts = 0;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        /*---------- CONSTRUCTOR ----------*/
        public home() { }
        public home(int role, int id_user, DataSet user)
        {
            this.role = role;
            this.id_user = id_user;
            this.usuarios = user;
            InitializeComponent();
            loadProducts();
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

                        /*--------- [   ADMIN BUTTONS   ] ----------*/
                        btnUsers.Visible = false;
                        btnReports.Visible = false;
                        break;
                    }
            }
            string nombre = usuarios.Tables[0].Rows[0]["nombre"].ToString().Trim();
            string apellido = usuarios.Tables[0].Rows[0]["apellido"].ToString().Trim();
            string image = usuarios.Tables[0].Rows[0]["image"].ToString().Trim();
            if(!image.Equals("empty"))
            {
                profilePicture.ImageLocation = image;
            }
            string fName = nombre + " " + apellido;
            if(fName.Length > 40)
            {
                lNombre.Text = fName.Substring(0, 40) + ".";
            }
            else
            {
                lNombre.Text = fName;
            }
            AbrirForms<calculadora>();
        }
        /*---------- CONTROLLERS ----------*/
        private void bBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cerrar Sesión", "¿Seguro que desea cerrar sesión?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "UPDATE Empleados SET lastConn = '" + DateTime.Now.ToString("dd/MMM/yyyy") + " - " + DateTime.Now.ToString("HH:mm:ss") + "' WHERE id_empleado = '" + id_user + "';";
                Biblioteca.herramientas(query);
                this.Hide();
            }
        }
        private void clock_Tick(object sender, EventArgs e)
        {
            lReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lFecha.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            hideAlert();
        }
        private void tCodigo_Enter(object sender, EventArgs e)
        {
            tCodigo.Text = "";
        }
        private void tCodigo_Leave(object sender, EventArgs e)
        {
            if (tCodigo.Text == "")
            {
                tCodigo.Text = "CODIGO PRODUCTO";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for (int i = 0; i < PanelProductos.Controls.Count; i++)
            {
                if (btn.Name.Equals(PanelProductos.Controls[i].Controls[4].Name))
                {
                    int cant = Convert.ToInt32(PanelProductos.Controls[i].Controls[2].Text);
                    cant++;
                    PanelProductos.Controls[i].Controls[2].Text = cant.ToString();
                    updateTotals();
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for (int i = 0; i < PanelProductos.Controls.Count; i++)
            {
                if (btn.Name.Equals(PanelProductos.Controls[i].Controls[5].Name))
                {
                    foreach (Control item in PanelProductos.Controls.OfType<Control>().ToList())
                    {
                        if (item.Tag == sender || item == sender)
                        {
                            PanelProductos.Controls.Remove(item);
                        }
                    }
                }
            }
            Console.WriteLine("Total de articulos en carrito: " + PanelProductos.Controls.Count);
            updateTotals();
            clearPreviewProducts();
        }
        private void txtChangeCant(object sender, EventArgs e)
        {
            updateTotals();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddProduct();
        }
        private void btnTrash_Click(object sender, EventArgs e)
        {
            if (PanelProductos.Controls.Count > 0)
            {
                PanelProductos.Controls.Clear();
                showAlert(3, "Se ha vacíado el carrito!", 5);
                lSubtotal.Text = "$0.00";
                lIVA.Text = "$0.00";
                lTotal.Text = "$0.00";
                clearPreviewProducts();
            }
            else
            {
                showAlert(2, "El carrito se encuentra vacío", 5);
            }
        }
        private void home_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void home_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void home_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void notifCloseBtn_Click(object sender, EventArgs e)
        {
            notifCount = 0;
            notifPanel.Visible = false;
        }
        private void tCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AddProduct();
            }
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            clock.Stop();
            users vUsers = new users(id_user, usuarios);
            vUsers.ShowDialog();
            clock.Start();
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            clock.Stop();
            inventario vInventario = new inventario(id_user);
            vInventario.ShowDialog();
            clock.Start();
            loadProducts();
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {

        }
        private void bVender_Click(object sender, EventArgs e)
        {
            if (lTotal.Text != "$0.00")
            {
                clock.Stop();
                venta vVenta = new venta(lNombre.Text, lRol.Text, Convert.ToDouble(lTotal.Text.Substring(1)), profilePicture.ImageLocation);
                DialogResult result = vVenta.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ticket vTicket = new ticket(lFecha.Text, lReloj.Text, lTotal.Text, lSubtotal.Text, lIVA.Text, vVenta.getPago, vVenta.getCambio, lNombre.Text, carrito);
                    vTicket.ShowDialog();
                    UpdateInventory();
                    PanelProductos.Controls.Clear();
                    showAlert(3, "Se ha vacíado el carrito!", 5);
                    lSubtotal.Text = "$0.00";
                    lIVA.Text = "$0.00";
                    lTotal.Text = "$0.00";
                    clearPreviewProducts();
                }
                clock.Start();
            }
            else
            {
                showAlert(1, "El carrito se encuentra vacío.", 3);
            }
        }
        /*---------- LOADERS ----------*/
        public void loadProducts()
        {
            try
            {
                queryProductos = Biblioteca.herramientas("SELECT * FROM Productos");
                listaProductos = new List<Producto>();
                listaProductos.Clear();

                int id, categoria, stock, modo;
                string nombre, image;
                float precio;

                for (int i = 0; i < queryProductos.Tables[0].Rows.Count; i++)
                {
                    id = Int32.Parse(queryProductos.Tables[0].Rows[i]["id_producto"].ToString().Trim());
                    nombre = queryProductos.Tables[0].Rows[i]["nombre"].ToString().Trim();
                    precio = float.Parse(queryProductos.Tables[0].Rows[i]["precio"].ToString().Trim());
                    categoria = Int32.Parse(queryProductos.Tables[0].Rows[i]["categoria"].ToString().Trim());
                    stock = Int32.Parse(queryProductos.Tables[0].Rows[i]["stock"].ToString().Trim());
                    modo = Int32.Parse(queryProductos.Tables[0].Rows[i]["modo"].ToString().Trim());
                    image = queryProductos.Tables[0].Rows[i]["image"].ToString().Trim();
                    listaProductos.Add(new Producto(id, nombre, precio, categoria, stock, modo, image));
                }
                Console.WriteLine("");
                Console.WriteLine("[iPay]: Productos cargados con éxito.");
            }
            catch (Exception error)
            {
                Console.WriteLine("");
                Console.Out.WriteLine("[iPay]: Ocurrió un error al cargar los productos: " + error.Message);
            }
        }
        public void updateTotals()
        {
            double sub = 0.0;
            double iva = 0.0;
            double total = 0.0;
            for (int i = 0; i < PanelProductos.Controls.Count; i++)
            {
                sub += Convert.ToDouble(PanelProductos.Controls[i].Controls[1].Text.Substring(1)) * Convert.ToInt32(PanelProductos.Controls[i].Controls[2].Text);
                iva += (Convert.ToDouble(PanelProductos.Controls[i].Controls[1].Text.Substring(1)) * 0.16) * Convert.ToInt32(PanelProductos.Controls[i].Controls[2].Text);
                total = sub + iva;
            }
            total = Math.Round(total, 2);
            sub = Math.Round(sub, 2);
            iva = Math.Round(iva, 2);
            lSubtotal.Text = "$" + sub;
            lIVA.Text = "$" + iva;
            lTotal.Text = "$" + total;
        }
        /*---------- METHODS ----------*/
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
        public void AddProduct()
        {
            if (tCodigo.Text.Length > 0 && tCodigo.Text != "CODIGO PRODUCTO")
            {
                try
                {
                    int select = searchProduct(tCodigo.Text);
                    if (select != -1)
                    {
                        totProducts++;
                        Panel prod = new Panel();
                        TextBox PCant = new System.Windows.Forms.TextBox();
                        Label PLCant = new System.Windows.Forms.Label();
                        Button Prod_BRemove = new System.Windows.Forms.Button();
                        Button Prod_BAdd = new System.Windows.Forms.Button();
                        Label Prod_LPrice = new System.Windows.Forms.Label();
                        Label Prod_LName = new System.Windows.Forms.Label();

                        PCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
                        PCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        PCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(218)))), ((int)(((byte)(105)))));
                        PCant.Location = new System.Drawing.Point(339, 11);
                        PCant.Name = "prod_TCant_" + totProducts;
                        PCant.Size = new System.Drawing.Size(53, 22);
                        PCant.TabIndex = 5;
                        PCant.Text = "1";
                        PCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        PCant.Leave += new System.EventHandler(this.txtChangeCant);
                        PCant.Tag = Prod_BRemove;

                        PLCant.AutoSize = true;
                        PLCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PLCant.Location = new System.Drawing.Point(295, 14);
                        PLCant.Name = "prod_LCant";
                        PLCant.Size = new System.Drawing.Size(38, 16);
                        PLCant.TabIndex = 4;
                        PLCant.Text = "Cant:";
                        PLCant.Tag = Prod_BRemove;

                        Prod_BRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
                        Prod_BRemove.FlatAppearance.BorderSize = 0;
                        Prod_BRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        Prod_BRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        Prod_BRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
                        Prod_BRemove.Location = new System.Drawing.Point(463, 4);
                        Prod_BRemove.Name = "prod_BRemove_" + totProducts;
                        Prod_BRemove.Size = new System.Drawing.Size(35, 35);
                        Prod_BRemove.TabIndex = 3;
                        Prod_BRemove.Text = "X";
                        Prod_BRemove.UseVisualStyleBackColor = false;
                        Prod_BRemove.Click += new System.EventHandler(this.btnRemove_Click);

                        Prod_BAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
                        Prod_BAdd.FlatAppearance.BorderSize = 0;
                        Prod_BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        Prod_BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        Prod_BAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(218)))), ((int)(((byte)(105)))));
                        Prod_BAdd.Location = new System.Drawing.Point(422, 4);
                        Prod_BAdd.Name = "prod_BAdd_" + totProducts;
                        Prod_BAdd.Size = new System.Drawing.Size(35, 35);
                        Prod_BAdd.TabIndex = 2;
                        Prod_BAdd.Text = "+";
                        Prod_BAdd.UseVisualStyleBackColor = false;
                        Prod_BAdd.Click += new System.EventHandler(this.btnAdd_Click);
                        Prod_BAdd.Tag = Prod_BRemove;

                        Prod_LPrice.AutoSize = true;
                        Prod_LPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        Prod_LPrice.Location = new System.Drawing.Point(3, 22);
                        Prod_LPrice.Name = "prod_LPrice";
                        Prod_LPrice.Size = new System.Drawing.Size(38, 15);
                        Prod_LPrice.TabIndex = 1;
                        Prod_LPrice.Text = "$" + listaProductos.ElementAt(select).getPrecio();
                        Prod_LPrice.Tag = Prod_BRemove;

                        Prod_LName.AutoSize = false;
                        Prod_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        Prod_LName.Location = new System.Drawing.Point(3, 5);
                        Prod_LName.Name = "prod_LName";
                        Prod_LName.Size = new System.Drawing.Size(270, 16);
                        Prod_LName.TabIndex = 0;
                        Prod_LName.Text = listaProductos.ElementAt(select).getNombre();
                        Prod_LName.AutoEllipsis = true;
                        Prod_LName.Tag = Prod_BRemove;

                        prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(220)))), ((int)(((byte)(102)))));
                        prod.Controls.Add(Prod_LName);
                        prod.Controls.Add(Prod_LPrice);
                        prod.Controls.Add(PCant);
                        prod.Controls.Add(PLCant);
                        prod.Controls.Add(Prod_BAdd);
                        prod.Controls.Add(Prod_BRemove);
                        prod.Location = new System.Drawing.Point(3, 3);
                        prod.Name = "prod_" + totProducts;
                        prod.Size = new System.Drawing.Size(508, 44);
                        prod.TabIndex = 11;
                        prod.Tag = Prod_BRemove;
                        prevImage.ImageLocation = "https://c.tenor.com/I6kN-6X7nhAAAAAi/loading-buffering.gif";

                        PanelProductos.Controls.Add(prod);
                        showPreviewProduct(listaProductos.ElementAt(select).getNombre(), listaProductos.ElementAt(select).getPrecio(), listaProductos.ElementAt(select).getImage(), listaProductos.ElementAt(select).getIdProducto(), listaProductos.ElementAt(select).getStock());
                        showAlert(3, "Producto añadido al carrito!", 2);
                        updateTotals();
                        tCodigo.Text = "";
                    }
                    else
                    {
                        showAlert(1, "El producto no se encuentra.", 5);
                        tCodigo.Text = "";
                    }
                }
                catch(Exception error)
                {
                    showAlert(1, error.Message, 5);
                }
            }
            else
            {
                showAlert(1, "Introduzca un código de Producto.", 5);
            }
        }
        static string getAbbreviatedName(int month)
        {
            DateTime date = new DateTime(2020, month, 1);

            return date.ToString("MMM");
        }
        public void showPreviewProduct(string Name, float price, string image, int id, int stock)
        {
            prevImage.ImageLocation = image;
            if (Name.Length > 10)
            {
                prevName.Text = Name.Substring(0, 13) + "...";
            }
            else
            {
                prevName.Text = Name;
            }
            prevCode.Text = "#" + id;
            prevPrice.Text = "$" + price;
            prevCant.Text = "x " + stock;
        }
        public void clearPreviewProducts()
        {
            prevImage.ImageLocation = "";
            prevName.Text = "";
            prevCode.Text = "";
            prevPrice.Text = "";
            prevCant.Text = "";
        }
        public int searchProduct(string codigo)
        {
            for(int i = 0; i < listaProductos.Count; i++)
            {
                if(listaProductos.ElementAt(i).getIdProducto().Equals(Int32.Parse(codigo)))
                {
                    return i;
                }
            }
            return -1;
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
            else if(type == 2) //Info
            {
                notifIcon.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
                notifIcon.ForeColor = System.Drawing.Color.DarkTurquoise;
                notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            }
            else if(type == 3) //approve
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
            if(notifCount <= 0)
            {
                notifPanel.Visible = false;
            }
            else
            {
                notifCount--;
            }
        }
        public void UpdateInventory()
        {

        }
    }
}
