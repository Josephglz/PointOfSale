using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public partial class calculadora : Form
    {
        private int num1;
        private int res;
        public calculadora()
        {
            InitializeComponent();
        }

        public string getValueCalculator
        {
            get { return tNumeros.Text; }
        }

        private void calculadora_Load(object sender, EventArgs e)
        {
            tNumeros.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + "9";
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            tNumeros.Text = tNumeros.Text + ".";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tNumeros.Text.Length > 0)
            {
                tNumeros.Text = tNumeros.Text.Substring(0, tNumeros.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tNumeros.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if(tNumeros.Text != "")
            {
                if(num1 == 0)
                {
                    num1 = Convert.ToInt32(tNumeros.Text);
                    res = 0;
                }
                else
                {
                    res = num1 + Convert.ToInt32(tNumeros.Text);
                    tNumeros.Text = res.ToString();
                }
            }
        }
    }
}
