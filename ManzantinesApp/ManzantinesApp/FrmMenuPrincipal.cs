using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManzantinesApp
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            FrmCasa miCasa = new FrmCasa();
            miCasa.NroCasa = 11;
            miCasa.Show(this);
        }

        private void fincasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFincas frmFincas = new FrmFincas();
            frmFincas.Show(this);
        }
    }
}
