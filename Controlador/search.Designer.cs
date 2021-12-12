
namespace Controlador
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBack = new System.Windows.Forms.Button();
            this.lNombreT = new System.Windows.Forms.Label();
            this.bBuscar = new FontAwesome.Sharp.IconButton();
            this.TBusqueda = new System.Windows.Forms.TextBox();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.prod_name = new System.Windows.Forms.Label();
            this.prod_precio = new System.Windows.Forms.Label();
            this.prod_categoria = new System.Windows.Forms.Label();
            this.prod_id = new System.Windows.Forms.Label();
            this.prod_stock = new System.Windows.Forms.Label();
            this.prod_modo = new FontAwesome.Sharp.IconPictureBox();
            this.lError = new System.Windows.Forms.Label();
            this.prod_image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_modo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.bBack);
            this.panel1.Controls.Add(this.lNombreT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 55);
            this.panel1.TabIndex = 10;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bBack.FlatAppearance.BorderSize = 0;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.White;
            this.bBack.Location = new System.Drawing.Point(344, 0);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(67, 28);
            this.bBack.TabIndex = 7;
            this.bBack.Text = "Volver";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lNombreT
            // 
            this.lNombreT.BackColor = System.Drawing.Color.Transparent;
            this.lNombreT.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreT.ForeColor = System.Drawing.Color.White;
            this.lNombreT.Location = new System.Drawing.Point(0, 7);
            this.lNombreT.Name = "lNombreT";
            this.lNombreT.Size = new System.Drawing.Size(409, 40);
            this.lNombreT.TabIndex = 11;
            this.lNombreT.Text = "Buscar Producto";
            this.lNombreT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(67)))));
            this.bBuscar.FlatAppearance.BorderSize = 0;
            this.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.bBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bBuscar.IconSize = 30;
            this.bBuscar.Location = new System.Drawing.Point(305, 105);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bBuscar.Size = new System.Drawing.Size(75, 31);
            this.bBuscar.TabIndex = 25;
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // TBusqueda
            // 
            this.TBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.TBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(157)))));
            this.TBusqueda.Location = new System.Drawing.Point(30, 105);
            this.TBusqueda.Name = "TBusqueda";
            this.TBusqueda.Size = new System.Drawing.Size(253, 31);
            this.TBusqueda.TabIndex = 24;
            this.TBusqueda.Text = "BUSCAR";
            this.TBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBusqueda.Enter += new System.EventHandler(this.TBusqueda_Enter);
            // 
            // groupOptions
            // 
            this.groupOptions.BackColor = System.Drawing.Color.Transparent;
            this.groupOptions.Controls.Add(this.cb2);
            this.groupOptions.Controls.Add(this.cb1);
            this.groupOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupOptions.Location = new System.Drawing.Point(30, 61);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(350, 38);
            this.groupOptions.TabIndex = 26;
            this.groupOptions.TabStop = false;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold);
            this.cb2.Location = new System.Drawing.Point(168, 9);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(132, 25);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "Buscar Por Nombre";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold);
            this.cb1.Location = new System.Drawing.Point(50, 9);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(99, 25);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Buscar por ID";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // prod_name
            // 
            this.prod_name.AutoEllipsis = true;
            this.prod_name.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.prod_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            this.prod_name.Location = new System.Drawing.Point(30, 300);
            this.prod_name.Name = "prod_name";
            this.prod_name.Size = new System.Drawing.Size(350, 38);
            this.prod_name.TabIndex = 28;
            this.prod_name.Text = "NombreProducto";
            this.prod_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prod_name.Visible = false;
            // 
            // prod_precio
            // 
            this.prod_precio.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prod_precio.Location = new System.Drawing.Point(0, 338);
            this.prod_precio.Name = "prod_precio";
            this.prod_precio.Size = new System.Drawing.Size(409, 21);
            this.prod_precio.TabIndex = 29;
            this.prod_precio.Text = "Precio: $00000";
            this.prod_precio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prod_precio.Visible = false;
            // 
            // prod_categoria
            // 
            this.prod_categoria.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prod_categoria.Location = new System.Drawing.Point(0, 359);
            this.prod_categoria.Name = "prod_categoria";
            this.prod_categoria.Size = new System.Drawing.Size(409, 21);
            this.prod_categoria.TabIndex = 30;
            this.prod_categoria.Text = "Categoría: NombreCategoria";
            this.prod_categoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prod_categoria.Visible = false;
            // 
            // prod_id
            // 
            this.prod_id.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prod_id.Location = new System.Drawing.Point(143, 279);
            this.prod_id.Name = "prod_id";
            this.prod_id.Size = new System.Drawing.Size(120, 21);
            this.prod_id.TabIndex = 31;
            this.prod_id.Text = "ID: 00000";
            this.prod_id.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prod_id.Visible = false;
            // 
            // prod_stock
            // 
            this.prod_stock.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prod_stock.Location = new System.Drawing.Point(0, 380);
            this.prod_stock.Name = "prod_stock";
            this.prod_stock.Size = new System.Drawing.Size(409, 21);
            this.prod_stock.TabIndex = 32;
            this.prod_stock.Text = "Stock: 000";
            this.prod_stock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prod_stock.Visible = false;
            // 
            // prod_modo
            // 
            this.prod_modo.BackColor = System.Drawing.Color.Transparent;
            this.prod_modo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.prod_modo.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.prod_modo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.prod_modo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.prod_modo.Location = new System.Drawing.Point(231, 244);
            this.prod_modo.Name = "prod_modo";
            this.prod_modo.Size = new System.Drawing.Size(32, 32);
            this.prod_modo.TabIndex = 33;
            this.prod_modo.TabStop = false;
            this.prod_modo.Visible = false;
            // 
            // lError
            // 
            this.lError.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.lError.ForeColor = System.Drawing.Color.Red;
            this.lError.Location = new System.Drawing.Point(0, 170);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(409, 23);
            this.lError.TabIndex = 34;
            this.lError.Text = "error";
            this.lError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lError.Visible = false;
            // 
            // prod_image
            // 
            this.prod_image.Location = new System.Drawing.Point(143, 156);
            this.prod_image.Name = "prod_image";
            this.prod_image.Size = new System.Drawing.Size(120, 120);
            this.prod_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prod_image.TabIndex = 35;
            this.prod_image.TabStop = false;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(409, 411);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.prod_modo);
            this.Controls.Add(this.prod_stock);
            this.Controls.Add(this.prod_id);
            this.Controls.Add(this.prod_categoria);
            this.Controls.Add(this.prod_precio);
            this.Controls.Add(this.prod_name);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.TBusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prod_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.search_Load);
            this.panel1.ResumeLayout(false);
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_modo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label lNombreT;
        private FontAwesome.Sharp.IconButton bBuscar;
        private System.Windows.Forms.TextBox TBusqueda;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Label prod_name;
        private System.Windows.Forms.Label prod_precio;
        private System.Windows.Forms.Label prod_categoria;
        private System.Windows.Forms.Label prod_id;
        private System.Windows.Forms.Label prod_stock;
        private FontAwesome.Sharp.IconPictureBox prod_modo;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.PictureBox prod_image;
    }
}