namespace ManzantinesApp
{
    using System;
    using System.Windows.Forms;
    using CrystalDecisions.Shared;
    using Data;
    using Reports;
    using System.Linq;

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

            this.trabajadores_EmpleosTableAdapter.Fill(this.dataSet1.Trabajadores_Empleos);

            this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);
        }

        private void FilterTable()
        {
            var casa = CasaToolStripTextBox.Text.Trim();
            var encargado = EncargadoToolStripTextBox.Text.Trim();
            var empresa = EmpresaToolStripTextBox.Text.Trim();

            if(string.IsNullOrEmpty(casa) && string.IsNullOrEmpty(encargado) && string.IsNullOrEmpty(empresa))
            {
                this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);
            }
            else
            {
                //vv_trabajadoresTableTableAdapter.FillByCasaAndEmpresaAndEncargado(
                //   this.dataSet1.vv_trabajadoresTable,
                //   casa,
                //   empresa,
                //   encargado);
            }
            
        }

        private void EncargadoToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void CasaToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void EmpresaToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
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

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
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
                var id_trabajador = (int)trabajadoresDataGridView.CurrentRow.Cells["Id"].Value;
                var query = this.dataSet1.Trabajadores_Empleos.Where(t => t.id_trabajador == id_trabajador);

                foreach (var row in query)
                {
                    row.Delete();
                }
                this.trabajadores_EmpleosTableAdapter.Update(this.dataSet1.Trabajadores_Empleos);
                trabajadoresBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.trabajadoresBindingSource.CancelEdit();
            }
        }

        private void pDFToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void excelToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void vistaPreliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (trabajadoresDataGridView.CurrentRow == null) return;

            this.Enabled = false;
            FrmEditEmpleado frmEditEmpleado = new FrmEditEmpleado();
            frmEditEmpleado.miTrabajador = dataSet1.Trabajadores.FindById((int)trabajadoresDataGridView.CurrentRow.Cells[0].Value);
            if (frmEditEmpleado.miTrabajador == null)
            {
                MessageBox.Show(
                    "El trabajador no pudo ser cargado, por favor intente de nuevo.", 
                    "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            frmEditEmpleado.ShowDialog(this);
            this.Enabled = true;

            if (frmEditEmpleado.UpdateList)
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSet1.Trabajadores' Puede moverla o quitarla según sea necesario.
                this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);
            }
        }
    }
}
