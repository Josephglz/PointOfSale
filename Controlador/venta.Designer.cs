
namespace Controlador
{
    partial class venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(venta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lRol = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.bBack = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lNombreT = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tPago = new System.Windows.Forms.TextBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lbl_Pesos = new System.Windows.Forms.Label();
            this.lFormaPago = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bCredit = new FontAwesome.Sharp.IconButton();
            this.bCash = new FontAwesome.Sharp.IconButton();
            this.bCard = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tCambio = new System.Windows.Forms.TextBox();
            this.lbl_CAMBIO = new System.Windows.Forms.Label();
            this.tTotal = new System.Windows.Forms.TextBox();
            this.lbl_TOTAL = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.notifPanel = new System.Windows.Forms.Panel();
            this.notifIcon = new FontAwesome.Sharp.IconPictureBox();
            this.notifCloseBtn = new System.Windows.Forms.Button();
            this.notifLabel = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.bPrint = new FontAwesome.Sharp.IconButton();
            this.bCobrar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.notifPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.profilePicture);
            this.panel1.Controls.Add(this.bBack);
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 55);
            this.panel1.TabIndex = 9;
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
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bBack.FlatAppearance.BorderSize = 0;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.White;
            this.bBack.Location = new System.Drawing.Point(491, 0);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(67, 28);
            this.bBack.TabIndex = 7;
            this.bBack.Text = "Volver";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
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
            // lNombreT
            // 
            this.lNombreT.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lNombreT.Location = new System.Drawing.Point(0, 55);
            this.lNombreT.Name = "lNombreT";
            this.lNombreT.Size = new System.Drawing.Size(558, 60);
            this.lNombreT.TabIndex = 10;
            this.lNombreT.Text = "Generar Venta";
            this.lNombreT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.tPago);
            this.panel2.Controls.Add(this.lblFormaPago);
            this.panel2.Controls.Add(this.lbl_Pesos);
            this.panel2.Controls.Add(this.lFormaPago);
            this.panel2.Location = new System.Drawing.Point(12, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 138);
            this.panel2.TabIndex = 28;
            // 
            // tPago
            // 
            this.tPago.Enabled = false;
            this.tPago.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPago.Location = new System.Drawing.Point(99, 85);
            this.tPago.Name = "tPago";
            this.tPago.Size = new System.Drawing.Size(109, 30);
            this.tPago.TabIndex = 30;
            this.tPago.Text = "$0.00";
            this.tPago.Enter += new System.EventHandler(this.tPago_Enter);
            this.tPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPago_KeyPress);
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.BackColor = System.Drawing.Color.Transparent;
            this.lblFormaPago.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFormaPago.Location = new System.Drawing.Point(0, 0);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(244, 34);
            this.lblFormaPago.TabIndex = 27;
            this.lblFormaPago.Text = "FORMA DE PAGO";
            this.lblFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Pesos
            // 
            this.lbl_Pesos.AutoSize = true;
            this.lbl_Pesos.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Pesos.Location = new System.Drawing.Point(28, 79);
            this.lbl_Pesos.Name = "lbl_Pesos";
            this.lbl_Pesos.Size = new System.Drawing.Size(65, 32);
            this.lbl_Pesos.TabIndex = 29;
            this.lbl_Pesos.Text = "Pesos:";
            // 
            // lFormaPago
            // 
            this.lFormaPago.BackColor = System.Drawing.Color.Transparent;
            this.lFormaPago.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(67)))));
            this.lFormaPago.Location = new System.Drawing.Point(0, 32);
            this.lFormaPago.Name = "lFormaPago";
            this.lFormaPago.Size = new System.Drawing.Size(244, 34);
            this.lFormaPago.TabIndex = 28;
            this.lFormaPago.Text = "SELECCIONAR";
            this.lFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.bCredit);
            this.panel3.Controls.Add(this.bCash);
            this.panel3.Controls.Add(this.bCard);
            this.panel3.Location = new System.Drawing.Point(30, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 71);
            this.panel3.TabIndex = 31;
            // 
            // bCredit
            // 
            this.bCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.bCredit.FlatAppearance.BorderSize = 0;
            this.bCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCredit.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.bCredit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(67)))));
            this.bCredit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCredit.IconSize = 50;
            this.bCredit.Location = new System.Drawing.Point(314, 10);
            this.bCredit.Name = "bCredit";
            this.bCredit.Size = new System.Drawing.Size(55, 52);
            this.bCredit.TabIndex = 2;
            this.bCredit.UseVisualStyleBackColor = false;
            this.bCredit.Click += new System.EventHandler(this.bCredit_Click);
            // 
            // bCash
            // 
            this.bCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.bCash.FlatAppearance.BorderSize = 0;
            this.bCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCash.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.bCash.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(67)))));
            this.bCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCash.IconSize = 50;
            this.bCash.Location = new System.Drawing.Point(223, 10);
            this.bCash.Name = "bCash";
            this.bCash.Size = new System.Drawing.Size(55, 52);
            this.bCash.TabIndex = 1;
            this.bCash.UseVisualStyleBackColor = false;
            this.bCash.Click += new System.EventHandler(this.bCash_Click);
            // 
            // bCard
            // 
            this.bCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.bCard.FlatAppearance.BorderSize = 0;
            this.bCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCard.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.bCard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(67)))));
            this.bCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCard.IconSize = 45;
            this.bCard.Location = new System.Drawing.Point(134, 10);
            this.bCard.Name = "bCard";
            this.bCard.Size = new System.Drawing.Size(55, 52);
            this.bCard.TabIndex = 0;
            this.bCard.UseVisualStyleBackColor = false;
            this.bCard.Click += new System.EventHandler(this.bCard_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel4.Controls.Add(this.tCambio);
            this.panel4.Controls.Add(this.lbl_CAMBIO);
            this.panel4.Controls.Add(this.tTotal);
            this.panel4.Controls.Add(this.lbl_TOTAL);
            this.panel4.Location = new System.Drawing.Point(280, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 138);
            this.panel4.TabIndex = 31;
            // 
            // tCambio
            // 
            this.tCambio.Enabled = false;
            this.tCambio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCambio.Location = new System.Drawing.Point(37, 100);
            this.tCambio.Name = "tCambio";
            this.tCambio.ReadOnly = true;
            this.tCambio.Size = new System.Drawing.Size(195, 30);
            this.tCambio.TabIndex = 32;
            this.tCambio.Text = "$0.00";
            // 
            // lbl_CAMBIO
            // 
            this.lbl_CAMBIO.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CAMBIO.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CAMBIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_CAMBIO.Location = new System.Drawing.Point(0, 63);
            this.lbl_CAMBIO.Name = "lbl_CAMBIO";
            this.lbl_CAMBIO.Size = new System.Drawing.Size(266, 34);
            this.lbl_CAMBIO.TabIndex = 31;
            this.lbl_CAMBIO.Text = "CAMBIO";
            this.lbl_CAMBIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tTotal
            // 
            this.tTotal.Enabled = false;
            this.tTotal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTotal.Location = new System.Drawing.Point(37, 37);
            this.tTotal.Name = "tTotal";
            this.tTotal.ReadOnly = true;
            this.tTotal.Size = new System.Drawing.Size(195, 30);
            this.tTotal.TabIndex = 30;
            this.tTotal.Text = "$0.00";
            // 
            // lbl_TOTAL
            // 
            this.lbl_TOTAL.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TOTAL.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TOTAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TOTAL.Location = new System.Drawing.Point(0, 0);
            this.lbl_TOTAL.Name = "lbl_TOTAL";
            this.lbl_TOTAL.Size = new System.Drawing.Size(266, 34);
            this.lbl_TOTAL.TabIndex = 27;
            this.lbl_TOTAL.Text = "TOTAL";
            this.lbl_TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bCancelar.FlatAppearance.BorderSize = 0;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(131, 384);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 35);
            this.bCancelar.TabIndex = 10;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // notifPanel
            // 
            this.notifPanel.AutoSize = true;
            this.notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.notifPanel.Controls.Add(this.notifIcon);
            this.notifPanel.Controls.Add(this.notifCloseBtn);
            this.notifPanel.Controls.Add(this.notifLabel);
            this.notifPanel.Location = new System.Drawing.Point(122, 184);
            this.notifPanel.Name = "notifPanel";
            this.notifPanel.Size = new System.Drawing.Size(310, 49);
            this.notifPanel.TabIndex = 40;
            this.notifPanel.Visible = false;
            // 
            // notifIcon
            // 
            this.notifIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.notifIcon.ForeColor = System.Drawing.Color.LimeGreen;
            this.notifIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.notifIcon.IconColor = System.Drawing.Color.LimeGreen;
            this.notifIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.notifIcon.Location = new System.Drawing.Point(9, 8);
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
            this.notifCloseBtn.Size = new System.Drawing.Size(30, 49);
            this.notifCloseBtn.TabIndex = 2;
            this.notifCloseBtn.Text = "x";
            this.notifCloseBtn.UseVisualStyleBackColor = false;
            this.notifCloseBtn.Click += new System.EventHandler(this.notifCloseBtn_Click);
            // 
            // notifLabel
            // 
            this.notifLabel.AutoSize = true;
            this.notifLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifLabel.Location = new System.Drawing.Point(56, 14);
            this.notifLabel.Name = "notifLabel";
            this.notifLabel.Size = new System.Drawing.Size(68, 15);
            this.notifLabel.TabIndex = 0;
            this.notifLabel.Text = "{mensaje}";
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // bPrint
            // 
            this.bPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.bPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bPrint.Enabled = false;
            this.bPrint.FlatAppearance.BorderSize = 0;
            this.bPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.bPrint.IconColor = System.Drawing.Color.White;
            this.bPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bPrint.IconSize = 35;
            this.bPrint.Location = new System.Drawing.Point(245, 378);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(106, 45);
            this.bPrint.TabIndex = 39;
            this.bPrint.UseVisualStyleBackColor = false;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bCobrar
            // 
            this.bCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.bCobrar.Enabled = false;
            this.bCobrar.FlatAppearance.BorderSize = 0;
            this.bCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCobrar.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.bCobrar.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.bCobrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.bCobrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCobrar.IconSize = 36;
            this.bCobrar.Location = new System.Drawing.Point(364, 378);
            this.bCobrar.Margin = new System.Windows.Forms.Padding(10, 40, 3, 3);
            this.bCobrar.Name = "bCobrar";
            this.bCobrar.Size = new System.Drawing.Size(158, 45);
            this.bCobrar.TabIndex = 32;
            this.bCobrar.Text = "COBRAR";
            this.bCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCobrar.UseVisualStyleBackColor = false;
            this.bCobrar.Click += new System.EventHandler(this.bCobrar_Click);
            // 
            // venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.notifPanel);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bCobrar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lNombreT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Venta";
            this.Load += new System.EventHandler(this.venta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.notifPanel.ResumeLayout(false);
            this.notifPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lNombreT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lFormaPago;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.TextBox tPago;
        private System.Windows.Forms.Label lbl_Pesos;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton bCard;
        private FontAwesome.Sharp.IconButton bCredit;
        private FontAwesome.Sharp.IconButton bCash;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tCambio;
        private System.Windows.Forms.Label lbl_CAMBIO;
        private System.Windows.Forms.TextBox tTotal;
        private System.Windows.Forms.Label lbl_TOTAL;
        private FontAwesome.Sharp.IconButton bCobrar;
        private System.Windows.Forms.Button bCancelar;
        private FontAwesome.Sharp.IconButton bPrint;
        private System.Windows.Forms.Panel notifPanel;
        private FontAwesome.Sharp.IconPictureBox notifIcon;
        private System.Windows.Forms.Button notifCloseBtn;
        private System.Windows.Forms.Label notifLabel;
        private System.Windows.Forms.Timer Clock;
    }
}