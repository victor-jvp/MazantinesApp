namespace ManzantinesApp.Liquidaciones
{
    partial class FrmAddLiquidacion
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
            System.Windows.Forms.Label categoriaLabel1;
            System.Windows.Forms.Label totalesLabel1;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label id_empresaLabel;
            System.Windows.Forms.Label nroLiquidacionLabel;
            System.Windows.Forms.Label nroFacturaLabel;
            System.Windows.Forms.Label fechaPagoLabel;
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label variedadLabel;
            System.Windows.Forms.Label fincaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddLiquidacion));
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.liquidacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liquidacionesTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.LiquidacionesTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.totalesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pagadoCheckBox = new System.Windows.Forms.CheckBox();
            this.id_empresaComboBox = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EmpresasTableAdapter();
            this.nroLiquidacionTextBox = new System.Windows.Forms.TextBox();
            this.nroFacturaTextBox = new System.Windows.Forms.TextBox();
            this.fechaPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.liquidacionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.liquidacionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.id_frutaComboBox = new System.Windows.Forms.ComboBox();
            this.frutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frutasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.FrutasTableAdapter();
            this.VariedadComboBox = new System.Windows.Forms.ComboBox();
            this.frutasvariedadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fincasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fincasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.FincasTableAdapter();
            this.fincaComboBox = new System.Windows.Forms.ComboBox();
            this.frutas_variedadesTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.Frutas_variedadesTableAdapter();
            categoriaLabel1 = new System.Windows.Forms.Label();
            totalesLabel1 = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            id_empresaLabel = new System.Windows.Forms.Label();
            nroLiquidacionLabel = new System.Windows.Forms.Label();
            nroFacturaLabel = new System.Windows.Forms.Label();
            fechaPagoLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            variedadLabel = new System.Windows.Forms.Label();
            fincaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingNavigator)).BeginInit();
            this.liquidacionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frutasvariedadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fincasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaLabel1
            // 
            categoriaLabel1.AutoSize = true;
            categoriaLabel1.Location = new System.Drawing.Point(41, 93);
            categoriaLabel1.Name = "categoriaLabel1";
            categoriaLabel1.Size = new System.Drawing.Size(55, 13);
            categoriaLabel1.TabIndex = 10;
            categoriaLabel1.Text = "Categoria:";
            // 
            // totalesLabel1
            // 
            totalesLabel1.AutoSize = true;
            totalesLabel1.Location = new System.Drawing.Point(51, 118);
            totalesLabel1.Name = "totalesLabel1";
            totalesLabel1.Size = new System.Drawing.Size(45, 13);
            totalesLabel1.TabIndex = 16;
            totalesLabel1.Text = "Totales:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(56, 42);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 0;
            fechaLabel.Text = "Fecha:";
            // 
            // id_empresaLabel
            // 
            id_empresaLabel.AutoSize = true;
            id_empresaLabel.Location = new System.Drawing.Point(385, 119);
            id_empresaLabel.Name = "id_empresaLabel";
            id_empresaLabel.Size = new System.Drawing.Size(51, 13);
            id_empresaLabel.TabIndex = 20;
            id_empresaLabel.Text = "Empresa:";
            // 
            // nroLiquidacionLabel
            // 
            nroLiquidacionLabel.AutoSize = true;
            nroLiquidacionLabel.Location = new System.Drawing.Point(206, 42);
            nroLiquidacionLabel.Name = "nroLiquidacionLabel";
            nroLiquidacionLabel.Size = new System.Drawing.Size(84, 13);
            nroLiquidacionLabel.TabIndex = 2;
            nroLiquidacionLabel.Text = "Nro Liquidacion:";
            // 
            // nroFacturaLabel
            // 
            nroFacturaLabel.AutoSize = true;
            nroFacturaLabel.Location = new System.Drawing.Point(222, 67);
            nroFacturaLabel.Name = "nroFacturaLabel";
            nroFacturaLabel.Size = new System.Drawing.Size(66, 13);
            nroFacturaLabel.TabIndex = 6;
            nroFacturaLabel.Text = "Nro Factura:";
            // 
            // fechaPagoLabel
            // 
            fechaPagoLabel.AutoSize = true;
            fechaPagoLabel.Location = new System.Drawing.Point(28, 67);
            fechaPagoLabel.Name = "fechaPagoLabel";
            fechaPagoLabel.Size = new System.Drawing.Size(68, 13);
            fechaPagoLabel.TabIndex = 4;
            fechaPagoLabel.Text = "Fecha Pago:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Location = new System.Drawing.Point(396, 67);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(41, 13);
            bancoLabel.TabIndex = 8;
            bancoLabel.Text = "Banco:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(213, 93);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 13);
            label1.TabIndex = 12;
            label1.Text = "Fruta:";
            // 
            // variedadLabel
            // 
            variedadLabel.AutoSize = true;
            variedadLabel.Location = new System.Drawing.Point(385, 93);
            variedadLabel.Name = "variedadLabel";
            variedadLabel.Size = new System.Drawing.Size(52, 13);
            variedadLabel.TabIndex = 14;
            variedadLabel.Text = "Variedad:";
            // 
            // fincaLabel
            // 
            fincaLabel.AutoSize = true;
            fincaLabel.Location = new System.Drawing.Point(211, 119);
            fincaLabel.Name = "fincaLabel";
            fincaLabel.Size = new System.Drawing.Size(36, 13);
            fincaLabel.TabIndex = 18;
            fincaLabel.Text = "Finca:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // liquidacionesBindingSource
            // 
            this.liquidacionesBindingSource.DataMember = "Liquidaciones";
            this.liquidacionesBindingSource.DataSource = this.dataSet1;
            // 
            // liquidacionesTableAdapter
            // 
            this.liquidacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsientosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasasTableAdapter = null;
            this.tableAdapterManager.EmpleosPagosTableAdapter = null;
            this.tableAdapterManager.EmpleosTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EncargadosTableAdapter = null;
            this.tableAdapterManager.FincasTableAdapter = null;
            this.tableAdapterManager.Frutas_variedadesTableAdapter = null;
            this.tableAdapterManager.FrutasTableAdapter = null;
            this.tableAdapterManager.LiquidacionesTableAdapter = this.liquidacionesTableAdapter;
            this.tableAdapterManager.NominasCabTableAdapter = null;
            this.tableAdapterManager.NominasDetTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Trabajadores_EmpleosTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.liquidacionesBindingSource, "Categoria", true));
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.categoriaComboBox.Location = new System.Drawing.Point(104, 89);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(98, 21);
            this.categoriaComboBox.TabIndex = 11;
            // 
            // totalesNumericUpDown
            // 
            this.totalesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionesBindingSource, "Totales", true));
            this.totalesNumericUpDown.DecimalPlaces = 2;
            this.totalesNumericUpDown.Location = new System.Drawing.Point(102, 116);
            this.totalesNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.totalesNumericUpDown.Name = "totalesNumericUpDown";
            this.totalesNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.totalesNumericUpDown.TabIndex = 17;
            this.totalesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalesNumericUpDown.ThousandsSeparator = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionesBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(102, 38);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaDateTimePicker.TabIndex = 1;
            // 
            // pagadoCheckBox
            // 
            this.pagadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.liquidacionesBindingSource, "Pagado", true));
            this.pagadoCheckBox.Location = new System.Drawing.Point(509, 34);
            this.pagadoCheckBox.Name = "pagadoCheckBox";
            this.pagadoCheckBox.Size = new System.Drawing.Size(71, 24);
            this.pagadoCheckBox.TabIndex = 22;
            this.pagadoCheckBox.Text = "Pagado";
            this.pagadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // id_empresaComboBox
            // 
            this.id_empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.liquidacionesBindingSource, "id_empresa", true));
            this.id_empresaComboBox.DataSource = this.empresasBindingSource;
            this.id_empresaComboBox.DisplayMember = "Empresa";
            this.id_empresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_empresaComboBox.FormattingEnabled = true;
            this.id_empresaComboBox.Location = new System.Drawing.Point(443, 116);
            this.id_empresaComboBox.Name = "id_empresaComboBox";
            this.id_empresaComboBox.Size = new System.Drawing.Size(137, 21);
            this.id_empresaComboBox.TabIndex = 21;
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
            // nroLiquidacionTextBox
            // 
            this.nroLiquidacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "NroLiquidacion", true));
            this.nroLiquidacionTextBox.Location = new System.Drawing.Point(294, 38);
            this.nroLiquidacionTextBox.Name = "nroLiquidacionTextBox";
            this.nroLiquidacionTextBox.Size = new System.Drawing.Size(80, 20);
            this.nroLiquidacionTextBox.TabIndex = 3;
            // 
            // nroFacturaTextBox
            // 
            this.nroFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "NroFactura", true));
            this.nroFacturaTextBox.Location = new System.Drawing.Point(294, 63);
            this.nroFacturaTextBox.Name = "nroFacturaTextBox";
            this.nroFacturaTextBox.Size = new System.Drawing.Size(80, 20);
            this.nroFacturaTextBox.TabIndex = 7;
            // 
            // fechaPagoDateTimePicker
            // 
            this.fechaPagoDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.fechaPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionesBindingSource, "FechaPago", true));
            this.fechaPagoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaPagoDateTimePicker.Location = new System.Drawing.Point(102, 63);
            this.fechaPagoDateTimePicker.Name = "fechaPagoDateTimePicker";
            this.fechaPagoDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaPagoDateTimePicker.TabIndex = 5;
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(443, 63);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(137, 20);
            this.bancoTextBox.TabIndex = 9;
            // 
            // liquidacionesBindingNavigatorSaveItem
            // 
            this.liquidacionesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("liquidacionesBindingNavigatorSaveItem.Image")));
            this.liquidacionesBindingNavigatorSaveItem.Name = "liquidacionesBindingNavigatorSaveItem";
            this.liquidacionesBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.liquidacionesBindingNavigatorSaveItem.Text = "Guardar";
            this.liquidacionesBindingNavigatorSaveItem.Click += new System.EventHandler(this.LiquidacionesBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // liquidacionesBindingNavigator
            // 
            this.liquidacionesBindingNavigator.AddNewItem = null;
            this.liquidacionesBindingNavigator.BindingSource = this.liquidacionesBindingSource;
            this.liquidacionesBindingNavigator.CountItem = null;
            this.liquidacionesBindingNavigator.DeleteItem = null;
            this.liquidacionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liquidacionesBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.liquidacionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.liquidacionesBindingNavigator.MoveFirstItem = null;
            this.liquidacionesBindingNavigator.MoveLastItem = null;
            this.liquidacionesBindingNavigator.MoveNextItem = null;
            this.liquidacionesBindingNavigator.MovePreviousItem = null;
            this.liquidacionesBindingNavigator.Name = "liquidacionesBindingNavigator";
            this.liquidacionesBindingNavigator.PositionItem = null;
            this.liquidacionesBindingNavigator.Size = new System.Drawing.Size(618, 25);
            this.liquidacionesBindingNavigator.TabIndex = 23;
            this.liquidacionesBindingNavigator.Text = "bindingNavigator1";
            // 
            // id_frutaComboBox
            // 
            this.id_frutaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.liquidacionesBindingSource, "id_fruta", true));
            this.id_frutaComboBox.DataSource = this.frutasBindingSource;
            this.id_frutaComboBox.DisplayMember = "Fruta";
            this.id_frutaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_frutaComboBox.FormattingEnabled = true;
            this.id_frutaComboBox.Location = new System.Drawing.Point(253, 89);
            this.id_frutaComboBox.Name = "id_frutaComboBox";
            this.id_frutaComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_frutaComboBox.TabIndex = 13;
            this.id_frutaComboBox.ValueMember = "Id";
            this.id_frutaComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // frutasBindingSource
            // 
            this.frutasBindingSource.DataMember = "Frutas";
            this.frutasBindingSource.DataSource = this.dataSet1;
            // 
            // frutasTableAdapter
            // 
            this.frutasTableAdapter.ClearBeforeFill = true;
            // 
            // VariedadComboBox
            // 
            this.VariedadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.liquidacionesBindingSource, "Variedad", true));
            this.VariedadComboBox.DataSource = this.frutasvariedadesBindingSource;
            this.VariedadComboBox.DisplayMember = "Variedad";
            this.VariedadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VariedadComboBox.FormattingEnabled = true;
            this.VariedadComboBox.Location = new System.Drawing.Point(443, 89);
            this.VariedadComboBox.Name = "VariedadComboBox";
            this.VariedadComboBox.Size = new System.Drawing.Size(137, 21);
            this.VariedadComboBox.TabIndex = 15;
            this.VariedadComboBox.ValueMember = "Variedad";
            // 
            // frutasvariedadesBindingSource
            // 
            this.frutasvariedadesBindingSource.DataMember = "Frutas_variedades";
            this.frutasvariedadesBindingSource.DataSource = this.dataSet1;
            // 
            // fincasBindingSource
            // 
            this.fincasBindingSource.DataMember = "Fincas";
            this.fincasBindingSource.DataSource = this.dataSet1;
            // 
            // fincasTableAdapter
            // 
            this.fincasTableAdapter.ClearBeforeFill = true;
            // 
            // fincaComboBox
            // 
            this.fincaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.liquidacionesBindingSource, "id_finca", true));
            this.fincaComboBox.DataSource = this.fincasBindingSource;
            this.fincaComboBox.DisplayMember = "Finca";
            this.fincaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fincaComboBox.FormattingEnabled = true;
            this.fincaComboBox.Location = new System.Drawing.Point(253, 116);
            this.fincaComboBox.Name = "fincaComboBox";
            this.fincaComboBox.Size = new System.Drawing.Size(121, 21);
            this.fincaComboBox.TabIndex = 19;
            this.fincaComboBox.ValueMember = "Id";
            // 
            // frutas_variedadesTableAdapter
            // 
            this.frutas_variedadesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 161);
            this.Controls.Add(fincaLabel);
            this.Controls.Add(this.fincaComboBox);
            this.Controls.Add(variedadLabel);
            this.Controls.Add(this.VariedadComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.id_frutaComboBox);
            this.Controls.Add(bancoLabel);
            this.Controls.Add(this.bancoTextBox);
            this.Controls.Add(fechaPagoLabel);
            this.Controls.Add(this.fechaPagoDateTimePicker);
            this.Controls.Add(nroFacturaLabel);
            this.Controls.Add(this.nroFacturaTextBox);
            this.Controls.Add(nroLiquidacionLabel);
            this.Controls.Add(this.nroLiquidacionTextBox);
            this.Controls.Add(id_empresaLabel);
            this.Controls.Add(this.id_empresaComboBox);
            this.Controls.Add(this.pagadoCheckBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(totalesLabel1);
            this.Controls.Add(this.totalesNumericUpDown);
            this.Controls.Add(categoriaLabel1);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.liquidacionesBindingNavigator);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "Variedad", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Liquidación";
            this.Load += new System.EventHandler(this.FrmAddLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingNavigator)).EndInit();
            this.liquidacionesBindingNavigator.ResumeLayout(false);
            this.liquidacionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frutasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frutasvariedadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fincasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource liquidacionesBindingSource;
        private Data.DataSet1TableAdapters.LiquidacionesTableAdapter liquidacionesTableAdapter;
        private Data.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.NumericUpDown totalesNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox pagadoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox id_empresaComboBox;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private Data.DataSet1TableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.DateTimePicker fechaPagoDateTimePicker;
        private System.Windows.Forms.TextBox nroFacturaTextBox;
        private System.Windows.Forms.TextBox nroLiquidacionTextBox;
        private System.Windows.Forms.BindingNavigator liquidacionesBindingNavigator;
        private System.Windows.Forms.ToolStripButton liquidacionesBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox id_frutaComboBox;
        private System.Windows.Forms.BindingSource frutasBindingSource;
        private Data.DataSet1TableAdapters.FrutasTableAdapter frutasTableAdapter;
        private System.Windows.Forms.ComboBox VariedadComboBox;
        private System.Windows.Forms.BindingSource fincasBindingSource;
        private Data.DataSet1TableAdapters.FincasTableAdapter fincasTableAdapter;
        private System.Windows.Forms.ComboBox fincaComboBox;
        private System.Windows.Forms.BindingSource frutasvariedadesBindingSource;
        private Data.DataSet1TableAdapters.Frutas_variedadesTableAdapter frutas_variedadesTableAdapter;
    }
}