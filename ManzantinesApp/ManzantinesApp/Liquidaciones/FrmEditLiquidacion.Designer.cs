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
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label fechaPagoLabel;
            System.Windows.Forms.Label nroFacturaLabel;
            System.Windows.Forms.Label nroLiquidacionLabel;
            System.Windows.Forms.Label id_empresaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label totalesLabel1;
            System.Windows.Forms.Label categoriaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditLiquidacion));
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.liquidacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liquidacionesTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.LiquidacionesTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.liquidacionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.liquidacionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EmpresasTableAdapter();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.fechaPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nroFacturaTextBox = new System.Windows.Forms.TextBox();
            this.nroLiquidacionTextBox = new System.Windows.Forms.TextBox();
            this.id_empresaComboBox = new System.Windows.Forms.ComboBox();
            this.pagadoCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
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
            this.SuspendLayout();
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Location = new System.Drawing.Point(54, 89);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(41, 13);
            bancoLabel.TabIndex = 33;
            bancoLabel.Text = "Banco:";
            // 
            // fechaPagoLabel
            // 
            fechaPagoLabel.AutoSize = true;
            fechaPagoLabel.Location = new System.Drawing.Point(219, 38);
            fechaPagoLabel.Name = "fechaPagoLabel";
            fechaPagoLabel.Size = new System.Drawing.Size(68, 13);
            fechaPagoLabel.TabIndex = 31;
            fechaPagoLabel.Text = "Fecha Pago:";
            // 
            // nroFacturaLabel
            // 
            nroFacturaLabel.AutoSize = true;
            nroFacturaLabel.Location = new System.Drawing.Point(221, 64);
            nroFacturaLabel.Name = "nroFacturaLabel";
            nroFacturaLabel.Size = new System.Drawing.Size(66, 13);
            nroFacturaLabel.TabIndex = 28;
            nroFacturaLabel.Text = "Nro Factura:";
            // 
            // nroLiquidacionLabel
            // 
            nroLiquidacionLabel.AutoSize = true;
            nroLiquidacionLabel.Location = new System.Drawing.Point(13, 64);
            nroLiquidacionLabel.Name = "nroLiquidacionLabel";
            nroLiquidacionLabel.Size = new System.Drawing.Size(84, 13);
            nroLiquidacionLabel.TabIndex = 26;
            nroLiquidacionLabel.Text = "Nro Liquidacion:";
            // 
            // id_empresaLabel
            // 
            id_empresaLabel.AutoSize = true;
            id_empresaLabel.Location = new System.Drawing.Point(46, 144);
            id_empresaLabel.Name = "id_empresaLabel";
            id_empresaLabel.Size = new System.Drawing.Size(51, 13);
            id_empresaLabel.TabIndex = 25;
            id_empresaLabel.Text = "Empresa:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(57, 38);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 22;
            fechaLabel.Text = "Fecha:";
            // 
            // totalesLabel1
            // 
            totalesLabel1.AutoSize = true;
            totalesLabel1.Location = new System.Drawing.Point(242, 117);
            totalesLabel1.Name = "totalesLabel1";
            totalesLabel1.Size = new System.Drawing.Size(45, 13);
            totalesLabel1.TabIndex = 20;
            totalesLabel1.Text = "Totales:";
            // 
            // categoriaLabel1
            // 
            categoriaLabel1.AutoSize = true;
            categoriaLabel1.Location = new System.Drawing.Point(42, 119);
            categoriaLabel1.Name = "categoriaLabel1";
            categoriaLabel1.Size = new System.Drawing.Size(55, 13);
            categoriaLabel1.TabIndex = 18;
            categoriaLabel1.Text = "Categoria:";
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
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.liquidacionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.liquidacionesBindingNavigator.MoveFirstItem = null;
            this.liquidacionesBindingNavigator.MoveLastItem = null;
            this.liquidacionesBindingNavigator.MoveNextItem = null;
            this.liquidacionesBindingNavigator.MovePreviousItem = null;
            this.liquidacionesBindingNavigator.Name = "liquidacionesBindingNavigator";
            this.liquidacionesBindingNavigator.PositionItem = null;
            this.liquidacionesBindingNavigator.Size = new System.Drawing.Size(425, 25);
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ManzantinesApp.Properties.Resources.iconfinder_table_sum_64786;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton1.Text = "Kilogramos";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
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
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(101, 86);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(292, 20);
            this.bancoTextBox.TabIndex = 34;
            // 
            // fechaPagoDateTimePicker
            // 
            this.fechaPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionesBindingSource, "FechaPago", true));
            this.fechaPagoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPagoDateTimePicker.Location = new System.Drawing.Point(293, 34);
            this.fechaPagoDateTimePicker.Name = "fechaPagoDateTimePicker";
            this.fechaPagoDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaPagoDateTimePicker.TabIndex = 32;
            // 
            // nroFacturaTextBox
            // 
            this.nroFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "NroFactura", true));
            this.nroFacturaTextBox.Location = new System.Drawing.Point(293, 60);
            this.nroFacturaTextBox.Name = "nroFacturaTextBox";
            this.nroFacturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nroFacturaTextBox.TabIndex = 30;
            // 
            // nroLiquidacionTextBox
            // 
            this.nroLiquidacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "NroLiquidacion", true));
            this.nroLiquidacionTextBox.Location = new System.Drawing.Point(101, 60);
            this.nroLiquidacionTextBox.Name = "nroLiquidacionTextBox";
            this.nroLiquidacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.nroLiquidacionTextBox.TabIndex = 29;
            // 
            // id_empresaComboBox
            // 
            this.id_empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.liquidacionesBindingSource, "id_empresa", true));
            this.id_empresaComboBox.DataSource = this.empresasBindingSource;
            this.id_empresaComboBox.DisplayMember = "Empresa";
            this.id_empresaComboBox.FormattingEnabled = true;
            this.id_empresaComboBox.Location = new System.Drawing.Point(101, 141);
            this.id_empresaComboBox.Name = "id_empresaComboBox";
            this.id_empresaComboBox.Size = new System.Drawing.Size(186, 21);
            this.id_empresaComboBox.TabIndex = 27;
            this.id_empresaComboBox.ValueMember = "Id";
            // 
            // pagadoCheckBox
            // 
            this.pagadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.liquidacionesBindingSource, "Pagado", true));
            this.pagadoCheckBox.Location = new System.Drawing.Point(322, 139);
            this.pagadoCheckBox.Name = "pagadoCheckBox";
            this.pagadoCheckBox.Size = new System.Drawing.Size(71, 24);
            this.pagadoCheckBox.TabIndex = 24;
            this.pagadoCheckBox.Text = "Pagado";
            this.pagadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionesBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(101, 34);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaDateTimePicker.TabIndex = 23;
            // 
            // totalesNumericUpDown
            // 
            this.totalesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionesBindingSource, "Totales", true));
            this.totalesNumericUpDown.DecimalPlaces = 2;
            this.totalesNumericUpDown.Location = new System.Drawing.Point(293, 115);
            this.totalesNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.totalesNumericUpDown.Name = "totalesNumericUpDown";
            this.totalesNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.totalesNumericUpDown.TabIndex = 21;
            this.totalesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalesNumericUpDown.ThousandsSeparator = true;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionesBindingSource, "Categoria", true));
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.categoriaComboBox.Location = new System.Drawing.Point(101, 114);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(73, 21);
            this.categoriaComboBox.TabIndex = 19;
            // 
            // FrmEditLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 186);
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
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.DateTimePicker fechaPagoDateTimePicker;
        private System.Windows.Forms.TextBox nroFacturaTextBox;
        private System.Windows.Forms.TextBox nroLiquidacionTextBox;
        private System.Windows.Forms.ComboBox id_empresaComboBox;
        private System.Windows.Forms.CheckBox pagadoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.NumericUpDown totalesNumericUpDown;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}