
namespace Controlador
{
    partial class inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lFecha = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.lReloj = new System.Windows.Forms.Label();
            this.lNombreT = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.TablaProductos = new System.Windows.Forms.DataGridView();
            this.bDelete = new FontAwesome.Sharp.IconButton();
            this.bModify = new FontAwesome.Sharp.IconButton();
            this.bAdd = new FontAwesome.Sharp.IconButton();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.bCategoria = new FontAwesome.Sharp.IconButton();
            this.bProducto = new FontAwesome.Sharp.IconButton();
            this.tImagen = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.tStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.TextBox();
            this.lblDos = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.tID = new System.Windows.Forms.TextBox();
            this.lblUno = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.mod1 = new System.Windows.Forms.CheckBox();
            this.mod2 = new System.Windows.Forms.CheckBox();
            this.tCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.notifPanel = new System.Windows.Forms.Panel();
            this.notifIcon = new FontAwesome.Sharp.IconPictureBox();
            this.notifCloseBtn = new System.Windows.Forms.Button();
            this.notifLabel = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).BeginInit();
            this.notifPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.lFecha);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.lReloj);
            this.panel1.Controls.Add(this.lNombreT);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.profilePicture);
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 17;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.ForeColor = System.Drawing.Color.White;
            this.lFecha.Location = new System.Drawing.Point(634, 3);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(76, 21);
            this.lFecha.TabIndex = 12;
            this.lFecha.Text = "00 MES 2021";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.Location = new System.Drawing.Point(769, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(31, 34);
            this.bExit.TabIndex = 15;
            this.bExit.Text = "X";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lReloj
            // 
            this.lReloj.AutoSize = true;
            this.lReloj.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReloj.ForeColor = System.Drawing.Color.White;
            this.lReloj.Location = new System.Drawing.Point(612, 13);
            this.lReloj.Name = "lReloj";
            this.lReloj.Size = new System.Drawing.Size(122, 45);
            this.lReloj.TabIndex = 11;
            this.lReloj.Text = "00:00:00";
            // 
            // lNombreT
            // 
            this.lNombreT.AutoSize = true;
            this.lNombreT.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreT.ForeColor = System.Drawing.Color.White;
            this.lNombreT.Location = new System.Drawing.Point(334, 8);
            this.lNombreT.Name = "lNombreT";
            this.lNombreT.Size = new System.Drawing.Size(122, 40);
            this.lNombreT.TabIndex = 10;
            this.lNombreT.Text = "Inventario";
            this.lNombreT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.ForeColor = System.Drawing.Color.White;
            this.lRol.Location = new System.Drawing.Point(70, 29);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(87, 21);
            this.lRol.TabIndex = 9;
            this.lRol.Text = "Administrador";
            // 
            // profilePicture
            // 
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.Location = new System.Drawing.Point(3, 3);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(60, 49);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 8;
            this.profilePicture.TabStop = false;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.White;
            this.lNombre.Location = new System.Drawing.Point(69, 3);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(130, 27);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre Apellido";
            // 
            // TablaProductos
            // 
            this.TablaProductos.AllowUserToAddRows = false;
            this.TablaProductos.AllowUserToDeleteRows = false;
            this.TablaProductos.AllowUserToResizeColumns = false;
            this.TablaProductos.AllowUserToResizeRows = false;
            this.TablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.TablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaProductos.CausesValidation = false;
            this.TablaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaProductos.ColumnHeadersHeight = 30;
            this.TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaProductos.EnableHeadersVisualStyles = false;
            this.TablaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.TablaProductos.Location = new System.Drawing.Point(12, 116);
            this.TablaProductos.MultiSelect = false;
            this.TablaProductos.Name = "TablaProductos";
            this.TablaProductos.ReadOnly = true;
            this.TablaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.TablaProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaProductos.Size = new System.Drawing.Size(776, 167);
            this.TablaProductos.TabIndex = 19;
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.bDelete.Enabled = false;
            this.bDelete.FlatAppearance.BorderSize = 0;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Poppins Light", 0.1F);
            this.bDelete.ForeColor = System.Drawing.Color.White;
            this.bDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.bDelete.IconColor = System.Drawing.Color.White;
            this.bDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bDelete.IconSize = 30;
            this.bDelete.Location = new System.Drawing.Point(527, 301);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(127, 37);
            this.bDelete.TabIndex = 24;
            this.bDelete.Text = "Eliminar";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bModify
            // 
            this.bModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bModify.Enabled = false;
            this.bModify.FlatAppearance.BorderSize = 0;
            this.bModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModify.Font = new System.Drawing.Font("Poppins Light", 0.1F);
            this.bModify.ForeColor = System.Drawing.Color.White;
            this.bModify.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.bModify.IconColor = System.Drawing.Color.White;
            this.bModify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bModify.IconSize = 35;
            this.bModify.Location = new System.Drawing.Point(335, 301);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(127, 37);
            this.bModify.TabIndex = 23;
            this.bModify.Text = "Modificar";
            this.bModify.UseVisualStyleBackColor = false;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.bAdd.Enabled = false;
            this.bAdd.FlatAppearance.BorderSize = 0;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Poppins Light", 0.1F);
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.bAdd.IconColor = System.Drawing.Color.White;
            this.bAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bAdd.IconSize = 35;
            this.bAdd.Location = new System.Drawing.Point(146, 301);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(127, 37);
            this.bAdd.TabIndex = 22;
            this.bAdd.Text = "Agregar";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // bCategoria
            // 
            this.bCategoria.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bCategoria.FlatAppearance.BorderSize = 0;
            this.bCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCategoria.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.bCategoria.ForeColor = System.Drawing.Color.White;
            this.bCategoria.IconChar = FontAwesome.Sharp.IconChar.ThLarge;
            this.bCategoria.IconColor = System.Drawing.Color.White;
            this.bCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCategoria.IconSize = 1;
            this.bCategoria.Location = new System.Drawing.Point(210, 71);
            this.bCategoria.Name = "bCategoria";
            this.bCategoria.Size = new System.Drawing.Size(136, 30);
            this.bCategoria.TabIndex = 25;
            this.bCategoria.Text = "Categorías";
            this.bCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bCategoria.UseVisualStyleBackColor = false;
            this.bCategoria.Click += new System.EventHandler(this.bCategoria_Click);
            // 
            // bProducto
            // 
            this.bProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bProducto.FlatAppearance.BorderSize = 0;
            this.bProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProducto.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.bProducto.ForeColor = System.Drawing.Color.White;
            this.bProducto.IconChar = FontAwesome.Sharp.IconChar.ThLarge;
            this.bProducto.IconColor = System.Drawing.Color.White;
            this.bProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bProducto.IconSize = 1;
            this.bProducto.Location = new System.Drawing.Point(447, 71);
            this.bProducto.Name = "bProducto";
            this.bProducto.Size = new System.Drawing.Size(136, 30);
            this.bProducto.TabIndex = 26;
            this.bProducto.Text = "Productos";
            this.bProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bProducto.UseVisualStyleBackColor = false;
            this.bProducto.Click += new System.EventHandler(this.bProducto_Click);
            // 
            // tImagen
            // 
            this.tImagen.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.tImagen.Location = new System.Drawing.Point(294, 538);
            this.tImagen.Name = "tImagen";
            this.tImagen.Size = new System.Drawing.Size(420, 23);
            this.tImagen.TabIndex = 54;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(106, 535);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(182, 28);
            this.lblImagen.TabIndex = 53;
            this.lblImagen.Text = "Imagen del Producto:";
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.Location = new System.Drawing.Point(444, 468);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(59, 28);
            this.lblModo.TabIndex = 51;
            this.lblModo.Text = "Modo:";
            // 
            // tStock
            // 
            this.tStock.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.tStock.Location = new System.Drawing.Point(566, 417);
            this.tStock.Name = "tStock";
            this.tStock.Size = new System.Drawing.Size(148, 23);
            this.tStock.TabIndex = 50;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(444, 414);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(58, 28);
            this.lblStock.TabIndex = 49;
            this.lblStock.Text = "Stock:";
            // 
            // t3
            // 
            this.t3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.t3.Location = new System.Drawing.Point(203, 473);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(180, 23);
            this.t3.TabIndex = 46;
            // 
            // lblDos
            // 
            this.lblDos.AutoSize = true;
            this.lblDos.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDos.Location = new System.Drawing.Point(33, 470);
            this.lblDos.Name = "lblDos";
            this.lblDos.Size = new System.Drawing.Size(64, 28);
            this.lblDos.TabIndex = 45;
            this.lblDos.Text = "Precio:";
            // 
            // t2
            // 
            this.t2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.t2.Location = new System.Drawing.Point(203, 445);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(180, 23);
            this.t2.TabIndex = 44;
            // 
            // tID
            // 
            this.tID.Enabled = false;
            this.tID.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(203, 417);
            this.tID.Name = "tID";
            this.tID.ReadOnly = true;
            this.tID.Size = new System.Drawing.Size(71, 23);
            this.tID.TabIndex = 43;
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUno.Location = new System.Drawing.Point(33, 442);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(141, 28);
            this.lblUno.TabIndex = 42;
            this.lblUno.Text = "Nombre Opcion:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.lbl_Id.Location = new System.Drawing.Point(33, 414);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(92, 28);
            this.lbl_Id.TabIndex = 41;
            this.lbl_Id.Text = "ID Opcion:";
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(4, 354);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(790, 45);
            this.lblDatos.TabIndex = 40;
            this.lblDatos.Text = "Datos del Producto";
            this.lblDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mod1
            // 
            this.mod1.AutoSize = true;
            this.mod1.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.mod1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mod1.Location = new System.Drawing.Point(548, 464);
            this.mod1.Name = "mod1";
            this.mod1.Size = new System.Drawing.Size(183, 32);
            this.mod1.TabIndex = 55;
            this.mod1.Text = "Mantener Producto";
            this.mod1.UseVisualStyleBackColor = true;
            this.mod1.CheckedChanged += new System.EventHandler(this.mod1_CheckedChanged);
            // 
            // mod2
            // 
            this.mod2.AutoSize = true;
            this.mod2.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.mod2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mod2.Location = new System.Drawing.Point(548, 489);
            this.mod2.Name = "mod2";
            this.mod2.Size = new System.Drawing.Size(167, 32);
            this.mod2.TabIndex = 56;
            this.mod2.Text = "Eliminar sin Stock";
            this.mod2.UseVisualStyleBackColor = true;
            this.mod2.CheckedChanged += new System.EventHandler(this.mod2_CheckedChanged);
            // 
            // tCategoria
            // 
            this.tCategoria.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.tCategoria.Location = new System.Drawing.Point(203, 501);
            this.tCategoria.Name = "tCategoria";
            this.tCategoria.Size = new System.Drawing.Size(180, 23);
            this.tCategoria.TabIndex = 58;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(33, 498);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(115, 28);
            this.lblCategoria.TabIndex = 57;
            this.lblCategoria.Text = "Categoria ID:";
            // 
            // notifPanel
            // 
            this.notifPanel.AutoSize = true;
            this.notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.notifPanel.Controls.Add(this.notifIcon);
            this.notifPanel.Controls.Add(this.notifCloseBtn);
            this.notifPanel.Controls.Add(this.notifLabel);
            this.notifPanel.Location = new System.Drawing.Point(245, 201);
            this.notifPanel.Name = "notifPanel";
            this.notifPanel.Size = new System.Drawing.Size(292, 36);
            this.notifPanel.TabIndex = 59;
            this.notifPanel.Visible = false;
            // 
            // notifIcon
            // 
            this.notifIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.notifIcon.ForeColor = System.Drawing.Color.LimeGreen;
            this.notifIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.notifIcon.IconColor = System.Drawing.Color.LimeGreen;
            this.notifIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.notifIcon.IconSize = 36;
            this.notifIcon.Location = new System.Drawing.Point(8, 1);
            this.notifIcon.Name = "notifIcon";
            this.notifIcon.Size = new System.Drawing.Size(32, 32);
            this.notifIcon.TabIndex = 3;
            this.notifIcon.TabStop = false;
            // 
            // notifCloseBtn
            // 
            this.notifCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.notifCloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.notifCloseBtn.FlatAppearance.BorderSize = 0;
            this.notifCloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.notifCloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.notifCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifCloseBtn.Location = new System.Drawing.Point(262, 0);
            this.notifCloseBtn.Name = "notifCloseBtn";
            this.notifCloseBtn.Size = new System.Drawing.Size(30, 36);
            this.notifCloseBtn.TabIndex = 2;
            this.notifCloseBtn.Text = "x";
            this.notifCloseBtn.UseVisualStyleBackColor = false;
            this.notifCloseBtn.Click += new System.EventHandler(this.notifCloseBtn_Click);
            // 
            // notifLabel
            // 
            this.notifLabel.AutoSize = true;
            this.notifLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifLabel.Location = new System.Drawing.Point(46, 8);
            this.notifLabel.Name = "notifLabel";
            this.notifLabel.Size = new System.Drawing.Size(71, 15);
            this.notifLabel.TabIndex = 0;
            this.notifLabel.Text = "{message}";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(203, 501);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(180, 23);
            this.cbCategoria.TabIndex = 60;
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.notifPanel);
            this.Controls.Add(this.tCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.mod2);
            this.Controls.Add(this.mod1);
            this.Controls.Add(this.tImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.tStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.lblDos);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.lblUno);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.bProducto);
            this.Controls.Add(this.bCategoria);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bModify);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.TablaProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Inventario";
            this.Load += new System.EventHandler(this.inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).EndInit();
            this.notifPanel.ResumeLayout(false);
            this.notifPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lReloj;
        private System.Windows.Forms.Label lNombreT;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView TablaProductos;
        private FontAwesome.Sharp.IconButton bDelete;
        private FontAwesome.Sharp.IconButton bModify;
        private FontAwesome.Sharp.IconButton bAdd;
        private System.Windows.Forms.Timer Clock;
        private FontAwesome.Sharp.IconButton bCategoria;
        private FontAwesome.Sharp.IconButton bProducto;
        private System.Windows.Forms.TextBox tImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.TextBox tStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Label lblDos;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.CheckBox mod1;
        private System.Windows.Forms.CheckBox mod2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel notifPanel;
        private FontAwesome.Sharp.IconPictureBox notifIcon;
        private System.Windows.Forms.Button notifCloseBtn;
        private System.Windows.Forms.Label notifLabel;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox tCategoria;
    }
}