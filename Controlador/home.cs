using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Modelo;
using ControladorDLL;

namespace Controlador
{
    public partial class home : Form
    {
        private int role = 0;
        private int id_user = 0;
        private DataSet usuarios;
        DataSet queryProductos = new DataSet();
        private List<Producto> listaProductos;
        private List<Producto> carrito = new List<Producto>();
        /*---------- VARIABLES MISC ----------*/
        public int notifCount = 7;


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
                    break;
                }
            }
            string nombre = usuarios.Tables[0].Rows[0]["nombre"].ToString().Trim();
            string apellido = usuarios.Tables[0].Rows[0]["apellido"].ToString().Trim();
            lNombre.Text = nombre + " " + apellido;
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
            DialogResult result = MessageBox.Show("Cerrar Sesión", "¿Seguro que desea cerrar sesión?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
            }

        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lReloj.Text = DateTime.Now.ToString("HH:mm"); 
            lFecha.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            hideAlert();
        }
        static string getAbbreviatedName(int month)
        {
            DateTime date = new DateTime(2020, month, 1);

            return date.ToString("MMM");
        }

        private void tCodigo_Enter(object sender, EventArgs e)
        {
            tCodigo.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tCodigo.Text.Length > 0 && tCodigo.Text != "CODIGO PRODUCTO")
            {
                int select = searchProduct(tCodigo.Text);
                if (select != -1)
                {
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
                    PCant.Name = "prod_TCant";
                    PCant.Size = new System.Drawing.Size(53, 22);
                    PCant.TabIndex = 5;
                    PCant.Text = "1";
                    PCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    PLCant.AutoSize = true;
                    PLCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    PLCant.Location = new System.Drawing.Point(295, 14);
                    PLCant.Name = "prod_LCant";
                    PLCant.Size = new System.Drawing.Size(38, 16);
                    PLCant.TabIndex = 4;
                    PLCant.Text = "Cant:";

                    Prod_BRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
                    Prod_BRemove.FlatAppearance.BorderSize = 0;
                    Prod_BRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    Prod_BRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Prod_BRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
                    Prod_BRemove.Location = new System.Drawing.Point(463, 4);
                    Prod_BRemove.Name = "prod_BRemove";
                    Prod_BRemove.Size = new System.Drawing.Size(35, 35);
                    Prod_BRemove.TabIndex = 3;
                    Prod_BRemove.Text = "X";
                    Prod_BRemove.UseVisualStyleBackColor = false;

                    Prod_BAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
                    Prod_BAdd.FlatAppearance.BorderSize = 0;
                    Prod_BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    Prod_BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Prod_BAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(218)))), ((int)(((byte)(105)))));
                    Prod_BAdd.Location = new System.Drawing.Point(422, 4);
                    Prod_BAdd.Name = "prod_BAdd";
                    Prod_BAdd.Size = new System.Drawing.Size(35, 35);
                    Prod_BAdd.TabIndex = 2;
                    Prod_BAdd.Text = "+";
                    Prod_BAdd.UseVisualStyleBackColor = false;
                    Prod_BAdd.Click += delegate { incProductos(PanelProductos.Controls.Count - 1); };

                    Prod_LPrice.AutoSize = true;
                    Prod_LPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Prod_LPrice.Location = new System.Drawing.Point(3, 22);
                    Prod_LPrice.Name = "prod_LPrice";
                    Prod_LPrice.Size = new System.Drawing.Size(38, 15);
                    Prod_LPrice.TabIndex = 1;
                    Prod_LPrice.Text = "$" + listaProductos.ElementAt(select).getPrecio();

                    Prod_LName.AutoSize = true;
                    Prod_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Prod_LName.Location = new System.Drawing.Point(3, 5);
                    Prod_LName.Name = "prod_LName";
                    Prod_LName.Size = new System.Drawing.Size(90, 16);
                    Prod_LName.TabIndex = 0;
                    Prod_LName.Text = listaProductos.ElementAt(select).getNombre();

                    prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(220)))), ((int)(((byte)(102)))));
                    prod.Controls.Add(Prod_LName);
                    prod.Controls.Add(Prod_LPrice);
                    prod.Controls.Add(PCant);
                    prod.Controls.Add(PLCant);
                    prod.Controls.Add(Prod_BAdd);
                    prod.Controls.Add(Prod_BRemove);
                    prod.Location = new System.Drawing.Point(3, 3);
                    prod.Name = "prod";
                    prod.Size = new System.Drawing.Size(508, 44);
                    prod.TabIndex = 11;

                    PanelProductos.Controls.Add(prod);
                    showAlert(3, "Producto añadido al carrito!", 3);
                    Console.WriteLine("Cantidad de Productos añadidos: " + PanelProductos.Controls.Count);
                    updateTotals();
                }
                else
                {
                    showAlert(1, "El producto no se encuentra.", 5);
                }
                tCodigo.Text = "CODIGO PRODUCTO";
            }
            else
            {
                showAlert(1, "Introduzca un código de Producto.", 5);
            }
        }

        public void loadProducts()
        {
            try
            {
                queryProductos = Biblioteca.herramientas("SELECT * FROM Productos");
                listaProductos = new List<Producto>();

                int id, categoria, stock, modo;
                string nombre;
                float precio;

                for (int i = 0; i < queryProductos.Tables[0].Rows.Count; i++)
                {
                    id = Int32.Parse(queryProductos.Tables[0].Rows[i]["id_producto"].ToString().Trim());
                    nombre = queryProductos.Tables[0].Rows[i]["nombre"].ToString().Trim();
                    precio = float.Parse(queryProductos.Tables[0].Rows[i]["precio"].ToString().Trim());
                    categoria = Int32.Parse(queryProductos.Tables[0].Rows[i]["categoria"].ToString().Trim());
                    stock = Int32.Parse(queryProductos.Tables[0].Rows[i]["stock"].ToString().Trim());
                    modo = Int32.Parse(queryProductos.Tables[0].Rows[i]["modo"].ToString().Trim());
                    listaProductos.Add(new Producto(id, nombre, precio, categoria, stock, modo));
                }
                Console.WriteLine("");
                Console.WriteLine("[iPay]: Productos cargados con éxito.");
            }
            catch(Exception error)
            {
                Console.WriteLine("");
                Console.Out.WriteLine("[iPay]: Ocurrió un error al cargar los productos: " + error.Message);
            }
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
            if(type == 1) //Error
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

        private void notifCloseBtn_Click(object sender, EventArgs e)
        {
            notifCount = 0;
            notifPanel.Visible = false;
        }
    
        public void incProductos(int PosProduct)
        {
            int cant = Int32.Parse(PanelProductos.Controls[PosProduct].Controls[2].Text);
            cant++;

            PanelProductos.Controls[PosProduct].Controls[2].Text = cant.ToString();
        }
    
        public void updateTotals()
        {
            double sub = Convert.ToDouble(lSubtotal.Text.Substring(1));
            double total = Convert.ToDouble(lTotal.Text.Substring(1));
            double iva = Convert.ToDouble(lIVA.Text.Substring(1));

            for(int i = 0; i < PanelProductos.Controls.Count; i++)
            {
                sub += Convert.ToDouble(PanelProductos.Controls[i].Controls[1].Text.Substring(1)) * Convert.ToInt32(PanelProductos.Controls[i].Controls[2].Text);
                iva += iva + (sub * 0.16);
                total = sub + iva;
            }

            lSubtotal.Text = "$" + sub.ToString();
            lIVA.Text = "$" + iva.ToString();
            lTotal.Text = "$" + total.ToString();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            PanelProductos.Controls.Clear();
            showAlert(3, "Se ha vacíado el carrito!", 5);
            lSubtotal.Text = "$0.00";
            lIVA.Text = "$0.00";
            lTotal.Text = "$0.00";
        }
    }
}
