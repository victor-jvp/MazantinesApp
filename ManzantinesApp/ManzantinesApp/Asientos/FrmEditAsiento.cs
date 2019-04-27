using ManzantinesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManzantinesApp.Asientos
{
    public partial class FrmEditAsiento : Form
    {

        #region Properties
        public bool UpdateList { get; set; } = false;
        public DataSet1.AsientosRow miAsiento { get; set; } = null;
        #endregion

        #region Constructors
        public FrmEditAsiento()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        private bool ValidarCampos()
        {
            this.errorProvider1.Clear();

            if (id_proveedorComboBox.SelectedValue == null)
            {
                this.errorProvider1.SetError(id_proveedorComboBox, "Este campo es requerido");
                id_proveedorComboBox.Focus();
                return false;
            }

            if (ImporteNumericUpDown.Value <= 0)
            {
                this.errorProvider1.SetError(ImporteNumericUpDown, "Este campo debe ser mayor que cero");
                ImporteNumericUpDown.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(formaPagoTextBox.Text))
            {
                this.errorProvider1.SetError(formaPagoTextBox, "Este campo es requerido");
                formaPagoTextBox.Focus();
                return false;
            }

            return true;
        }

        #endregion

        private void AsientosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;
                this.Validate();
                this.asientosBindingSource.EndEdit();
                this.asientosTableAdapter.Update(this.dataSet1.Asientos);
                this.UpdateList = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error en Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmEditAsiento_Load(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.Fill(this.dataSet1.Proveedores);
            this.asientosTableAdapter.Fill(this.dataSet1.Asientos);
            this.asientosBindingSource.Filter = $"Id = {miAsiento.Id}";
        }
    }
}
