namespace ManzantinesApp
{
    partial class FrmEditProveedor
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
            System.Windows.Forms.Label cifLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label nroCuentaLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.proveedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.proveedoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cifTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.nroCuentaTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.asientosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.ProveedoresTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.asientosTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.AsientosTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproveedorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFacturaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cifLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            nroCuentaLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingNavigator)).BeginInit();
            this.proveedoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cifLabel
            // 
            cifLabel.AutoSize = true;
            cifLabel.Location = new System.Drawing.Point(76, 24);
            cifLabel.Name = "cifLabel";
            cifLabel.Size = new System.Drawing.Size(26, 13);
            cifLabel.TabIndex = 1;
            cifLabel.Text = "CIF:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(29, 50);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 3;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Location = new System.Drawing.Point(61, 76);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(41, 13);
            bancoLabel.TabIndex = 5;
            bancoLabel.Text = "Banco:";
            // 
            // nroCuentaLabel
            // 
            nroCuentaLabel.AutoSize = true;
            nroCuentaLabel.Location = new System.Drawing.Point(35, 102);
            nroCuentaLabel.Name = "nroCuentaLabel";
            nroCuentaLabel.Size = new System.Drawing.Size(67, 13);
            nroCuentaLabel.TabIndex = 7;
            nroCuentaLabel.Text = "Nro. Cuenta:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(50, 128);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "Teléfono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(67, 154);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(251, 24);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 13;
            idLabel.Text = "Id:";
            idLabel.Visible = false;
            // 
            // proveedoresBindingNavigator
            // 
            this.proveedoresBindingNavigator.AddNewItem = null;
            this.proveedoresBindingNavigator.BindingSource = this.proveedoresBindingSource;
            this.proveedoresBindingNavigator.CountItem = null;
            this.proveedoresBindingNavigator.DeleteItem = null;
            this.proveedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.proveedoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proveedoresBindingNavigator.MoveFirstItem = null;
            this.proveedoresBindingNavigator.MoveLastItem = null;
            this.proveedoresBindingNavigator.MoveNextItem = null;
            this.proveedoresBindingNavigator.MovePreviousItem = null;
            this.proveedoresBindingNavigator.Name = "proveedoresBindingNavigator";
            this.proveedoresBindingNavigator.PositionItem = null;
            this.proveedoresBindingNavigator.Size = new System.Drawing.Size(478, 25);
            this.proveedoresBindingNavigator.TabIndex = 0;
            this.proveedoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresBindingNavigatorSaveItem
            // 
            this.proveedoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresBindingNavigatorSaveItem.Image")));
            this.proveedoresBindingNavigatorSaveItem.Name = "proveedoresBindingNavigatorSaveItem";
            this.proveedoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.proveedoresBindingNavigatorSaveItem.Text = "&Guardar";
            this.proveedoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.ProveedoresBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cifTextBox
            // 
            this.cifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Cif", true));
            this.cifTextBox.Location = new System.Drawing.Point(108, 21);
            this.cifTextBox.Name = "cifTextBox";
            this.cifTextBox.Size = new System.Drawing.Size(100, 20);
            this.cifTextBox.TabIndex = 2;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(108, 47);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(268, 20);
            this.razonSocialTextBox.TabIndex = 4;
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(108, 73);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(160, 20);
            this.bancoTextBox.TabIndex = 6;
            // 
            // nroCuentaTextBox
            // 
            this.nroCuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "NroCuenta", true));
            this.nroCuentaTextBox.Location = new System.Drawing.Point(108, 99);
            this.nroCuentaTextBox.Name = "nroCuentaTextBox";
            this.nroCuentaTextBox.Size = new System.Drawing.Size(160, 20);
            this.nroCuentaTextBox.TabIndex = 8;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(108, 125);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(160, 20);
            this.telefonoTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(108, 151);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(160, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(276, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 236);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cifTextBox);
            this.tabPage1.Controls.Add(idLabel);
            this.tabPage1.Controls.Add(cifLabel);
            this.tabPage1.Controls.Add(this.idTextBox);
            this.tabPage1.Controls.Add(this.razonSocialTextBox);
            this.tabPage1.Controls.Add(emailLabel);
            this.tabPage1.Controls.Add(razonSocialLabel);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(this.bancoTextBox);
            this.tabPage1.Controls.Add(telefonoLabel);
            this.tabPage1.Controls.Add(bancoLabel);
            this.tabPage1.Controls.Add(this.telefonoTextBox);
            this.tabPage1.Controls.Add(this.nroCuentaTextBox);
            this.tabPage1.Controls.Add(nroCuentaLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ficha";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asientos Pendientes de Pagos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idproveedorDataGridViewTextBoxColumn,
            this.fechaFacturaDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.fechaPagoDataGridViewTextBoxColumn,
            this.formaPagoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asientosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(464, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // asientosBindingSource
            // 
            this.asientosBindingSource.DataMember = "Asientos";
            this.asientosBindingSource.DataSource = this.dataSet1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(470, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asientos Pagados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idproveedorDataGridViewTextBoxColumn1,
            this.fechaFacturaDataGridViewTextBoxColumn1,
            this.importeDataGridViewTextBoxColumn1,
            this.fechaPagoDataGridViewTextBoxColumn1,
            this.formaPagoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.asientosBindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(464, 204);
            this.dataGridView2.TabIndex = 0;
            // 
            // asientosBindingSource1
            // 
            this.asientosBindingSource1.DataMember = "Asientos";
            this.asientosBindingSource1.DataSource = this.dataSet1;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsientosTableAdapter = null;
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
            // asientosTableAdapter
            // 
            this.asientosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idproveedorDataGridViewTextBoxColumn1
            // 
            this.idproveedorDataGridViewTextBoxColumn1.DataPropertyName = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn1.HeaderText = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn1.Name = "idproveedorDataGridViewTextBoxColumn1";
            this.idproveedorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idproveedorDataGridViewTextBoxColumn1.Visible = false;
            // 
            // fechaFacturaDataGridViewTextBoxColumn1
            // 
            this.fechaFacturaDataGridViewTextBoxColumn1.DataPropertyName = "FechaFactura";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.fechaFacturaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.fechaFacturaDataGridViewTextBoxColumn1.HeaderText = "Fecha Factura";
            this.fechaFacturaDataGridViewTextBoxColumn1.Name = "fechaFacturaDataGridViewTextBoxColumn1";
            this.fechaFacturaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // importeDataGridViewTextBoxColumn1
            // 
            this.importeDataGridViewTextBoxColumn1.DataPropertyName = "Importe";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.importeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.importeDataGridViewTextBoxColumn1.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn1.Name = "importeDataGridViewTextBoxColumn1";
            this.importeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaPagoDataGridViewTextBoxColumn1
            // 
            this.fechaPagoDataGridViewTextBoxColumn1.DataPropertyName = "FechaPago";
            dataGridViewCellStyle8.Format = "d";
            this.fechaPagoDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.fechaPagoDataGridViewTextBoxColumn1.HeaderText = "Fecha Pago";
            this.fechaPagoDataGridViewTextBoxColumn1.Name = "fechaPagoDataGridViewTextBoxColumn1";
            this.fechaPagoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // formaPagoDataGridViewTextBoxColumn1
            // 
            this.formaPagoDataGridViewTextBoxColumn1.DataPropertyName = "FormaPago";
            this.formaPagoDataGridViewTextBoxColumn1.HeaderText = "Forma Pago";
            this.formaPagoDataGridViewTextBoxColumn1.Name = "formaPagoDataGridViewTextBoxColumn1";
            this.formaPagoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 5;
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            this.idproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproveedorDataGridViewTextBoxColumn.Visible = false;
            this.idproveedorDataGridViewTextBoxColumn.Width = 5;
            // 
            // fechaFacturaDataGridViewTextBoxColumn
            // 
            this.fechaFacturaDataGridViewTextBoxColumn.DataPropertyName = "FechaFactura";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fechaFacturaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fechaFacturaDataGridViewTextBoxColumn.HeaderText = "Fecha Factura";
            this.fechaFacturaDataGridViewTextBoxColumn.Name = "fechaFacturaDataGridViewTextBoxColumn";
            this.fechaFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.importeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPagoDataGridViewTextBoxColumn
            // 
            this.fechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.fechaPagoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha Pago";
            this.fechaPagoDataGridViewTextBoxColumn.Name = "fechaPagoDataGridViewTextBoxColumn";
            this.fechaPagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaPagoDataGridViewTextBoxColumn
            // 
            this.formaPagoDataGridViewTextBoxColumn.DataPropertyName = "FormaPago";
            this.formaPagoDataGridViewTextBoxColumn.HeaderText = "Forma Pago";
            this.formaPagoDataGridViewTextBoxColumn.Name = "formaPagoDataGridViewTextBoxColumn";
            this.formaPagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmEditProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 276);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.proveedoresBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 232);
            this.Name = "FrmEditProveedor";
            this.Text = "Modificar Proveedor";
            this.Load += new System.EventHandler(this.FrmEditProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingNavigator)).EndInit();
            this.proveedoresBindingNavigator.ResumeLayout(false);
            this.proveedoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Data.DataSet1TableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private Data.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proveedoresBindingNavigator;
        private System.Windows.Forms.ToolStripButton proveedoresBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox cifTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.TextBox nroCuentaTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource asientosBindingSource;
        private Data.DataSet1TableAdapters.AsientosTableAdapter asientosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource asientosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFacturaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagoDataGridViewTextBoxColumn;
    }
}