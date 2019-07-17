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

            this.fincasTableAdapter.Fill(this.dataSet1.Fincas);
            this.frutasTableAdapter.Fill(this.dataSet1.Frutas);
            this.empresasTableAdapter.Fill(this.dataSet1.Empresas);
            this.frutas_variedadesTableAdapter.FillByIdFruta(dataSet1.Frutas_variedades, new int?((int)Convert.ChangeType(id_frutaComboBox.SelectedValue, typeof(int))));

            this.liquidacionesBindingSource.AddNew();
            this.categoriaComboBox.SelectedIndex = 0;
            this.totalesNumericUpDown.Value = 0;
            this.fechaDateTimePicker.Value = DateTime.Now;
            this.fechaPagoDateTimePicker.Value = DateTime.Now;
            this.pagadoCheckBox.Checked = false;

            this.id_empresaComboBox.SelectedIndex = -1;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (id_frutaComboBox.SelectedValue == null) return;
            this.frutas_variedadesTableAdapter.FillByIdFruta(this.dataSet1.Frutas_variedades, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_frutaComboBox.SelectedValue, typeof(int))))));
        }
    }
}
