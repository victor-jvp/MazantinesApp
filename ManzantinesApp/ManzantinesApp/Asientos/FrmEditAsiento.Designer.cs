namespace ManzantinesApp.Asientos
{
    partial class FrmEditAsiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_proveedorLabel;
            System.Windows.Forms.Label fechaFacturaLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label fechaPagoLabel;
            System.Windows.Forms.Label formaPagoLabel;
            System.Windows.Forms.Label id_empresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditAsiento));
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.asientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asientosTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.AsientosTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.proveedoresTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.ProveedoresTableAdapter();
            this.asientosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.asientosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.id_proveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaFacturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.formaPagoTextBox = new System.Windows.Forms.TextBox();
            this.pagadoCheckBox = new System.Windows.Forms.CheckBox();
            this.ImporteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.id_empresaComboBox = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EmpresasTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            id_proveedorLabel = new System.Windows.Forms.Label();
            fechaFacturaLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            fechaPagoLabel = new System.Windows.Forms.Label();
            formaPagoLabel = new System.Windows.Forms.Label();
            id_empresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingNavigator)).BeginInit();
            this.asientosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(231, 87);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 14;
            idLabel.Text = "Id:";
            idLabel.Visible = false;
            // 
            // id_proveedorLabel
            // 
            id_proveedorLabel.AutoSize = true;
            id_proveedorLabel.Location = new System.Drawing.Point(32, 32);
            id_proveedorLabel.Name = "id_proveedorLabel";
            id_proveedorLabel.Size = new System.Drawing.Size(59, 13);
            id_proveedorLabel.TabIndex = 0;
            id_proveedorLabel.Text = "Proveedor:";
            // 
            // fechaFacturaLabel
            // 
            fechaFacturaLabel.AutoSize = true;
            fechaFacturaLabel.Location = new System.Drawing.Point(12, 87);
            fechaFacturaLabel.Name = "fechaFacturaLabel";
            fechaFacturaLabel.Size = new System.Drawing.Size(79, 13);
            fechaFacturaLabel.TabIndex = 4;
            fechaFacturaLabel.Text = "Fecha Factura:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(46, 112);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(45, 13);
            importeLabel.TabIndex = 6;
            importeLabel.Text = "Importe:";
            // 
            // fechaPagoLabel
            // 
            fechaPagoLabel.AutoSize = true;
            fechaPagoLabel.Location = new System.Drawing.Point(23, 139);
            fechaPagoLabel.Name = "fechaPagoLabel";
            fechaPagoLabel.Size = new System.Drawing.Size(68, 13);
            fechaPagoLabel.TabIndex = 8;
            fechaPagoLabel.Text = "Fecha Pago:";
            // 
            // formaPagoLabel
            // 
            formaPagoLabel.AutoSize = true;
            formaPagoLabel.Location = new System.Drawing.Point(24, 164);
            formaPagoLabel.Name = "formaPagoLabel";
            formaPagoLabel.Size = new System.Drawing.Size(67, 13);
            formaPagoLabel.TabIndex = 10;
            formaPagoLabel.Text = "Forma Pago:";
            // 
            // id_empresaLabel
            // 
            id_empresaLabel.AutoSize = true;
            id_empresaLabel.Location = new System.Drawing.Point(40, 58);
            id_empresaLabel.Name = "id_empresaLabel";
            id_empresaLabel.Size = new System.Drawing.Size(51, 13);
            id_empresaLabel.TabIndex = 2;
            id_empresaLabel.Text = "Empresa:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asientosBindingSource
            // 
            this.asientosBindingSource.DataMember = "Asientos";
            this.asientosBindingSource.DataSource = this.dataSet1;
            // 
            // asientosTableAdapter
            // 
            this.asientosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsientosTableAdapter = this.asientosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasasTableAdapter = null;
            this.tableAdapterManager.DiasSemanaTableAdapter = null;
            this.tableAdapterManager.EmpleosPagosTableAdapter = null;
            this.tableAdapterManager.EmpleosTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EncargadosTableAdapter = null;
            this.tableAdapterManager.FincasTableAdapter = null;
            this.tableAdapterManager.LiquidacionesTableAdapter = null;
            this.tableAdapterManager.NominasCabTableAdapter = null;
            this.tableAdapterManager.NominasDetTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.Trabajadores_EmpleosTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // asientosBindingNavigator
            // 
            this.asientosBindingNavigator.AddNewItem = null;
            this.asientosBindingNavigator.BindingSource = this.asientosBindingSource;
            this.asientosBindingNavigator.CountItem = null;
            this.asientosBindingNavigator.DeleteItem = null;
            this.asientosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asientosBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.asientosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.asientosBindingNavigator.MoveFirstItem = null;
            this.asientosBindingNavigator.MoveLastItem = null;
            this.asientosBindingNavigator.MoveNextItem = null;
            this.asientosBindingNavigator.MovePreviousItem = null;
            this.asientosBindingNavigator.Name = "asientosBindingNavigator";
            this.asientosBindingNavigator.PositionItem = null;
            this.asientosBindingNavigator.Size = new System.Drawing.Size(334, 25);
            this.asientosBindingNavigator.TabIndex = 13;
            this.asientosBindingNavigator.Text = "bindingNavigator1";
            // 
            // asientosBindingNavigatorSaveItem
            // 
            this.asientosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("asientosBindingNavigatorSaveItem.Image")));
            this.asientosBindingNavigatorSaveItem.Name = "asientosBindingNavigatorSaveItem";
            this.asientosBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.asientosBindingNavigatorSaveItem.Text = "&Guardar";
            this.asientosBindingNavigatorSaveItem.Click += new System.EventHandler(this.AsientosBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asientosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(256, 84);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(41, 20);
            this.idTextBox.TabIndex = 15;
            this.idTextBox.Visible = false;
            // 
            // id_proveedorComboBox
            // 
            this.id_proveedorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_proveedorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_proveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.asientosBindingSource, "id_proveedor", true));
            this.id_proveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.id_proveedorComboBox.DisplayMember = "RazonSocial";
            this.id_proveedorComboBox.FormattingEnabled = true;
            this.id_proveedorComboBox.Location = new System.Drawing.Point(97, 28);
            this.id_proveedorComboBox.Name = "id_proveedorComboBox";
            this.id_proveedorComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_proveedorComboBox.TabIndex = 1;
            this.id_proveedorComboBox.ValueMember = "Id";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dataSet1;
            // 
            // fechaFacturaDateTimePicker
            // 
            this.fechaFacturaDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.fechaFacturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.asientosBindingSource, "FechaFactura", true));
            this.fechaFacturaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaFacturaDateTimePicker.Location = new System.Drawing.Point(97, 82);
            this.fechaFacturaDateTimePicker.Name = "fechaFacturaDateTimePicker";
            this.fechaFacturaDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.fechaFacturaDateTimePicker.TabIndex = 5;
            // 
            // fechaPagoDateTimePicker
            // 
            this.fechaPagoDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.fechaPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.asientosBindingSource, "FechaPago", true));
            this.fechaPagoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaPagoDateTimePicker.Location = new System.Drawing.Point(97, 134);
            this.fechaPagoDateTimePicker.Name = "fechaPagoDateTimePicker";
            this.fechaPagoDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.fechaPagoDateTimePicker.TabIndex = 9;
            // 
            // formaPagoTextBox
            // 
            this.formaPagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asientosBindingSource, "FormaPago", true));
            this.formaPagoTextBox.Location = new System.Drawing.Point(97, 160);
            this.formaPagoTextBox.Name = "formaPagoTextBox";
            this.formaPagoTextBox.Size = new System.Drawing.Size(101, 20);
            this.formaPagoTextBox.TabIndex = 11;
            // 
            // pagadoCheckBox
            // 
            this.pagadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.asientosBindingSource, "Pagado", true));
            this.pagadoCheckBox.Location = new System.Drawing.Point(222, 158);
            this.pagadoCheckBox.Name = "pagadoCheckBox";
            this.pagadoCheckBox.Size = new System.Drawing.Size(75, 24);
            this.pagadoCheckBox.TabIndex = 12;
            this.pagadoCheckBox.Text = "Pagado";
            this.pagadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImporteNumericUpDown
            // 
            this.ImporteNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.asientosBindingSource, "Importe", true));
            this.ImporteNumericUpDown.DecimalPlaces = 2;
            this.ImporteNumericUpDown.Location = new System.Drawing.Point(97, 108);
            this.ImporteNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.ImporteNumericUpDown.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.ImporteNumericUpDown.Name = "ImporteNumericUpDown";
            this.ImporteNumericUpDown.Size = new System.Drawing.Size(101, 20);
            this.ImporteNumericUpDown.TabIndex = 7;
            this.ImporteNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ImporteNumericUpDown.ThousandsSeparator = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // id_empresaComboBox
            // 
            this.id_empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.asientosBindingSource, "id_empresa", true));
            this.id_empresaComboBox.DataSource = this.empresasBindingSource;
            this.id_empresaComboBox.DisplayMember = "Empresa";
            this.id_empresaComboBox.FormattingEnabled = true;
            this.id_empresaComboBox.Location = new System.Drawing.Point(97, 55);
            this.id_empresaComboBox.Name = "id_empresaComboBox";
            this.id_empresaComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_empresaComboBox.TabIndex = 3;
            this.id_empresaComboBox.ValueMember = "Id";
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.dataSet1;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEditAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(id_empresaLabel);
            this.Controls.Add(this.id_empresaComboBox);
            this.Controls.Add(this.ImporteNumericUpDown);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(id_proveedorLabel);
            this.Controls.Add(this.id_proveedorComboBox);
            this.Controls.Add(fechaFacturaLabel);
            this.Controls.Add(this.fechaFacturaDateTimePicker);
            this.Controls.Add(importeLabel);
            this.Controls.Add(fechaPagoLabel);
            this.Controls.Add(this.fechaPagoDateTimePicker);
            this.Controls.Add(formaPagoLabel);
            this.Controls.Add(this.formaPagoTextBox);
            this.Controls.Add(this.pagadoCheckBox);
            this.Controls.Add(this.asientosBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditAsiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Asiento";
            this.Load += new System.EventHandler(this.FrmEditAsiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingNavigator)).EndInit();
            this.asientosBindingNavigator.ResumeLayout(false);
            this.asientosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource asientosBindingSource;
        private Data.DataSet1TableAdapters.AsientosTableAdapter asientosTableAdapter;
        private Data.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator asientosBindingNavigator;
        private System.Windows.Forms.ToolStripButton asientosBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox id_proveedorComboBox;
        private System.Windows.Forms.DateTimePicker fechaFacturaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaPagoDateTimePicker;
        private System.Windows.Forms.TextBox formaPagoTextBox;
        private System.Windows.Forms.CheckBox pagadoCheckBox;
        private System.Windows.Forms.NumericUpDown ImporteNumericUpDown;
        private Data.DataSet1TableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox id_empresaComboBox;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private Data.DataSet1TableAdapters.EmpresasTableAdapter empresasTableAdapter;
    }
}