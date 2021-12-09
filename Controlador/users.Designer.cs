
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bExit = new System.Windows.Forms.Button();
            this.lFecha = new System.Windows.Forms.Label();
            this.lReloj = new System.Windows.Forms.Label();
            this.lNombreT = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.userTable = new System.Windows.Forms.DataGridView();
            this.bUserAdd = new FontAwesome.Sharp.IconButton();
            this.bUserModify = new FontAwesome.Sharp.IconButton();
            this.bUserDelete = new FontAwesome.Sharp.IconButton();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tID = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.ch2 = new System.Windows.Forms.CheckBox();
            this.tPass = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tUser = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.tImagen = new System.Windows.Forms.TextBox();
            this.lbl_Imagen = new System.Windows.Forms.Label();
            this.notifPanel = new System.Windows.Forms.Panel();
            this.notifIcon = new FontAwesome.Sharp.IconPictureBox();
            this.notifCloseBtn = new System.Windows.Forms.Button();
            this.notifLabel = new System.Windows.Forms.Label();
            this.copyUser = new FontAwesome.Sharp.IconButton();
            this.copyPass = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.notifPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userTable.ColumnHeadersHeight = 30;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.userTable.EnableHeadersVisualStyles = false;
            this.userTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.userTable.Location = new System.Drawing.Point(9, 63);
            this.userTable.MultiSelect = false;
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.userTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.userTable.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.userTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userTable.Size = new System.Drawing.Size(771, 167);
            this.userTable.TabIndex = 18;
            // 
            // bUserAdd
            // 
            this.bUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.bUserAdd.FlatAppearance.BorderSize = 0;
            this.bUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUserAdd.Font = new System.Drawing.Font("Poppins Light", 0.1F);
            this.bUserAdd.ForeColor = System.Drawing.Color.White;
            this.bUserAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.bUserAdd.IconColor = System.Drawing.Color.White;
            this.bUserAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bUserAdd.IconSize = 35;
            this.bUserAdd.Location = new System.Drawing.Point(142, 246);
            this.bUserAdd.Name = "bUserAdd";
            this.bUserAdd.Size = new System.Drawing.Size(127, 37);
            this.bUserAdd.TabIndex = 19;
            this.bUserAdd.Text = "Agregar";
            this.bUserAdd.UseVisualStyleBackColor = false;
            this.bUserAdd.Click += new System.EventHandler(this.bUserAdd_Click);
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
            this.bUserModify.Location = new System.Drawing.Point(331, 246);
            this.bUserModify.Name = "bUserModify";
            this.bUserModify.Size = new System.Drawing.Size(127, 37);
            this.bUserModify.TabIndex = 20;
            this.bUserModify.Text = "Modificar";
            this.bUserModify.UseVisualStyleBackColor = false;
            this.bUserModify.Click += new System.EventHandler(this.bUserModify_Click);
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
            this.bUserDelete.Location = new System.Drawing.Point(523, 246);
            this.bUserDelete.Name = "bUserDelete";
            this.bUserDelete.Size = new System.Drawing.Size(127, 37);
            this.bUserDelete.TabIndex = 21;
            this.bUserDelete.Text = "Eliminar";
            this.bUserDelete.UseVisualStyleBackColor = false;
            this.bUserDelete.Click += new System.EventHandler(this.bUserDelete_Click);
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.tNombre.Location = new System.Drawing.Point(205, 377);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(180, 23);
            this.tNombre.TabIndex = 26;
            this.tNombre.Leave += new System.EventHandler(this.tNombre_Leave);
            // 
            // tID
            // 
            this.tID.Enabled = false;
            this.tID.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(205, 349);
            this.tID.Name = "tID";
            this.tID.ReadOnly = true;
            this.tID.Size = new System.Drawing.Size(71, 23);
            this.tID.TabIndex = 25;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(35, 374);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(164, 28);
            this.lbl_Nombre.TabIndex = 24;
            this.lbl_Nombre.Text = "Nombre Empleado:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.lbl_Id.Location = new System.Drawing.Point(35, 346);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(115, 28);
            this.lbl_Id.TabIndex = 23;
            this.lbl_Id.Text = "ID Empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 45);
            this.label1.TabIndex = 22;
            this.label1.Text = "Datos del Empleado";
            // 
            // tApellido
            // 
            this.tApellido.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.tApellido.Location = new System.Drawing.Point(205, 405);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(180, 23);
            this.tApellido.TabIndex = 28;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(35, 402);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(164, 28);
            this.lbl_Apellido.TabIndex = 27;
            this.lbl_Apellido.Text = "Apellido Empleado:";
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.ch1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ch1.Location = new System.Drawing.Point(479, 345);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(144, 32);
            this.ch1.TabIndex = 29;
            this.ch1.Text = "Administrador";
            this.ch1.UseVisualStyleBackColor = true;
            this.ch1.CheckedChanged += new System.EventHandler(this.ch1_CheckedChanged);
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.ch2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ch2.Location = new System.Drawing.Point(626, 345);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(110, 32);
            this.ch2.TabIndex = 30;
            this.ch2.Text = "Vendedor";
            this.ch2.UseVisualStyleBackColor = true;
            this.ch2.CheckedChanged += new System.EventHandler(this.ch2_CheckedChanged);
            // 
            // tPass
            // 
            this.tPass.Enabled = false;
            this.tPass.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.tPass.Location = new System.Drawing.Point(568, 408);
            this.tPass.Name = "tPass";
            this.tPass.ReadOnly = true;
            this.tPass.Size = new System.Drawing.Size(148, 23);
            this.tPass.TabIndex = 34;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(446, 405);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(91, 28);
            this.lbl_Password.TabIndex = 33;
            this.lbl_Password.Text = "Password:";
            // 
            // tUser
            // 
            this.tUser.Enabled = false;
            this.tUser.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.tUser.Location = new System.Drawing.Point(568, 380);
            this.tUser.Name = "tUser";
            this.tUser.ReadOnly = true;
            this.tUser.Size = new System.Drawing.Size(148, 23);
            this.tUser.TabIndex = 32;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(446, 377);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(75, 28);
            this.lbl_Usuario.TabIndex = 31;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // tImagen
            // 
            this.tImagen.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.tImagen.Location = new System.Drawing.Point(278, 437);
            this.tImagen.Name = "tImagen";
            this.tImagen.Size = new System.Drawing.Size(438, 23);
            this.tImagen.TabIndex = 36;
            // 
            // lbl_Imagen
            // 
            this.lbl_Imagen.AutoSize = true;
            this.lbl_Imagen.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Imagen.Location = new System.Drawing.Point(108, 434);
            this.lbl_Imagen.Name = "lbl_Imagen";
            this.lbl_Imagen.Size = new System.Drawing.Size(144, 28);
            this.lbl_Imagen.TabIndex = 35;
            this.lbl_Imagen.Text = "Imagen de Perfil:";
            // 
            // notifPanel
            // 
            this.notifPanel.AutoSize = true;
            this.notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.notifPanel.Controls.Add(this.notifIcon);
            this.notifPanel.Controls.Add(this.notifCloseBtn);
            this.notifPanel.Controls.Add(this.notifLabel);
            this.notifPanel.Location = new System.Drawing.Point(245, 141);
            this.notifPanel.Name = "notifPanel";
            this.notifPanel.Size = new System.Drawing.Size(292, 36);
            this.notifPanel.TabIndex = 37;
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
            this.notifLabel.Size = new System.Drawing.Size(61, 15);
            this.notifLabel.TabIndex = 0;
            this.notifLabel.Text = "alertMsg";
            // 
            // copyUser
            // 
            this.copyUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.copyUser.FlatAppearance.BorderSize = 0;
            this.copyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyUser.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.copyUser.IconColor = System.Drawing.Color.White;
            this.copyUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.copyUser.IconSize = 20;
            this.copyUser.Location = new System.Drawing.Point(722, 377);
            this.copyUser.Name = "copyUser";
            this.copyUser.Size = new System.Drawing.Size(34, 26);
            this.copyUser.TabIndex = 38;
            this.copyUser.UseVisualStyleBackColor = false;
            this.copyUser.Click += new System.EventHandler(this.copyUser_Click);
            // 
            // copyPass
            // 
            this.copyPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.copyPass.FlatAppearance.BorderSize = 0;
            this.copyPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyPass.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.copyPass.IconColor = System.Drawing.Color.White;
            this.copyPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.copyPass.IconSize = 20;
            this.copyPass.Location = new System.Drawing.Point(722, 405);
            this.copyPass.Name = "copyPass";
            this.copyPass.Size = new System.Drawing.Size(34, 26);
            this.copyPass.TabIndex = 39;
            this.copyPass.UseVisualStyleBackColor = false;
            this.copyPass.Click += new System.EventHandler(this.copyPass_Click);
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 480);
            this.Controls.Add(this.copyPass);
            this.Controls.Add(this.copyUser);
            this.Controls.Add(this.notifPanel);
            this.Controls.Add(this.tImagen);
            this.Controls.Add(this.lbl_Imagen);
            this.Controls.Add(this.tPass);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.tUser);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bUserDelete);
            this.Controls.Add(this.bUserModify);
            this.Controls.Add(this.bUserAdd);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.notifPanel.ResumeLayout(false);
            this.notifPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView userTable;
        private FontAwesome.Sharp.IconButton bUserAdd;
        private FontAwesome.Sharp.IconButton bUserModify;
        private FontAwesome.Sharp.IconButton bUserDelete;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.CheckBox ch2;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox tImagen;
        private System.Windows.Forms.Label lbl_Imagen;
        private System.Windows.Forms.Panel notifPanel;
        private FontAwesome.Sharp.IconPictureBox notifIcon;
        private System.Windows.Forms.Button notifCloseBtn;
        private System.Windows.Forms.Label notifLabel;
        private FontAwesome.Sharp.IconButton copyUser;
        private FontAwesome.Sharp.IconButton copyPass;
    }
}