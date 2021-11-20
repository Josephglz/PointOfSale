
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
            this.prod_Panel = new System.Windows.Forms.Panel();
            this.prod_LName = new System.Windows.Forms.Label();
            this.prod_LPrice = new System.Windows.Forms.Label();
            this.prod_BAdd = new System.Windows.Forms.Button();
            this.prod_BRemove = new System.Windows.Forms.Button();
            this.prod_LCant = new System.Windows.Forms.Label();
            this.prod_TCant = new System.Windows.Forms.TextBox();
            this.PanelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.prod_Panel.SuspendLayout();
            this.PanelProductos.SuspendLayout();
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
            this.lReloj.Location = new System.Drawing.Point(843, 13);
            this.lReloj.Name = "lReloj";
            this.lReloj.Size = new System.Drawing.Size(86, 45);
            this.lReloj.TabIndex = 11;
            this.lReloj.Text = "00:00";
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
            // prod_Panel
            // 
            this.prod_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(220)))), ((int)(((byte)(102)))));
            this.prod_Panel.Controls.Add(this.prod_TCant);
            this.prod_Panel.Controls.Add(this.prod_LCant);
            this.prod_Panel.Controls.Add(this.prod_BRemove);
            this.prod_Panel.Controls.Add(this.prod_BAdd);
            this.prod_Panel.Controls.Add(this.prod_LPrice);
            this.prod_Panel.Controls.Add(this.prod_LName);
            this.prod_Panel.Location = new System.Drawing.Point(3, 3);
            this.prod_Panel.Name = "prod_Panel";
            this.prod_Panel.Size = new System.Drawing.Size(508, 44);
            this.prod_Panel.TabIndex = 11;
            // 
            // prod_LName
            // 
            this.prod_LName.AutoSize = true;
            this.prod_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_LName.Location = new System.Drawing.Point(3, 5);
            this.prod_LName.Name = "prod_LName";
            this.prod_LName.Size = new System.Drawing.Size(90, 16);
            this.prod_LName.TabIndex = 0;
            this.prod_LName.Text = "Sacapuntas";
            // 
            // prod_LPrice
            // 
            this.prod_LPrice.AutoSize = true;
            this.prod_LPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_LPrice.Location = new System.Drawing.Point(3, 22);
            this.prod_LPrice.Name = "prod_LPrice";
            this.prod_LPrice.Size = new System.Drawing.Size(38, 15);
            this.prod_LPrice.TabIndex = 1;
            this.prod_LPrice.Text = "$3.50";
            // 
            // prod_BAdd
            // 
            this.prod_BAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
            this.prod_BAdd.FlatAppearance.BorderSize = 0;
            this.prod_BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prod_BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_BAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(218)))), ((int)(((byte)(105)))));
            this.prod_BAdd.Location = new System.Drawing.Point(422, 4);
            this.prod_BAdd.Name = "prod_BAdd";
            this.prod_BAdd.Size = new System.Drawing.Size(35, 35);
            this.prod_BAdd.TabIndex = 2;
            this.prod_BAdd.Text = "+";
            this.prod_BAdd.UseVisualStyleBackColor = false;
            // 
            // prod_BRemove
            // 
            this.prod_BRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
            this.prod_BRemove.FlatAppearance.BorderSize = 0;
            this.prod_BRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prod_BRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_BRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.prod_BRemove.Location = new System.Drawing.Point(463, 4);
            this.prod_BRemove.Name = "prod_BRemove";
            this.prod_BRemove.Size = new System.Drawing.Size(35, 35);
            this.prod_BRemove.TabIndex = 3;
            this.prod_BRemove.Text = "X";
            this.prod_BRemove.UseVisualStyleBackColor = false;
            // 
            // prod_LCant
            // 
            this.prod_LCant.AutoSize = true;
            this.prod_LCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_LCant.Location = new System.Drawing.Point(295, 14);
            this.prod_LCant.Name = "prod_LCant";
            this.prod_LCant.Size = new System.Drawing.Size(38, 16);
            this.prod_LCant.TabIndex = 4;
            this.prod_LCant.Text = "Cant:";
            // 
            // prod_TCant
            // 
            this.prod_TCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
            this.prod_TCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prod_TCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_TCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(218)))), ((int)(((byte)(105)))));
            this.prod_TCant.Location = new System.Drawing.Point(339, 11);
            this.prod_TCant.Name = "prod_TCant";
            this.prod_TCant.Size = new System.Drawing.Size(53, 22);
            this.prod_TCant.TabIndex = 5;
            this.prod_TCant.Text = "1";
            this.prod_TCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelProductos
            // 
            this.PanelProductos.AutoScroll = true;
            this.PanelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.PanelProductos.Controls.Add(this.prod_Panel);
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
            this.tCodigo.Text = "CÓDIGO PRODUCTO";
            this.tCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tCodigo.Enter += new System.EventHandler(this.tCodigo_Enter);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(218)))), ((int)(((byte)(105)))));
            this.btnAgregar.Location = new System.Drawing.Point(720, 64);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 31);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1020, 551);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.PanelProductos);
            this.Controls.Add(this.panelCalculadora);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.prod_Panel.ResumeLayout(false);
            this.prod_Panel.PerformLayout();
            this.PanelProductos.ResumeLayout(false);
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
        private System.Windows.Forms.Panel prod_Panel;
        private System.Windows.Forms.TextBox prod_TCant;
        private System.Windows.Forms.Label prod_LCant;
        private System.Windows.Forms.Button prod_BRemove;
        private System.Windows.Forms.Button prod_BAdd;
        private System.Windows.Forms.Label prod_LPrice;
        private System.Windows.Forms.Label prod_LName;
        private System.Windows.Forms.FlowLayoutPanel PanelProductos;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.Button btnAgregar;
    }
}