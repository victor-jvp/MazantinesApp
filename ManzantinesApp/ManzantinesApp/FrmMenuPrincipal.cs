namespace ManzantinesApp
{
    using System;
    using System.Windows.Forms;

    public partial class FrmMenuPrincipal : Form
    {

        #region Methods
        private void loadCasa(Button boton)
        {
            try
            {
                int nroCasa = 0;
                string nombre = boton.Name;
                nroCasa = Convert.ToInt32(nombre.Substring(nombre.Length - 2, 2));
                this.Enabled = false;
                FrmEmpleadoCasa miForm = new FrmEmpleadoCasa();
                miForm.NroCasa = nroCasa;
                miForm.Show(this);
            }
            catch (Exception)
            {
                throw;
            }
            
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

        private void encargadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmEncargados frmEncargados = new FrmEncargados();
            frmEncargados.Show(this);
            this.Enabled = true;
        }

        private void CasaButton1_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);            
        }

        private void CasaButton2_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton3_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton4_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton5_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton6_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton7_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton8_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton9_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton10_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton11_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton12_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton13_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton14_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton15_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton16_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton17_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton18_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton19_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton20_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton21_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton22_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton23_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton24_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton25_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton26_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton27_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton28_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton29_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton30_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton31_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton32_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton33_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton34_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void CasaButton35_Click(object sender, EventArgs e)
        {
            loadCasa(sender as Button);
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.Show(this);
            this.Enabled = true;
        }

        private void AsientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Asientos.FrmAsientos frmAsientos = new Asientos.FrmAsientos();
            frmAsientos.Show(this);
            this.Enabled = true;
        }
    }
}
