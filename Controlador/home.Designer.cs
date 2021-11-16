
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
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
            this.panelCalculadora.Location = new System.Drawing.Point(74, 295);
            this.panelCalculadora.Name = "panelCalculadora";
            this.panelCalculadora.Size = new System.Drawing.Size(250, 240);
            this.panelCalculadora.TabIndex = 9;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 551);
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
            this.ResumeLayout(false);

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
    }
}