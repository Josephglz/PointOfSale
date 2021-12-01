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
    public partial class inventario : Form
    {
        /*===============   [   LOADERS   ]   ===============*/
        public inventario()
        {
            InitializeComponent();
        }
        /*===============   [   METHODS   ]   ===============*/
        /*===============   [   CONTROLLERS   ]   ===============*/
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
