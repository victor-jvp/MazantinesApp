namespace ManzantinesApp
{
    using CrystalDecisions.Shared;
    using ManzantinesApp.Data;
    using ManzantinesApp.Reports;
    using System;
    using System.Data;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pdf|*.pdf";

                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptAsientosPendientes();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.asientosBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "Asientos";
                ds.Tables.Add(dt);

                frmPreviewCrystal.ReporteCrystal.SetDataSource(ds);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    diskFileDestinationOptions.DiskFileName = saveFileDialog.FileName;
                    exportOptions = frmPreviewCrystal.ReporteCrystal.ExportOptions;
                    {
                        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                        exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
                        exportOptions.ExportFormatOptions = new PdfFormatOptions();
                    }
                    frmPreviewCrystal.ReporteCrystal.Export();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptAsientosPendientes();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.asientosBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "Asientos";
                ds.Tables.Add(dt);

                frmPreviewCrystal.ReporteCrystal.SetDataSource(ds);
                frmPreviewCrystal.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pdf|*.pdf";

                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptAsientosPagados();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.asientosBindingSource1.List;
                DataTable dt = view.ToTable();
                dt.TableName = "Asientos";
                ds.Tables.Add(dt);

                frmPreviewCrystal.ReporteCrystal.SetDataSource(ds);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    diskFileDestinationOptions.DiskFileName = saveFileDialog.FileName;
                    exportOptions = frmPreviewCrystal.ReporteCrystal.ExportOptions;
                    {
                        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                        exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
                        exportOptions.ExportFormatOptions = new PdfFormatOptions();
                    }
                    frmPreviewCrystal.ReporteCrystal.Export();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptAsientosPagados();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.asientosBindingSource1.List;
                DataTable dt = view.ToTable();
                dt.TableName = "Asientos";
                ds.Tables.Add(dt);

                frmPreviewCrystal.ReporteCrystal.SetDataSource(ds);
                frmPreviewCrystal.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
        }
    }
}
