namespace ManzantinesApp
{
    using System;
    using System.Windows.Forms;

    public partial class FrmEmpleadoCasa : Form
    {
        #region Properties
        public int NroCasa { get; set; } = -1;
        #endregion

        public FrmEmpleadoCasa()
        {
            InitializeComponent();
        }

        private void FrmEmpleadoCasa_Load(object sender, EventArgs e)
        {
            if(NroCasa < 0)
            {
                MessageBox.Show("El Nro de Casa no fue definido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: This line of code loads data into the 'dataSet1.vv_EmpleadosCasas' table. You can move, or remove it, as needed.
            this.vv_EmpleadosCasasTableAdapter.FillByNroCasa(this.dataSet1.vv_EmpleadosCasas, NroCasa);

            this.Text += $" Número: [{NroCasa}]";
        }
    }
}
