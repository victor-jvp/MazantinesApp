namespace ManzantinesApp.Liquidaciones
{
    partial class FrmEditLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditLiquidacion));
            System.Windows.Forms.Label fincaLabel;
            System.Windows.Forms.Label variedadLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label fechaPagoLabel;
            System.Windows.Forms.Label nroFacturaLabel;
            System.Windows.Forms.Label nroLiquidacionLabel;
            System.Windows.Forms.Label id_empresaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label totalesLabel1;
            System.Windows.Forms.Label categoriaLabel1;
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.liquidacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liquidacionesTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.LiquidacionesTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.liquidacionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.liquidacionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EmpresasTableAdapter();
            this.fincaComboBox = new System.Windows.Forms.ComboBox();
            this.VariedadComboBox = new System.Windows.Forms.ComboBox();
            this.id_frutaComboBox = new System.Windows.Forms.ComboBox();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.fechaPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nroFacturaTextBox = new System.Windows.Forms.TextBox();
            this.nroLiquidacionTextBox = new System.Windows.Forms.TextBox();
            this.id_empresaComboBox = new System.Windows.Forms.ComboBox();
            this.pagadoCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.frutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frutasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.FrutasTableAdapter();
            this.frutasvariedadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frutas_variedadesTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.Frutas_variedadesTableAdapter();
            this.fincasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fincasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.FincasTableAdapter();
            fincaLabel = new System.Windows.Forms.Label();
            variedadLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            fechaPagoLabel = new System.Windows.Forms.Label();
            nroFacturaLabel = new System.Windows.Forms.Label();
            nroLiquidacionLabel = new System.Windows.Forms.Label();
            id_empresaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            totalesLabel1 = new System.Windows.Forms.Label();
            categoriaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingNavigator)).BeginInit();
            this.liquidacionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frutasvariedadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fincasBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.liquidacionesBindingNavigator.Size = new System.Drawing.Size(595, 25);
            this.liquidacionesBindingNavigator.TabIndex = 11;
            this.liquidacionesBindingNavigator.Text = "bindingNavigator1";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // fincaLabel
            // 
            fincaLabel.AutoSize = true;
            fincaLabel.Location = new System.Drawing.Point(205, 115);
            fincaLabel.Name = "fincaLabel";
            fincaLabel.Size = new System.Drawing.Size(36, 13);
            fincaLabel.TabIndex = 41;
            fincaLabel.Text = "Finca:";
            // 
            // fincaComboBox
            // 
            this.fincaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.liquidacionesBindingSource, "id_finca", true));
            this.fincaComboBox.DataSource = this.fincasBindingSource;
            this.fincaComboBox.DisplayMember = "Finca";
            this.fincaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fincaComboBox.FormattingEnabled = true;
            this.fincaComboBox.Location = new System.Drawing.Point(247, 112);
            this.fincaComboBox.Name = "fincaComboBox";
            this.fincaComboBox.Size = new System.Drawing.Size(121, 21);
            this.fincaComboBox.TabIndex = 42;
            this.fincaComboBox.ValueMember = "Id";
            // 
            // variedadLabel
            // 
            variedadLabel.AutoSize = true;
            variedadLabel.Location = new System.Drawing.Point(379, 89);
            variedadLabel.Name = "variedadLabel";
            variedadLabel.Size = new System.Drawing.Size(52, 13);
            variedadLabel.TabIndex = 37;
            variedadLabel.Text = "Variedad:";
            // 
            // VariedadComboBox
            // 
            this.VariedadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.liquidacionesBindingSource, "Variedad", true));
            this.VariedadComboBox.DataSource = this.frutasvariedadesBindingSource;
            this.VariedadComboBox.DisplayMember = "Variedad";
            this.VariedadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VariedadComboBox.FormattingEnabled = true;
            this.VariedadComboBox.Location = new System.Drawing.Point(437, 85);
            this.VariedadComboBox.Name = "VariedadComboBox";
            this.VariedadComboBox.Size = new System.Drawing.Size(137, 21);
            this.VariedadComboBox.TabIndex = 38;
            this.VariedadComboBox.ValueMember = "Variedad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(207, 89);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 13);
            label1.TabIndex = 35;
            label1.Text = "Fruta:";
            // 
            // id_frutaComboBox
            // 
            this.id_frutaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.liquidacionesBindingSource, "id_fruta", true));
            this.id_frutaComboBox.DataSource = this.frutasBindingSource;
            this.id_frutaComboBox.DisplayMember = "Fruta";
            this.id_frutaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_frutaComboBox.FormattingEnabled = true;
            this.id_frutaComboBox.Location = new System.Drawing.Point(247, 85);
            this.id_frutaComboBox.Name = "id_frutaComboBox";
            this.id_frutaComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_frutaComboBox.TabIndex = 36;
            this.id_frutaComboBox.ValueMember = "Id";
            this.id_frutaComboBox.SelectedValueChanged += new System.EventHandler(this.id_frutaComboBox_SelectedValueChanged);
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Location = new System.Drawing.Point(390, 63);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(41, 13);
            bancoLabel.TabIndex = 31;
            bancoLabel.Text = "Banco:";
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(437, 59);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(137, 20);
            this.bancoTextBox.TabIndex = 32;
            // 
            // fechaPagoLabel
            // 
            fechaPagoLabel.AutoSize = true;
            fechaPagoLabel.Location = new System.Drawing.Point(22, 63);
            fechaPagoLabel.Name = "fechaPagoLabel";
            fechaPagoLabel.Size = new System.Drawing.Size(68, 13);
            fechaPagoLabel.TabIndex = 27;
            fechaPagoLabel.Text = "Fecha Pago:";
            // 
            // fechaPagoDateTimePicker
            // 
            this.fechaPagoDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.fechaPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionesBindingSource, "FechaPago", true));
            this.fechaPagoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaPagoDateTimePicker.Location = new System.Drawing.Point(96, 59);
            this.fechaPagoDateTimePicker.Name = "fechaPagoDateTimePicker";
            this.fechaPagoDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaPagoDateTimePicker.TabIndex = 28;
            // 
            // nroFacturaLabel
            // 
            nroFacturaLabel.AutoSize = true;
            nroFacturaLabel.Location = new System.Drawing.Point(216, 63);
            nroFacturaLabel.Name = "nroFacturaLabel";
            nroFacturaLabel.Size = new System.Drawing.Size(66, 13);
            nroFacturaLabel.TabIndex = 29;
            nroFacturaLabel.Text = "Nro Factura:";
            // 
            // nroFacturaTextBox
            // 
            this.nroFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "NroFactura", true));
            this.nroFacturaTextBox.Location = new System.Drawing.Point(288, 59);
            this.nroFacturaTextBox.Name = "nroFacturaTextBox";
            this.nroFacturaTextBox.Size = new System.Drawing.Size(80, 20);
            this.nroFacturaTextBox.TabIndex = 30;
            // 
            // nroLiquidacionLabel
            // 
            nroLiquidacionLabel.AutoSize = true;
            nroLiquidacionLabel.Location = new System.Drawing.Point(200, 38);
            nroLiquidacionLabel.Name = "nroLiquidacionLabel";
            nroLiquidacionLabel.Size = new System.Drawing.Size(84, 13);
            nroLiquidacionLabel.TabIndex = 25;
            nroLiquidacionLabel.Text = "Nro Liquidacion:";
            // 
            // nroLiquidacionTextBox
            // 
            this.nroLiquidacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "NroLiquidacion", true));
            this.nroLiquidacionTextBox.Location = new System.Drawing.Point(288, 34);
            this.nroLiquidacionTextBox.Name = "nroLiquidacionTextBox";
            this.nroLiquidacionTextBox.Size = new System.Drawing.Size(80, 20);
            this.nroLiquidacionTextBox.TabIndex = 26;
            // 
            // id_empresaLabel
            // 
            id_empresaLabel.AutoSize = true;
            id_empresaLabel.Location = new System.Drawing.Point(379, 115);
            id_empresaLabel.Name = "id_empresaLabel";
            id_empresaLabel.Size = new System.Drawing.Size(51, 13);
            id_empresaLabel.TabIndex = 43;
            id_empresaLabel.Text = "Empresa:";
            // 
            // id_empresaComboBox
            // 
            this.id_empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.liquidacionesBindingSource, "id_empresa", true));
            this.id_empresaComboBox.DataSource = this.empresasBindingSource;
            this.id_empresaComboBox.DisplayMember = "Empresa";
            this.id_empresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_empresaComboBox.FormattingEnabled = true;
            this.id_empresaComboBox.Location = new System.Drawing.Point(437, 112);
            this.id_empresaComboBox.Name = "id_empresaComboBox";
            this.id_empresaComboBox.Size = new System.Drawing.Size(137, 21);
            this.id_empresaComboBox.TabIndex = 44;
            this.id_empresaComboBox.ValueMember = "Id";
            // 
            // pagadoCheckBox
            // 
            this.pagadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.liquidacionesBindingSource, "Pagado", true));
            this.pagadoCheckBox.Location = new System.Drawing.Point(503, 30);
            this.pagadoCheckBox.Name = "pagadoCheckBox";
            this.pagadoCheckBox.Size = new System.Drawing.Size(71, 24);
            this.pagadoCheckBox.TabIndex = 45;
            this.pagadoCheckBox.Text = "Pagado";
            this.pagadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(50, 38);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 23;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionesBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(96, 34);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaDateTimePicker.TabIndex = 24;
            // 
            // totalesLabel1
            // 
            totalesLabel1.AutoSize = true;
            totalesLabel1.Location = new System.Drawing.Point(45, 114);
            totalesLabel1.Name = "totalesLabel1";
            totalesLabel1.Size = new System.Drawing.Size(45, 13);
            totalesLabel1.TabIndex = 39;
            totalesLabel1.Text = "Totales:";
            // 
            // totalesNumericUpDown
            // 
            this.totalesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionesBindingSource, "Totales", true));
            this.totalesNumericUpDown.DecimalPlaces = 2;
            this.totalesNumericUpDown.Location = new System.Drawing.Point(96, 112);
            this.totalesNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.totalesNumericUpDown.Name = "totalesNumericUpDown";
            this.totalesNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.totalesNumericUpDown.TabIndex = 40;
            this.totalesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalesNumericUpDown.ThousandsSeparator = true;
            // 
            // categoriaLabel1
            // 
            categoriaLabel1.AutoSize = true;
            categoriaLabel1.Location = new System.Drawing.Point(35, 89);
            categoriaLabel1.Name = "categoriaLabel1";
            categoriaLabel1.Size = new System.Drawing.Size(55, 13);
            categoriaLabel1.TabIndex = 33;
            categoriaLabel1.Text = "Categoria:";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.liquidacionesBindingSource, "Categoria", true));
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.categoriaComboBox.Location = new System.Drawing.Point(98, 85);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(98, 21);
            this.categoriaComboBox.TabIndex = 34;
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
            // frutasvariedadesBindingSource
            // 
            this.frutasvariedadesBindingSource.DataMember = "Frutas_variedades";
            this.frutasvariedadesBindingSource.DataSource = this.dataSet1;
            // 
            // frutas_variedadesTableAdapter
            // 
            this.frutas_variedadesTableAdapter.ClearBeforeFill = true;
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
            // FrmEditLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 158);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEditLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Liquidacion";
            this.Load += new System.EventHandler(this.FrmEditLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingNavigator)).EndInit();
            this.liquidacionesBindingNavigator.ResumeLayout(false);
            this.liquidacionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesNumericUpDown)).EndInit();
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
        private System.Windows.Forms.BindingNavigator liquidacionesBindingNavigator;
        private System.Windows.Forms.ToolStripButton liquidacionesBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private Data.DataSet1TableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.ComboBox fincaComboBox;
        private System.Windows.Forms.ComboBox VariedadComboBox;
        private System.Windows.Forms.ComboBox id_frutaComboBox;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.DateTimePicker fechaPagoDateTimePicker;
        private System.Windows.Forms.TextBox nroFacturaTextBox;
        private System.Windows.Forms.TextBox nroLiquidacionTextBox;
        private System.Windows.Forms.ComboBox id_empresaComboBox;
        private System.Windows.Forms.CheckBox pagadoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.NumericUpDown totalesNumericUpDown;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.BindingSource frutasBindingSource;
        private Data.DataSet1TableAdapters.FrutasTableAdapter frutasTableAdapter;
        private System.Windows.Forms.BindingSource frutasvariedadesBindingSource;
        private Data.DataSet1TableAdapters.Frutas_variedadesTableAdapter frutas_variedadesTableAdapter;
        private System.Windows.Forms.BindingSource fincasBindingSource;
        private Data.DataSet1TableAdapters.FincasTableAdapter fincasTableAdapter;
    }
}