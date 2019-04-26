namespace ManzantinesApp.Asientos
{
    partial class FrmAddAsiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAsiento));
            System.Windows.Forms.Label id_proveedorLabel;
            System.Windows.Forms.Label fechaFacturaLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label fechaPagoLabel;
            System.Windows.Forms.Label formaPagoLabel;
            System.Windows.Forms.Label estadoLabel;
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.asientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asientosTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.AsientosTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.asientosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.asientosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_proveedorComboBox = new System.Windows.Forms.ComboBox();
            this.fechaFacturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.formaPagoTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.ProveedoresTableAdapter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ImporteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            id_proveedorLabel = new System.Windows.Forms.Label();
            fechaFacturaLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            fechaPagoLabel = new System.Windows.Forms.Label();
            formaPagoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingNavigator)).BeginInit();
            this.asientosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.EmpleosTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EncargadosTableAdapter = null;
            this.tableAdapterManager.FincasTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.Trabajadores_EmpleosTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.asientosBindingNavigator.Size = new System.Drawing.Size(395, 25);
            this.asientosBindingNavigator.TabIndex = 0;
            this.asientosBindingNavigator.Text = "bindingNavigator1";
            // 
            // asientosBindingNavigatorSaveItem
            // 
            this.asientosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("asientosBindingNavigatorSaveItem.Image")));
            this.asientosBindingNavigatorSaveItem.Name = "asientosBindingNavigatorSaveItem";
            this.asientosBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.asientosBindingNavigatorSaveItem.Text = "&Guardar";
            this.asientosBindingNavigatorSaveItem.Click += new System.EventHandler(this.AsientosBindingNavigatorSaveItem_Click_1);
            // 
            // id_proveedorLabel
            // 
            id_proveedorLabel.AutoSize = true;
            id_proveedorLabel.Location = new System.Drawing.Point(46, 45);
            id_proveedorLabel.Name = "id_proveedorLabel";
            id_proveedorLabel.Size = new System.Drawing.Size(59, 13);
            id_proveedorLabel.TabIndex = 3;
            id_proveedorLabel.Text = "Proveedor:";
            // 
            // id_proveedorComboBox
            // 
            this.id_proveedorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_proveedorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_proveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asientosBindingSource, "id_proveedor", true));
            this.id_proveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.asientosBindingSource, "id_proveedor", true));
            this.id_proveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.id_proveedorComboBox.DisplayMember = "RazonSocial";
            this.id_proveedorComboBox.FormattingEnabled = true;
            this.id_proveedorComboBox.Location = new System.Drawing.Point(111, 42);
            this.id_proveedorComboBox.Name = "id_proveedorComboBox";
            this.id_proveedorComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_proveedorComboBox.TabIndex = 4;
            this.id_proveedorComboBox.ValueMember = "Id";
            // 
            // fechaFacturaLabel
            // 
            fechaFacturaLabel.AutoSize = true;
            fechaFacturaLabel.Location = new System.Drawing.Point(26, 73);
            fechaFacturaLabel.Name = "fechaFacturaLabel";
            fechaFacturaLabel.Size = new System.Drawing.Size(79, 13);
            fechaFacturaLabel.TabIndex = 5;
            fechaFacturaLabel.Text = "Fecha Factura:";
            // 
            // fechaFacturaDateTimePicker
            // 
            this.fechaFacturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.asientosBindingSource, "FechaFactura", true));
            this.fechaFacturaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFacturaDateTimePicker.Location = new System.Drawing.Point(111, 69);
            this.fechaFacturaDateTimePicker.Name = "fechaFacturaDateTimePicker";
            this.fechaFacturaDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.fechaFacturaDateTimePicker.TabIndex = 6;
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(60, 98);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(45, 13);
            importeLabel.TabIndex = 7;
            importeLabel.Text = "Importe:";
            // 
            // fechaPagoLabel
            // 
            fechaPagoLabel.AutoSize = true;
            fechaPagoLabel.Location = new System.Drawing.Point(37, 125);
            fechaPagoLabel.Name = "fechaPagoLabel";
            fechaPagoLabel.Size = new System.Drawing.Size(68, 13);
            fechaPagoLabel.TabIndex = 9;
            fechaPagoLabel.Text = "Fecha Pago:";
            // 
            // fechaPagoDateTimePicker
            // 
            this.fechaPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.asientosBindingSource, "FechaPago", true));
            this.fechaPagoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPagoDateTimePicker.Location = new System.Drawing.Point(111, 121);
            this.fechaPagoDateTimePicker.Name = "fechaPagoDateTimePicker";
            this.fechaPagoDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.fechaPagoDateTimePicker.TabIndex = 10;
            // 
            // formaPagoLabel
            // 
            formaPagoLabel.AutoSize = true;
            formaPagoLabel.Location = new System.Drawing.Point(38, 150);
            formaPagoLabel.Name = "formaPagoLabel";
            formaPagoLabel.Size = new System.Drawing.Size(67, 13);
            formaPagoLabel.TabIndex = 11;
            formaPagoLabel.Text = "Forma Pago:";
            // 
            // formaPagoTextBox
            // 
            this.formaPagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asientosBindingSource, "FormaPago", true));
            this.formaPagoTextBox.Location = new System.Drawing.Point(111, 147);
            this.formaPagoTextBox.Name = "formaPagoTextBox";
            this.formaPagoTextBox.Size = new System.Drawing.Size(101, 20);
            this.formaPagoTextBox.TabIndex = 12;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(62, 176);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 13;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asientosBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(111, 173);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(101, 20);
            this.estadoTextBox.TabIndex = 14;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dataSet1;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ImporteNumericUpDown
            // 
            this.ImporteNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.asientosBindingSource, "Importe", true));
            this.ImporteNumericUpDown.DecimalPlaces = 2;
            this.ImporteNumericUpDown.Location = new System.Drawing.Point(111, 95);
            this.ImporteNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ImporteNumericUpDown.Name = "ImporteNumericUpDown";
            this.ImporteNumericUpDown.Size = new System.Drawing.Size(101, 20);
            this.ImporteNumericUpDown.TabIndex = 15;
            this.ImporteNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ImporteNumericUpDown.ThousandsSeparator = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 213);
            this.Controls.Add(this.ImporteNumericUpDown);
            this.Controls.Add(id_proveedorLabel);
            this.Controls.Add(this.id_proveedorComboBox);
            this.Controls.Add(fechaFacturaLabel);
            this.Controls.Add(this.fechaFacturaDateTimePicker);
            this.Controls.Add(importeLabel);
            this.Controls.Add(fechaPagoLabel);
            this.Controls.Add(this.fechaPagoDateTimePicker);
            this.Controls.Add(formaPagoLabel);
            this.Controls.Add(this.formaPagoTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.asientosBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddAsiento";
            this.Text = "Agregar Asiento";
            this.Load += new System.EventHandler(this.FrmAddAsiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingNavigator)).EndInit();
            this.asientosBindingNavigator.ResumeLayout(false);
            this.asientosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private Data.DataSet1TableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.ComboBox id_proveedorComboBox;
        private System.Windows.Forms.DateTimePicker fechaFacturaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaPagoDateTimePicker;
        private System.Windows.Forms.TextBox formaPagoTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NumericUpDown ImporteNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}