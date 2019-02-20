namespace ManzantinesApp
{
    using System;
    using System.Windows.Forms;

    public partial class FrmMenuPrincipal : Form
    {

        #region Methods
        private void loadCasa(int nroCasa)
        {
            this.Enabled = false;
            FrmEmpleadoCasa miForm = new FrmEmpleadoCasa();
            miForm.NroCasa = nroCasa;
            miForm.Show(this);
            this.Enabled = true;
        }
        #endregion

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadCasa(1);
        }

        private void fincasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmFincas frmFincas = new FrmFincas();
            frmFincas.Show(this);
            this.Enabled = true;
        }

        private void empleoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmEmpleos frmEmpleos = new FrmEmpleos();
            frmEmpleos.Show(this);
            this.Enabled = true;
        }

        private void casasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmCasas frmCasas = new FrmCasas();
            frmCasas.Show(this);
            this.Enabled = true;
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmEmpresas frmEmpresas = new FrmEmpresas();
            frmEmpresas.Show(this);
            this.Enabled = true;
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.Show(this);
            this.Enabled = true;
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Confirme salir del sistema.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadCasa(2);
        }
    }
}
