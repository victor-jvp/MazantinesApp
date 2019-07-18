namespace ManzantinesApp.Liquidaciones
{
    using CrystalDecisions.Shared;
    using ManzantinesApp.Data;
    using ManzantinesApp.Reports;
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class FrmLiquidaciones : Form
    {

        public FrmLiquidaciones()
        {
            InitializeComponent();
        }

        #region Methods
        private void FilterTable()
        {
            liquidacionesBindingSource.RemoveFilter();

            string filtro = string.Empty;

            if (PagadasRadioButton.Checked)
            {
                filtro += $"Pagado = 1";
            }

            if (SinPagarRadioButton.Checked)
            {
                filtro += $"Pagado = 0";
            }

            if (FrutaComboBox.SelectedValue != null && !string.IsNullOrEmpty(FrutaComboBox.Text))
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    filtro += " AND ";
                }

                filtro += $"id_fruta = '{FrutaComboBox.SelectedValue.ToString().Trim()}'";
            }

            if (VariedadComboBox.SelectedValue != null && !string.IsNullOrEmpty(VariedadComboBox.Text))
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    filtro += " AND ";
                }

                filtro += $"Variedad = '{VariedadComboBox.SelectedValue.ToString().Trim()}'";
            }

            if (FincaComboBox.SelectedValue != null && !string.IsNullOrEmpty(FincaComboBox.Text))
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    filtro += " AND ";
                }

                filtro += $"id_finca = '{FincaComboBox.SelectedValue.ToString().Trim()}'";
            }

            if (DesdeCheckBox.Checked)
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    filtro += " AND ";
                }

                filtro += $"( Fecha >= #{DesdeDateTimePicker.Value.ToString("MM/dd/yyyy")}# AND Fecha <= #{HastaDateTimePicker.Value.ToString("MM/dd/yyyy")}# )";
            }

            if (!string.IsNullOrEmpty(filtro))
            {
                liquidacionesBindingSource.Filter = filtro;
            }
        }

        private void LoadGridtotales()
        {
            DataTable totalesDT = new DataTable();

            var frutas = new DataSet1.FrutasDataTable();
            var fincas = new DataSet1.FincasDataTable();
            this.frutasTableAdapter.Fill(frutas);
            this.fincasTableAdapter.Fill(fincas);

            totalesDT.Columns.Add("Fruta", typeof(string));

            foreach (DataSet1.FincasRow item in fincas.Rows)
            {
                totalesDT.Columns.Add(item.Finca.ToString().Trim(), typeof(double));
            }

            foreach (DataSet1.FrutasRow fruta in frutas.Rows)
            {
                DataRow newRow = totalesDT.Rows.Add();
                int i = 0;
                newRow.SetField(i, fruta.Fruta);
                i++;
                foreach (DataSet1.FincasRow finca in fincas.Rows)
                {
                    var total = this.liquidacionesTableAdapter.SumTotalByFrutaAndFinca(fruta.Id, finca.Id);
                    newRow.SetField(i, total);
                    i++;
                }
            }

            BindingSource totalesBS = new BindingSource
            {
                DataSource = totalesDT
            };
            TotalesDataGridView.DataSource = totalesBS;
        }
        #endregion

        private void LiquidacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.liquidacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FrmLiquidaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Fincas' table. You can move, or remove it, as needed.
            this.fincasTableAdapter.Fill(this.dataSet1.Fincas);
            this.frutasTableAdapter.Fill(this.dataSet1.Frutas);
            this.empresasTableAdapter.Fill(this.dataSet1.Empresas);
            this.liquidacionesTableAdapter.FillActive(this.dataSet1.Liquidaciones);

            this.FrutaComboBox.SelectedIndex = -1;
            this.VariedadComboBox.SelectedIndex = -1;
            this.FincaComboBox.SelectedIndex = -1;

            this.DesdeDateTimePicker.Value = DateTime.Now;
            this.HastaDateTimePicker.Value = DateTime.Now;

            HastaDateTimePicker.MinDate = DesdeDateTimePicker.Value;
            DesdeDateTimePicker.MaxDate = HastaDateTimePicker.Value;

            LoadGridtotales();
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmAddLiquidacion frmAddLiquidacion = new FrmAddLiquidacion();
            frmAddLiquidacion.ShowDialog(this);
            this.Enabled = true;

            if (frmAddLiquidacion.UpdateList)
            {
                this.liquidacionesTableAdapter.FillActive(this.dataSet1.Liquidaciones);
                LoadGridtotales();
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Confirme eliminar el registro",
                "Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                liquidacionesDataGridView.CurrentRow.Cells["DeletedAt"].Value = DateTime.Now;
                this.liquidacionesBindingSource.EndEdit();
                this.liquidacionesTableAdapter.Update(this.dataSet1.Liquidaciones);
                this.liquidacionesTableAdapter.FillActive(this.dataSet1.Liquidaciones);
                LoadGridtotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (liquidacionesDataGridView.CurrentRow == null)
            {
                return;
            }

            this.Enabled = false;
            FrmEditLiquidacion frmEditLiquidacion = new FrmEditLiquidacion
            {
                miLiquidacion = dataSet1.Liquidaciones.FindById((int)liquidacionesDataGridView.CurrentRow.Cells[0].Value)
            };
            if (frmEditLiquidacion.miLiquidacion == null)
            {
                MessageBox.Show(
                    "El registro no pudo ser cargado, por favor intente de nuevo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this.Enabled = true;
                return;
            }

            frmEditLiquidacion.ShowDialog(this);
            this.Enabled = true;

            if (frmEditLiquidacion.UpdateList)
            {
                this.liquidacionesTableAdapter.FillActive(this.dataSet1.Liquidaciones);
                LoadGridtotales();
            }
        }

        private void BuscarToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void TotalesToolStripButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmTotalesCategorias frmTotalesCategorias = new FrmTotalesCategorias();
            frmTotalesCategorias.ShowDialog(this);
            this.Enabled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Pdf|*.pdf"
                };

                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal
                {
                    ReporteCrystal = new RptLiquidaciones()
                };


                this.dataSet1.Liquidaciones.DefaultView.RowFilter = liquidacionesBindingSource.Filter;
                DataSet ds = new DataSet();
                ds.Tables.Add(this.dataSet1.Fincas.Copy());
                ds.Tables.Add(this.dataSet1.Frutas.Copy());
                ds.Tables.Add(this.dataSet1.Empresas.Copy());
                ds.Tables.Add(this.dataSet1.Liquidaciones.DefaultView.ToTable());

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

        private void vistaPreliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal
                {
                    ReporteCrystal = new RptLiquidaciones()
                };

                this.dataSet1.Liquidaciones.DefaultView.RowFilter = liquidacionesBindingSource.Filter;
                DataSet ds = new DataSet();
                ds.Tables.Add(this.dataSet1.Fincas.Copy());
                ds.Tables.Add(this.dataSet1.Frutas.Copy());
                ds.Tables.Add(this.dataSet1.Empresas.Copy());
                ds.Tables.Add(this.dataSet1.Liquidaciones.DefaultView.ToTable());

                frmPreviewCrystal.ReporteCrystal.SetDataSource(ds);
                frmPreviewCrystal.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
        }

        private void TodasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TodasRadioButton.Checked)
            {
                FilterTable();
            }
        }

        private void PagadasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PagadasRadioButton.Checked)
            {
                FilterTable();
            }
        }

        private void SinPagarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SinPagarRadioButton.Checked)
            {
                FilterTable();
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel|*.xlsx"
                };

                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal
                {
                    ReporteCrystal = new RptLiquidaciones()
                };

                this.dataSet1.Liquidaciones.DefaultView.RowFilter = liquidacionesBindingSource.Filter;
                DataSet ds = new DataSet();
                ds.Tables.Add(this.dataSet1.Fincas.Copy());
                ds.Tables.Add(this.dataSet1.Frutas.Copy());
                ds.Tables.Add(this.dataSet1.Empresas.Copy());
                ds.Tables.Add(this.dataSet1.Liquidaciones.DefaultView.ToTable());
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

        private void FrutaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void VariedadComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterTable();

            if (FrutaComboBox.SelectedValue != null)
            {
                this.frutas_variedadesTableAdapter.FillByIdFruta(this.dataSet1.Frutas_variedades, new System.Nullable<int>(((int)(System.Convert.ChangeType(FrutaComboBox.SelectedValue, typeof(int))))));
            }
        }

        private void FincaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void FrutaComboBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void VariedadComboBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
            if (FrutaComboBox.SelectedValue != null)
            {
                this.frutas_variedadesTableAdapter.FillByIdFruta(this.dataSet1.Frutas_variedades, new System.Nullable<int>(((int)(System.Convert.ChangeType(FrutaComboBox.SelectedValue, typeof(int))))));
            }
        }

        private void FincaComboBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void DesdeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DesdeCheckBox.Checked)
            {
                DesdeDateTimePicker.Enabled = true;
                HastaDateTimePicker.Enabled = true;
            }
        }

        private void DesdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            HastaDateTimePicker.MinDate = DesdeDateTimePicker.Value;
            DesdeDateTimePicker.MaxDate = HastaDateTimePicker.Value;

            FilterTable();
        }

        private void HastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            HastaDateTimePicker.MinDate = DesdeDateTimePicker.Value;
            DesdeDateTimePicker.MaxDate = HastaDateTimePicker.Value;

            FilterTable();
        }
    }
}
