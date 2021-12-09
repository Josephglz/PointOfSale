using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public partial class venta : Form
    {
        /*---------- VARIABLES ----------*/
        private string nombre, rol, imagen;
        private double total;
        public int notifCount = 5;
        public string getPago
        {
            get
            {
                return tPago.Text;
            }
        }
        public string getCambio
        {
            get
            {
                return tCambio.Text;
            }
        }
        /*---------- CONSTRUCTORS ----------*/
        public venta(string nombre, string rol, double total, string image)
        {
            this.nombre = nombre;
            this.rol = rol;
            this.total = total;
            this.imagen = image;
            InitializeComponent();
        }
        private void venta_Load(object sender, EventArgs e)
        {
            profilePicture.ImageLocation = this.imagen;
            lNombre.Text = this.nombre;
            lRol.Text = this.rol;
            tTotal.Text = "$" + this.total;
        }
        /*---------- METHODS ----------*/
        public void showAlert(int type, string msg, int time)
        {
            notifPanel.Visible = true;

            notifPanel.Location = new Point(
                this.ClientSize.Width / 2 - notifPanel.Size.Width / 2,
                this.ClientSize.Height / 2 - notifPanel.Size.Height / 2);
            notifPanel.Anchor = AnchorStyles.None;
            if (type == 1) //Error
            {
                notifIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                notifIcon.ForeColor = System.Drawing.Color.Red;
                notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(187)))), ((int)(((byte)(173)))));
            }
            else if (type == 2) //Info
            {
                notifIcon.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
                notifIcon.ForeColor = System.Drawing.Color.DarkTurquoise;
                notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            }
            else if (type == 3) //approve
            {
                notifIcon.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                notifIcon.ForeColor = System.Drawing.Color.LimeGreen;
                notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(246)))), ((int)(((byte)(184)))));
            }

            notifLabel.Text = msg;
            notifCount = time;
        }
        public void hideAlert()
        {
            if (notifCount <= 0)
            {
                notifPanel.Visible = false;
            }
            else
            {
                notifCount--;
            }
        }
        /*---------- CONTROLLERS ----------*/
        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void tPago_Enter(object sender, EventArgs e)
        {
            tPago.Text = "";
        }
        private void bCard_Click(object sender, EventArgs e)
        {
            showAlert(1, "Opción no disponible.", 3);
        }
        private void bCredit_Click(object sender, EventArgs e)
        {
            showAlert(1, "Opción no disponible.", 3);
        }
        private void bCash_Click(object sender, EventArgs e)
        {
            tPago.Enabled = true;
            tPago.ReadOnly = false;
            lFormaPago.Text = "Efectivo";
        }
        private void tPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(tPago.Text != "")
                {
                    try
                    {
                        double total = Convert.ToDouble(tTotal.Text.Substring(1));
                        double pago = Convert.ToDouble(tPago.Text);
                        if(pago >= total)
                        {
                            double cambio = pago - total; 
                            cambio = Math.Round(cambio, 2);
                            tCambio.Text = "$" + cambio;
                            tPago.Text = "$" + tPago.Text;
                            bCobrar.Enabled = true;
                        }
                        else
                        {
                            showAlert(1, "El pago es menor al total a pagar.", 3);
                        }
                    }
                    catch(Exception error)
                    {
                        showAlert(3, "Ingrese un monto válido.", 3);
                    }
                }
                else
                {
                    tPago.Text = "$0.00";
                }
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            tPago.Text = "$0.00";
        }
        private void bCobrar_Click(object sender, EventArgs e)
        {
            float pago = float.Parse(tPago.Text.Substring(1));
            float total = float.Parse(tTotal.Text.Substring(1));
            if(tPago.Text != "$0.00" && pago >= total)
            {
                showAlert(3, "Cobro con éxito.\nImprima el ticket para continuar", 7);
                bPrint.Enabled = true;
            }
            else if(tPago.Enabled == false)
            {
                showAlert(2, "Seleccione un método de pago.", 3);
            }
            else if(total > pago)
            {
                showAlert(1, "El total no ha sido liquidado,", 3);
            }
        }
        private void bPrint_Click(object sender, EventArgs e)
        {

        }
        private void notifCloseBtn_Click(object sender, EventArgs e)
        {
            notifCount = 0;
            notifPanel.Visible = false;
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            hideAlert();
        }
    }
}
