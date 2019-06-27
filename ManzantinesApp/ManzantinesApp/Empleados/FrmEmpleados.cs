namespace ManzantinesApp
{
    using System;
    using System.Windows.Forms;
    using CrystalDecisions.Shared;
    using Data;
    using Reports;
    using System.Linq;
    using System.Data;

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

            this.vv_empleadosTableAdapter.Fill(this.dataSet1.vv_empleados);
        }

        private void FilterTable()
        {
            var casa = CasaToolStripTextBox.Text.Trim();
            var empleado = EmpleadoToolStripTextBox.Text.Trim();
            var empresa = EmpresaToolStripTextBox.Text.Trim();

            if(string.IsNullOrEmpty(casa) && string.IsNullOrEmpty(empleado) && string.IsNullOrEmpty(empresa))
            {
                this.vv_empleadosBindingSource.RemoveFilter();
            }
            else
            {
                string filter = string.Empty;
                if(!string.IsNullOrEmpty(casa))
                    filter += $"NroCasa LIKE '%{casa}%'";

                if (!string.IsNullOrEmpty(empleado))
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"FullName LIKE '%{empleado}%'";
                }

                if (!string.IsNullOrEmpty(empresa))
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";

                    filter += $"Empresa LIKE '%{empresa}%'";
                }

                vv_empleadosBindingSource.Filter = filter;
            }
            
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
                this.casasTableAdapter.Fill(this.dataSet1.Casas);
                this.empleosTableAdapter.Fill(this.dataSet1.Empleos);
                this.empresasTableAdapter.Fill(this.dataSet1.Empresas);
                this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);
                this.trabajadores_EmpleosTableAdapter.Fill(this.dataSet1.Trabajadores_Empleos);
                this.vv_empleadosTableAdapter.Fill(this.dataSet1.vv_empleados);
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

                var trabajador = this.dataSet1.Trabajadores.Where(t => t.Id == id_trabajador).FirstOrDefault();
                if(trabajador != null) trabajador.Delete();

                this.tableAdapterManager.UpdateAll(this.dataSet1);

                this.vv_empleadosTableAdapter.Fill(this.dataSet1.vv_empleados);
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

                DataSet ds = new DataSet();
                DataView view = (DataView)this.vv_empleadosBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "vv_empleados";
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

                DataSet ds = new DataSet();
                DataView view = (DataView)this.vv_empleadosBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "vv_empleados";
                ds.Tables.Add(dt);

                frmPreviewCrystal.ReporteCrystal.SetDataSource(ds);

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

                DataSet ds = new DataSet();
                DataView view = (DataView)this.vv_empleadosBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "vv_empleados";
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
                this.vv_empleadosTableAdapter.Fill(this.dataSet1.vv_empleados);
                this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);
                this.trabajadores_EmpleosTableAdapter.Fill(this.dataSet1.Trabajadores_Empleos);
            }
        }

        private void EmpleadoToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void BuscarToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            var buscar = BuscarToolStripTextBox.Text.Trim();

            if (string.IsNullOrEmpty(buscar))
            {
                this.vv_empleadosBindingSource.RemoveFilter();
            }
            else
            {
                this.vv_empleadosBindingSource.Filter = $"NroCasa LIKE '%{buscar}%' " +
                    $"OR Nro_empleado LIKE '%{buscar}%' " +
                    $"OR Caja LIKE '%{buscar}%' " +
                    $"OR Nombre LIKE '%{buscar}%' " +
                    $"OR Apellidos LIKE '%{buscar}%' " +
                    $"OR Telefono LIKE '%{buscar}%' " +
                    $"OR Empresa LIKE '%{buscar}%' " +
                    $"OR Empleos LIKE '%{buscar}%'";
            }
        }
    }
}
