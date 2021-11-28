
namespace Controlador
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            this.bExit = new System.Windows.Forms.Button();
            this.lFecha = new System.Windows.Forms.Label();
            this.lReloj = new System.Windows.Forms.Label();
            this.lNombreT = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.bLogin = new System.Windows.Forms.Button();
            this.userTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.Location = new System.Drawing.Point(759, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(31, 34);
            this.bExit.TabIndex = 15;
            this.bExit.Text = "X";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
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
            this.lNombreT.Location = new System.Drawing.Point(280, 8);
            this.lNombreT.Name = "lNombreT";
            this.lNombreT.Size = new System.Drawing.Size(234, 40);
            this.lNombreT.TabIndex = 10;
            this.lNombreT.Text = "Administrar Usuarios";
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
            this.panel1.Size = new System.Drawing.Size(790, 55);
            this.panel1.TabIndex = 16;
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.bLogin.FlatAppearance.BorderSize = 0;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.Color.White;
            this.bLogin.Location = new System.Drawing.Point(574, 278);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(127, 28);
            this.bLogin.TabIndex = 17;
            this.bLogin.Text = "Ingresar";
            this.bLogin.UseVisualStyleBackColor = false;
            // 
            // userTable
            // 
            this.userTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(67)))));
            this.userTable.Location = new System.Drawing.Point(12, 66);
            this.userTable.Name = "userTable";
            this.userTable.Size = new System.Drawing.Size(766, 149);
            this.userTable.TabIndex = 18;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 341);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lReloj;
        private System.Windows.Forms.Label lNombreT;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.DataGridView userTable;
    }
}