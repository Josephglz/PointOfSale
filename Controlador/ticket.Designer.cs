
namespace Controlador
{
    partial class ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticket));
            this.logoTienda = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTicket = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.lHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ticket_prPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ticket_prCant = new System.Windows.Forms.Label();
            this.ticket_prNombre = new System.Windows.Forms.Label();
            this.ticket_prPrecio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lSubtotal = new System.Windows.Forms.Label();
            this.lIVA = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lEfectivo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lCambio = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoTienda)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.ticket_prPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoTienda
            // 
            this.logoTienda.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoTienda.Image = global::Controlador.Properties.Resources.logo;
            this.logoTienda.Location = new System.Drawing.Point(0, 0);
            this.logoTienda.Name = "logoTienda";
            this.logoTienda.Size = new System.Drawing.Size(350, 69);
            this.logoTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoTienda.TabIndex = 0;
            this.logoTienda.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.panel1.Location = new System.Drawing.Point(17, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 18);
            this.panel1.TabIndex = 1;
            // 
            // lTicket
            // 
            this.lTicket.BackColor = System.Drawing.Color.Transparent;
            this.lTicket.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTicket.Location = new System.Drawing.Point(9, 124);
            this.lTicket.Name = "lTicket";
            this.lTicket.Size = new System.Drawing.Size(327, 45);
            this.lTicket.TabIndex = 41;
            this.lTicket.Text = "TICKET N°: 000000000";
            this.lTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lDireccion
            // 
            this.lDireccion.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.ForeColor = System.Drawing.Color.Black;
            this.lDireccion.Location = new System.Drawing.Point(17, 98);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(319, 26);
            this.lDireccion.TabIndex = 42;
            this.lDireccion.Text = "Dirección, Codigo postal, Ciudad, Estado";
            // 
            // lFecha
            // 
            this.lFecha.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.ForeColor = System.Drawing.Color.Black;
            this.lFecha.Location = new System.Drawing.Point(117, 168);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(117, 21);
            this.lFecha.TabIndex = 43;
            this.lFecha.Text = "Fecha: 00/mes./0000";
            // 
            // lHora
            // 
            this.lHora.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHora.ForeColor = System.Drawing.Color.Black;
            this.lHora.Location = new System.Drawing.Point(250, 168);
            this.lHora.Name = "lHora";
            this.lHora.Size = new System.Drawing.Size(86, 21);
            this.lHora.TabIndex = 44;
            this.lHora.Text = "Hora: 00:00:00";
            this.lHora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Pago: Efectivo";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 197);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(319, 27);
            this.flowLayoutPanel1.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(66, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "CONCEPTO";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "CANT";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(237, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "IMPORTE";
            // 
            // ticket_prPanel
            // 
            this.ticket_prPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticket_prPanel.Controls.Add(this.ticket_prCant);
            this.ticket_prPanel.Controls.Add(this.ticket_prNombre);
            this.ticket_prPanel.Controls.Add(this.ticket_prPrecio);
            this.ticket_prPanel.Location = new System.Drawing.Point(17, 224);
            this.ticket_prPanel.Name = "ticket_prPanel";
            this.ticket_prPanel.Size = new System.Drawing.Size(319, 189);
            this.ticket_prPanel.TabIndex = 47;
            // 
            // ticket_prCant
            // 
            this.ticket_prCant.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_prCant.ForeColor = System.Drawing.Color.Black;
            this.ticket_prCant.Location = new System.Drawing.Point(3, 0);
            this.ticket_prCant.Name = "ticket_prCant";
            this.ticket_prCant.Size = new System.Drawing.Size(57, 20);
            this.ticket_prCant.TabIndex = 47;
            this.ticket_prCant.Text = "0";
            // 
            // ticket_prNombre
            // 
            this.ticket_prNombre.AutoEllipsis = true;
            this.ticket_prNombre.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_prNombre.ForeColor = System.Drawing.Color.Black;
            this.ticket_prNombre.Location = new System.Drawing.Point(66, 0);
            this.ticket_prNombre.Name = "ticket_prNombre";
            this.ticket_prNombre.Size = new System.Drawing.Size(165, 20);
            this.ticket_prNombre.TabIndex = 46;
            this.ticket_prNombre.Text = "nombre";
            // 
            // ticket_prPrecio
            // 
            this.ticket_prPrecio.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_prPrecio.ForeColor = System.Drawing.Color.Black;
            this.ticket_prPrecio.Location = new System.Drawing.Point(237, 0);
            this.ticket_prPrecio.Name = "ticket_prPrecio";
            this.ticket_prPrecio.Size = new System.Drawing.Size(66, 20);
            this.ticket_prPrecio.TabIndex = 48;
            this.ticket_prPrecio.Text = "IMPORTE";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Dubai Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(182, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "SUBTOTAL :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Dubai Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(228, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "IVA :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Dubai Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(208, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 50;
            this.label9.Text = "TOTAL :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lSubtotal
            // 
            this.lSubtotal.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubtotal.ForeColor = System.Drawing.Color.Black;
            this.lSubtotal.Location = new System.Drawing.Point(273, 430);
            this.lSubtotal.Name = "lSubtotal";
            this.lSubtotal.Size = new System.Drawing.Size(51, 21);
            this.lSubtotal.TabIndex = 51;
            this.lSubtotal.Text = "$0.00";
            // 
            // lIVA
            // 
            this.lIVA.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIVA.ForeColor = System.Drawing.Color.Black;
            this.lIVA.Location = new System.Drawing.Point(273, 446);
            this.lIVA.Name = "lIVA";
            this.lIVA.Size = new System.Drawing.Size(51, 21);
            this.lIVA.TabIndex = 52;
            this.lIVA.Text = "$0.00";
            // 
            // lTotal
            // 
            this.lTotal.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.ForeColor = System.Drawing.Color.Black;
            this.lTotal.Location = new System.Drawing.Point(273, 461);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(51, 21);
            this.lTotal.TabIndex = 53;
            this.lTotal.Text = "$0.00";
            // 
            // lEfectivo
            // 
            this.lEfectivo.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEfectivo.ForeColor = System.Drawing.Color.Black;
            this.lEfectivo.Location = new System.Drawing.Point(273, 492);
            this.lEfectivo.Name = "lEfectivo";
            this.lEfectivo.Size = new System.Drawing.Size(51, 21);
            this.lEfectivo.TabIndex = 55;
            this.lEfectivo.Text = "$0.00";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Dubai Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(186, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 21);
            this.label14.TabIndex = 54;
            this.label14.Text = "EFECTIVO:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lCambio
            // 
            this.lCambio.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCambio.ForeColor = System.Drawing.Color.Black;
            this.lCambio.Location = new System.Drawing.Point(273, 508);
            this.lCambio.Name = "lCambio";
            this.lCambio.Size = new System.Drawing.Size(51, 21);
            this.lCambio.TabIndex = 57;
            this.lCambio.Text = "$0.00";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Dubai Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(186, 508);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 21);
            this.label16.TabIndex = 56;
            this.label16.Text = "CAMBIO:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.panel2.Location = new System.Drawing.Point(17, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 5);
            this.panel2.TabIndex = 58;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(17, 542);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(319, 45);
            this.lblMensaje.TabIndex = 59;
            this.lblMensaje.Text = "GRACIAS POR SU COMPRA.\r\nLe atendió: Nombre Apellido";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 596);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lCambio);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lEfectivo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.lIVA);
            this.Controls.Add(this.lSubtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ticket_prPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lHora);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoTienda);
            this.Controls.Add(this.lTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ticket";
            this.Text = "Generar Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.logoTienda)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ticket_prPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoTienda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lTicket;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel ticket_prPanel;
        private System.Windows.Forms.Label ticket_prCant;
        private System.Windows.Forms.Label ticket_prNombre;
        private System.Windows.Forms.Label ticket_prPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lSubtotal;
        private System.Windows.Forms.Label lIVA;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lEfectivo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lCambio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMensaje;
    }
}