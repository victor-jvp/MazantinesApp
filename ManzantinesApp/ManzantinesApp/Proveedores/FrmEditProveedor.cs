namespace ManzantinesApp
{

    using ManzantinesApp.Data;
    using System;
    using System.Windows.Forms;

    public partial class FrmEditProveedor : Form
    {


        #region Properties
        public DataSet1.ProveedoresRow miProveedor { get; set; } = null;
        public bool UpdateList { get; set; } = false;
        #endregion

        #region Methods

        private bool ValidarCampos()
        {
            errorProvider1.Clear();

            var control = new TextBox();
            control = cifTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            control = razonSocialTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            control = bancoTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            control = nroCuentaTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            control = telefonoTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            control = emailTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            return true;
        }

        #endregion

        public FrmEditProveedor()
        {
            InitializeComponent();
        }

        private void FrmEditProveedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Asientos' table. You can move, or remove it, as needed.
            this.asientosTableAdapter.FillByIdProveedor(this.dataSet1.Asientos, miProveedor.Id);
            this.proveedoresTableAdapter.Fill(this.dataSet1.Proveedores);
            this.proveedoresBindingSource.Filter = $"Id = {miProveedor.Id}";

            this.asientosBindingSource.Filter = "Pagado = false";
            this.asientosBindingSource1.Filter = "Pagado = true";

            this.dataGridView1.Columns["idDataGridViewTextBoxColumn"].Visible = false;
            this.dataGridView2.Columns["idDataGridViewTextBoxColumn1"].Visible = false;

            idTextBox.Visible = false;
        }

        private void ProveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                this.Validate();
                this.proveedoresBindingSource.EndEdit();
                this.proveedoresTableAdapter.Update(this.dataSet1.Proveedores);
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
    }
}
