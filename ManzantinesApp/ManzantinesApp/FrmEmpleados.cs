namespace ManzantinesApp
{
    using System;
    using System.Windows.Forms;
    using CrystalDecisions.Shared;
    using Data;
    using Reports;

    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void trabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.trabajadoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Casas' Puede moverla o quitarla según sea necesario.
            this.casasTableAdapter.Fill(this.dataSet1.Casas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Empleos' Puede moverla o quitarla según sea necesario.
            this.empleosTableAdapter.Fill(this.dataSet1.Empleos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Empresas' Puede moverla o quitarla según sea necesario.
            this.empresasTableAdapter.Fill(this.dataSet1.Empresas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Trabajadores' Puede moverla o quitarla según sea necesario.
            this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmEditEmpleado frmEditEmpleado = new FrmEditEmpleado();
            frmEditEmpleado.ShowDialog(this);
            this.Enabled = true;

            if (frmEditEmpleado.UpdateList)
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSet1.Trabajadores' Puede moverla o quitarla según sea necesario.
                this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Confirme eliminar el registro",
                "Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.No) return;

            try
            {
                trabajadoresBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void editarToolStripButton1_Click(object sender, EventArgs e)
        {
            if (trabajadoresDataGridView.CurrentRow == null) return;

            this.Enabled = false;
            FrmEditEmpleado frmEditEmpleado = new FrmEditEmpleado();
            frmEditEmpleado.miTrabajador = dataSet1.Trabajadores.FindById(
                (int)trabajadoresDataGridView.CurrentRow.Cells["Id"].Value);
            frmEditEmpleado.ShowDialog(this);
            this.Enabled = true;

            if (frmEditEmpleado.UpdateList)
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSet1.Trabajadores' Puede moverla o quitarla según sea necesario.
                this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);
            }
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pdf|*.pdf";

                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptEmpleados();
                frmPreviewCrystal.ReporteCrystal.SetDataSource(this.dataSet1);

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

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel|*.xlsx";

                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptEmpleados();
                frmPreviewCrystal.ReporteCrystal.SetDataSource(this.dataSet1);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    diskFileDestinationOptions.DiskFileName = saveFileDialog.FileName;
                    exportOptions = frmPreviewCrystal.ReporteCrystal.ExportOptions;
                    {
                        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                        exportOptions.ExportFormatType = ExportFormatType.ExcelWorkbook;
                        exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
                        exportOptions.ExportFormatOptions = new ExcelFormatOptions();
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

        private void vistaPreliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptEmpleados();
                frmPreviewCrystal.ReporteCrystal.SetDataSource(this.dataSet1);
                frmPreviewCrystal.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
        }

        private void CasaToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void FilterTable()
        {
            var casa = CasaToolStripTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(casa))
            {
                casasBindingSource.Filter = $"Casa LIKE '%{casa}%'";
            }
            else
            {
                casasBindingSource.RemoveFilter();
            }

            var encargado = EncargadoToolStripTextBox.Text.Trim();
            if(!string.IsNullOrEmpty(encargado))
            {
                empleosBindingSource.Filter = $"Empleo LIKE '%{encargado}%'";
            }
            else
            {
                empleosBindingSource.RemoveFilter();
            }

            var empresa = EmpresaToolStripTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(empresa =))
            {
                empresasBindingSource.Filter = $"Empleo LIKE '%{empresa =}%'";
            }
            else
            {
                empresasBindingSource.RemoveFilter();
            }
        }
    }
}
