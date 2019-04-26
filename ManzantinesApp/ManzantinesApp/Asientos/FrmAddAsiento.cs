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
    public partial class FrmAddAsiento : Form
    {
        #region Properties
        public bool UpdateList { get; set; } = false;
        #endregion

        #region Constructors
        public FrmAddAsiento()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        private bool ValidarCampos()
        {
            this.errorProvider1.Clear();

            if(id_proveedorComboBox.SelectedValue == null)
            {
                this.errorProvider1.SetError(id_proveedorComboBox, "Este campo es requerido");
                id_proveedorComboBox.Focus();
                return false;
            }

            if(ImporteNumericUpDown.Value <= 0)
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
            this.Validate();
            this.asientosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AsientosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;
                this.Validate();
                this.asientosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
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

        private void FrmAddAsiento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.dataSet1.Proveedores);
            // TODO: This line of code loads data into the 'dataSet1.Asientos' table. You can move, or remove it, as needed.
            this.asientosTableAdapter.Fill(this.dataSet1.Asientos);

            this.asientosBindingSource.AddNew();

            this.fechaFacturaDateTimePicker.Value = DateTime.Now;
            this.fechaPagoDateTimePicker.Value = DateTime.Now;
        }
    }
}
