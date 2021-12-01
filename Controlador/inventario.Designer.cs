
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lFecha = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.lReloj = new System.Windows.Forms.Label();
            this.lNombreT = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.bUserDelete = new FontAwesome.Sharp.IconButton();
            this.bUserModify = new FontAwesome.Sharp.IconButton();
            this.bUserAdd = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
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
            this.bExit.Location = new System.Drawing.Point(769, 1);
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
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AllowUserToDeleteRows = false;
            this.userTable.AllowUserToResizeColumns = false;
            this.userTable.AllowUserToResizeRows = false;
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.userTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTable.CausesValidation = false;
            this.userTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.userTable.ColumnHeadersHeight = 30;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.userTable.EnableHeadersVisualStyles = false;
            this.userTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.userTable.Location = new System.Drawing.Point(12, 61);
            this.userTable.MultiSelect = false;
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.userTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.userTable.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.userTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userTable.Size = new System.Drawing.Size(776, 167);
            this.userTable.TabIndex = 19;
            // 
            // bUserDelete
            // 
            this.bUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.bUserDelete.FlatAppearance.BorderSize = 0;
            this.bUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUserDelete.Font = new System.Drawing.Font("Poppins Light", 0.1F);
            this.bUserDelete.ForeColor = System.Drawing.Color.White;
            this.bUserDelete.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.bUserDelete.IconColor = System.Drawing.Color.White;
            this.bUserDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bUserDelete.IconSize = 35;
            this.bUserDelete.Location = new System.Drawing.Point(527, 246);
            this.bUserDelete.Name = "bUserDelete";
            this.bUserDelete.Size = new System.Drawing.Size(127, 37);
            this.bUserDelete.TabIndex = 24;
            this.bUserDelete.Text = "Eliminar";
            this.bUserDelete.UseVisualStyleBackColor = false;
            // 
            // bUserModify
            // 
            this.bUserModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bUserModify.FlatAppearance.BorderSize = 0;
            this.bUserModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUserModify.Font = new System.Drawing.Font("Poppins Light", 0.1F);
            this.bUserModify.ForeColor = System.Drawing.Color.White;
            this.bUserModify.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.bUserModify.IconColor = System.Drawing.Color.White;
            this.bUserModify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bUserModify.IconSize = 35;
            this.bUserModify.Location = new System.Drawing.Point(335, 246);
            this.bUserModify.Name = "bUserModify";
            this.bUserModify.Size = new System.Drawing.Size(127, 37);
            this.bUserModify.TabIndex = 23;
            this.bUserModify.Text = "Modificar";
            this.bUserModify.UseVisualStyleBackColor = false;
            // 
            // bUserAdd
            // 
            this.bUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.bUserAdd.FlatAppearance.BorderSize = 0;
            this.bUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUserAdd.Font = new System.Drawing.Font("Poppins Light", 0.1F);
            this.bUserAdd.ForeColor = System.Drawing.Color.White;
            this.bUserAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.bUserAdd.IconColor = System.Drawing.Color.White;
            this.bUserAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bUserAdd.IconSize = 35;
            this.bUserAdd.Location = new System.Drawing.Point(146, 246);
            this.bUserAdd.Name = "bUserAdd";
            this.bUserAdd.Size = new System.Drawing.Size(127, 37);
            this.bUserAdd.TabIndex = 22;
            this.bUserAdd.Text = "Agregar";
            this.bUserAdd.UseVisualStyleBackColor = false;
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bUserDelete);
            this.Controls.Add(this.bUserModify);
            this.Controls.Add(this.bUserAdd);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView userTable;
        private FontAwesome.Sharp.IconButton bUserDelete;
        private FontAwesome.Sharp.IconButton bUserModify;
        private FontAwesome.Sharp.IconButton bUserAdd;
    }
}