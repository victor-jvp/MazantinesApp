using ManzantinesApp.Data;
using System;
using System.Windows.Forms;

namespace ManzantinesApp.Liquidaciones
{
    public partial class FrmEditLiquidacion : Form
    {
        public FrmEditLiquidacion()
        {
            InitializeComponent();
        }

        #region Properties
        public DataSet1.LiquidacionesRow miLiquidacion { get; set; } = null;
        public bool UpdateList { get; set; } = false;
        #endregion

        #region Methods
        private bool Validarcampos()
        {
            this.errorProvider1.Clear();

            //if (string.IsNullOrEmpty(conceptoTextBox.Text))
            //{
            //    this.errorProvider1.SetError(conceptoTextBox, "Este campo es requerido");
            //    conceptoTextBox.Focus();
            //    return false;
            //}

            return true;
        }
        #endregion

        private void LiquidacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validarcampos())
                {
                    return;
                }

                this.Validate();
                this.liquidacionesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
                this.UpdateList = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Error en Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmEditLiquidacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.dataSet1.Empresas);
            this.liquidacionesTableAdapter.Fill(this.dataSet1.Liquidaciones);
            this.liquidacionesBindingSource.Filter = $"Id = {miLiquidacion.Id}";
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmKilogramos frmKilogramos = new FrmKilogramos();
            frmKilogramos.ShowDialog(this);
            this.Enabled = true;
        }
    }
}
