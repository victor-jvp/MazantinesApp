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
            this.fincasTableAdapter.Fill(this.dataSet1.Fincas);
            this.frutas_variedadesTableAdapter.Fill(this.dataSet1.Frutas_variedades);
            this.frutasTableAdapter.Fill(this.dataSet1.Frutas);
            this.empresasTableAdapter.Fill(this.dataSet1.Empresas);

            this.liquidacionesTableAdapter.Fill(this.dataSet1.Liquidaciones);
            this.liquidacionesBindingSource.Filter = $"Id = {miLiquidacion.Id}";
            this.categoriaComboBox.Text= miLiquidacion.Categoria.ToString();
        }

        private void id_frutaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (id_frutaComboBox.SelectedValue == null) return;
            this.frutas_variedadesTableAdapter.FillByIdFruta(this.dataSet1.Frutas_variedades, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_frutaComboBox.SelectedValue, typeof(int))))));
        }
    }
}
