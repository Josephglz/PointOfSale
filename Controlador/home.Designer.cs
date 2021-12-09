
using System.Drawing;

namespace Controlador
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.lNombre = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lFecha = new System.Windows.Forms.Label();
            this.lReloj = new System.Windows.Forms.Label();
            this.lNombreT = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.panelCalculadora = new System.Windows.Forms.Panel();
            this.PanelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.notifPanel = new System.Windows.Forms.Panel();
            this.notifIcon = new FontAwesome.Sharp.IconPictureBox();
            this.notifCloseBtn = new System.Windows.Forms.Button();
            this.notifLabel = new System.Windows.Forms.Label();
            this.panelTotales = new System.Windows.Forms.Panel();
            this.lIVA = new System.Windows.Forms.Label();
            this.lSubtotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.prevPanel = new System.Windows.Forms.Panel();
            this.prevCode = new System.Windows.Forms.Label();
            this.prevPrice = new System.Windows.Forms.Label();
            this.prevName = new System.Windows.Forms.Label();
            this.prevCant = new System.Windows.Forms.Label();
            this.prevImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.btnInventory = new FontAwesome.Sharp.IconButton();
            this.btnTicket = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnTrash = new FontAwesome.Sharp.IconButton();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.bVender = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.notifPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).BeginInit();
            this.panelTotales.SuspendLayout();
            this.prevPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bBack.FlatAppearance.BorderSize = 0;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.White;
            this.bBack.Location = new System.Drawing.Point(953, 0);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(67, 28);
            this.bBack.TabIndex = 7;
            this.bBack.Text = "Volver";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.lFecha);
            this.panel1.Controls.Add(this.lReloj);
            this.panel1.Controls.Add(this.lNombreT);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.profilePicture);
            this.panel1.Controls.Add(this.bBack);
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 55);
            this.panel1.TabIndex = 8;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.ForeColor = System.Drawing.Color.White;
            this.lFecha.Location = new System.Drawing.Point(847, 3);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(76, 21);
            this.lFecha.TabIndex = 12;
            this.lFecha.Text = "00 MES 2021";
            // 
            // lReloj
            // 
            this.lReloj.AutoSize = true;
            this.lReloj.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReloj.ForeColor = System.Drawing.Color.White;
            this.lReloj.Location = new System.Drawing.Point(825, 13);
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
            this.lNombreT.Location = new System.Drawing.Point(417, 3);
            this.lNombreT.Name = "lNombreT";
            this.lNombreT.Size = new System.Drawing.Size(176, 40);
            this.lNombreT.TabIndex = 10;
            this.lNombreT.Text = "Punto de Venta";
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
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // panelCalculadora
            // 
            this.panelCalculadora.Location = new System.Drawing.Point(12, 278);
            this.panelCalculadora.Name = "panelCalculadora";
            this.panelCalculadora.Size = new System.Drawing.Size(250, 240);
            this.panelCalculadora.TabIndex = 9;
            // 
            // PanelProductos
            // 
            this.PanelProductos.AutoScroll = true;
            this.PanelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.PanelProductos.Location = new System.Drawing.Point(277, 101);
            this.PanelProductos.Name = "PanelProductos";
            this.PanelProductos.Size = new System.Drawing.Size(518, 349);
            this.PanelProductos.TabIndex = 11;
            // 
            // tCodigo
            // 
            this.tCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.tCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(157)))));
            this.tCodigo.Location = new System.Drawing.Point(277, 64);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.Size = new System.Drawing.Size(437, 31);
            this.tCodigo.TabIndex = 12;
            this.tCodigo.Text = "CODIGO PRODUCTO";
            this.tCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tCodigo.Enter += new System.EventHandler(this.tCodigo_Enter);
            this.tCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tCodigo_KeyPress);
            this.tCodigo.Leave += new System.EventHandler(this.tCodigo_Leave);
            // 
            // notifPanel
            // 
            this.notifPanel.AutoSize = true;
            this.notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.notifPanel.Controls.Add(this.notifIcon);
            this.notifPanel.Controls.Add(this.notifCloseBtn);
            this.notifPanel.Controls.Add(this.notifLabel);
            this.notifPanel.Location = new System.Drawing.Point(384, 264);
            this.notifPanel.Name = "notifPanel";
            this.notifPanel.Size = new System.Drawing.Size(310, 36);
            this.notifPanel.TabIndex = 15;
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
            this.notifCloseBtn.Location = new System.Drawing.Point(280, 0);
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
            this.notifLabel.Size = new System.Drawing.Size(189, 15);
            this.notifLabel.TabIndex = 0;
            this.notifLabel.Text = "No se encontró el producto.";
            // 
            // panelTotales
            // 
            this.panelTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panelTotales.Controls.Add(this.lIVA);
            this.panelTotales.Controls.Add(this.lSubtotal);
            this.panelTotales.Controls.Add(this.lblIVA);
            this.panelTotales.Controls.Add(this.lblSubtotal);
            this.panelTotales.Controls.Add(this.lTotal);
            this.panelTotales.Controls.Add(this.lblTotal);
            this.panelTotales.Location = new System.Drawing.Point(277, 456);
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Size = new System.Drawing.Size(518, 62);
            this.panelTotales.TabIndex = 16;
            // 
            // lIVA
            // 
            this.lIVA.AutoSize = true;
            this.lIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIVA.Location = new System.Drawing.Point(377, 33);
            this.lIVA.Name = "lIVA";
            this.lIVA.Size = new System.Drawing.Size(43, 15);
            this.lIVA.TabIndex = 5;
            this.lIVA.Text = "$0.00";
            // 
            // lSubtotal
            // 
            this.lSubtotal.AutoSize = true;
            this.lSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubtotal.Location = new System.Drawing.Point(377, 14);
            this.lSubtotal.Name = "lSubtotal";
            this.lSubtotal.Size = new System.Drawing.Size(43, 15);
            this.lSubtotal.TabIndex = 4;
            this.lSubtotal.Text = "$0.00";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(294, 33);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(63, 15);
            this.lblIVA.TabIndex = 3;
            this.lblIVA.Text = "IVA 16%:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(294, 14);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 15);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(1, 21);
            this.lTotal.Name = "lTotal";
            this.lTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lTotal.Size = new System.Drawing.Size(108, 39);
            this.lTotal.TabIndex = 1;
            this.lTotal.Text = "$0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(5, 5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 16);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "TOTAL";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(67)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 30;
            this.btnAgregar.Location = new System.Drawing.Point(720, 64);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(75, 31);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // prevPanel
            // 
            this.prevPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.prevPanel.Controls.Add(this.prevCode);
            this.prevPanel.Controls.Add(this.prevPrice);
            this.prevPanel.Controls.Add(this.prevName);
            this.prevPanel.Controls.Add(this.prevCant);
            this.prevPanel.Controls.Add(this.prevImage);
            this.prevPanel.Location = new System.Drawing.Point(12, 64);
            this.prevPanel.Name = "prevPanel";
            this.prevPanel.Size = new System.Drawing.Size(250, 197);
            this.prevPanel.TabIndex = 24;
            // 
            // prevCode
            // 
            this.prevCode.AutoSize = true;
            this.prevCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(157)))));
            this.prevCode.Location = new System.Drawing.Point(7, 146);
            this.prevCode.Name = "prevCode";
            this.prevCode.Size = new System.Drawing.Size(0, 13);
            this.prevCode.TabIndex = 4;
            // 
            // prevPrice
            // 
            this.prevPrice.AutoSize = true;
            this.prevPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPrice.Location = new System.Drawing.Point(5, 166);
            this.prevPrice.Name = "prevPrice";
            this.prevPrice.Size = new System.Drawing.Size(0, 29);
            this.prevPrice.TabIndex = 3;
            // 
            // prevName
            // 
            this.prevName.AutoSize = true;
            this.prevName.BackColor = System.Drawing.Color.Transparent;
            this.prevName.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.prevName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.prevName.Location = new System.Drawing.Point(3, 114);
            this.prevName.Name = "prevName";
            this.prevName.Size = new System.Drawing.Size(0, 40);
            this.prevName.TabIndex = 2;
            // 
            // prevCant
            // 
            this.prevCant.AutoSize = true;
            this.prevCant.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(157)))));
            this.prevCant.Location = new System.Drawing.Point(151, 37);
            this.prevCant.Name = "prevCant";
            this.prevCant.Size = new System.Drawing.Size(0, 49);
            this.prevCant.TabIndex = 1;
            // 
            // prevImage
            // 
            this.prevImage.ErrorImage = null;
            this.prevImage.ImageLocation = "";
            this.prevImage.InitialImage = null;
            this.prevImage.Location = new System.Drawing.Point(3, 3);
            this.prevImage.Name = "prevImage";
            this.prevImage.Size = new System.Drawing.Size(109, 107);
            this.prevImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prevImage.TabIndex = 0;
            this.prevImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.flowLayoutPanel1.Controls.Add(this.btnUsers);
            this.flowLayoutPanel1.Controls.Add(this.btnInventory);
            this.flowLayoutPanel1.Controls.Add(this.btnTicket);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnTrash);
            this.flowLayoutPanel1.Controls.Add(this.btnReports);
            this.flowLayoutPanel1.Controls.Add(this.bVender);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(803, 307);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(207, 210);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.IconSize = 36;
            this.btnUsers.Location = new System.Drawing.Point(8, 5);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(8, 5, 10, 5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(51, 45);
            this.btnUsers.TabIndex = 23;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnInventory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.btnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventory.IconSize = 36;
            this.btnInventory.Location = new System.Drawing.Point(77, 5);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(8, 5, 10, 5);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(51, 45);
            this.btnInventory.TabIndex = 24;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnTicket.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.btnTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTicket.IconSize = 36;
            this.btnTicket.Location = new System.Drawing.Point(146, 5);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(8, 5, 10, 5);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(51, 45);
            this.btnTicket.TabIndex = 27;
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 36;
            this.btnSearch.Location = new System.Drawing.Point(8, 60);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 5, 10, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 45);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnTrash
            // 
            this.btnTrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnTrash.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.btnTrash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrash.IconSize = 36;
            this.btnTrash.Location = new System.Drawing.Point(77, 60);
            this.btnTrash.Margin = new System.Windows.Forms.Padding(8, 5, 10, 5);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(51, 45);
            this.btnTrash.TabIndex = 25;
            this.btnTrash.UseVisualStyleBackColor = false;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnReports.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 36;
            this.btnReports.Location = new System.Drawing.Point(146, 60);
            this.btnReports.Margin = new System.Windows.Forms.Padding(8, 5, 10, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(51, 45);
            this.btnReports.TabIndex = 29;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // bVender
            // 
            this.bVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.bVender.FlatAppearance.BorderSize = 0;
            this.bVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVender.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.bVender.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.bVender.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.bVender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVender.IconSize = 36;
            this.bVender.Location = new System.Drawing.Point(10, 150);
            this.bVender.Margin = new System.Windows.Forms.Padding(10, 40, 3, 3);
            this.bVender.Name = "bVender";
            this.bVender.Size = new System.Drawing.Size(184, 45);
            this.bVender.TabIndex = 28;
            this.bVender.Text = "VENDER";
            this.bVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bVender.UseVisualStyleBackColor = false;
            this.bVender.Click += new System.EventHandler(this.bVender_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1020, 551);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.prevPanel);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelTotales);
            this.Controls.Add(this.notifPanel);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.PanelProductos);
            this.Controls.Add(this.panelCalculadora);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta";
            this.Load += new System.EventHandler(this.home_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.home_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.home_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.home_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.notifPanel.ResumeLayout(false);
            this.notifPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).EndInit();
            this.panelTotales.ResumeLayout(false);
            this.panelTotales.PerformLayout();
            this.prevPanel.ResumeLayout(false);
            this.prevPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lReloj;
        private System.Windows.Forms.Label lNombreT;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Panel panelCalculadora;
        private System.Windows.Forms.FlowLayoutPanel PanelProductos;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.Panel notifPanel;
        private System.Windows.Forms.Label notifLabel;
        private System.Windows.Forms.Button notifCloseBtn;
        private System.Windows.Forms.Panel panelTotales;
        private System.Windows.Forms.Label lIVA;
        private System.Windows.Forms.Label lSubtotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lblTotal;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconPictureBox notifIcon;
        private System.Windows.Forms.Panel prevPanel;
        private System.Windows.Forms.Label prevCode;
        private System.Windows.Forms.Label prevPrice;
        private System.Windows.Forms.Label prevName;
        private System.Windows.Forms.Label prevCant;
        private System.Windows.Forms.PictureBox prevImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnTicket;
        private FontAwesome.Sharp.IconButton btnTrash;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnInventory;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton bVender;
    }
}