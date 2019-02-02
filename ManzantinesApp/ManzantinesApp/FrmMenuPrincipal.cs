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
            FrmCasas frmCasas = new FrmCasas();
            frmCasas.Show(this);
        }

        private void fincasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFincas frmFincas = new FrmFincas();
            frmFincas.Show(this);
        }

        private void empleoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleos frmEmpleos = new FrmEmpleos();
            frmEmpleos.Show(this);
        }

        private void casasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCasas frmCasas = new FrmCasas();
            frmCasas.Show(this);
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresas frmEmpresas = new FrmEmpresas();
            frmEmpresas.Show(this);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.Show(this);
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Confirme salir del sistema.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
