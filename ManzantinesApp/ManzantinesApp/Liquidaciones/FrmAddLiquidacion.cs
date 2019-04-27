using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManzantinesApp.Liquidaciones
{
    public partial class FrmAddLiquidacion : Form
    {
        public FrmAddLiquidacion()
        {
            InitializeComponent();
        }

        #region Properties
        public bool UpdateList { get; set; } = false;
        #endregion

        #region Methods
        private bool Validarcampos()
        {
            this.errorProvider1.Clear();

            if (string.IsNullOrEmpty(conceptoTextBox.Text))
            {
                this.errorProvider1.SetError(conceptoTextBox, "Este campo es requerido");
                conceptoTextBox.Focus();
                return false;
            }

            if(totalesNumericUpDown.Value <= 0)
            {
                this.errorProvider1.SetError(totalesNumericUpDown, "Este campo debe ser mayor que cero");
                totalesNumericUpDown.Focus();
                return false;
            }

            return true;
        }
        #endregion

        private void LiquidacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validarcampos()) return;
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

        private void FrmAddLiquidacion_Load(object sender, EventArgs e)
        {
            this.liquidacionesTableAdapter.Fill(this.dataSet1.Liquidaciones);
            this.liquidacionesBindingSource.AddNew();
            this.categoriaComboBox.SelectedIndex = 0;
            this.conceptoTextBox.Text = string.Empty;
            this.totalesNumericUpDown.Value = 0;
        }
    }
}
