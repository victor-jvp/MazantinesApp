namespace ManzantinesApp.Liquidaciones
{
    partial class FrmLiquidaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLiquidaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.liquidacionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.liquidacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BuscarToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TotalesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaPreliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_empresa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SinPagarRadioButton = new System.Windows.Forms.RadioButton();
            this.PagadasRadioButton = new System.Windows.Forms.RadioButton();
            this.TodasRadioButton = new System.Windows.Forms.RadioButton();
            this.liquidacionesTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.LiquidacionesTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.empresasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EmpresasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingNavigator)).BeginInit();
            this.liquidacionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // liquidacionesBindingNavigator
            // 
            this.liquidacionesBindingNavigator.AddNewItem = null;
            this.liquidacionesBindingNavigator.BindingSource = this.liquidacionesBindingSource;
            this.liquidacionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.liquidacionesBindingNavigator.DeleteItem = null;
            this.liquidacionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.BuscarToolStripTextBox,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.EditToolStripButton,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.TotalesToolStripButton,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1});
            this.liquidacionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.liquidacionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.liquidacionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.liquidacionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.liquidacionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.liquidacionesBindingNavigator.Name = "liquidacionesBindingNavigator";
            this.liquidacionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.liquidacionesBindingNavigator.Size = new System.Drawing.Size(860, 25);
            this.liquidacionesBindingNavigator.TabIndex = 0;
            this.liquidacionesBindingNavigator.Text = "bindingNavigator1";
            // 
            // liquidacionesBindingSource
            // 
            this.liquidacionesBindingSource.DataMember = "Liquidaciones";
            this.liquidacionesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Buscar:";
            // 
            // BuscarToolStripTextBox
            // 
            this.BuscarToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuscarToolStripTextBox.Name = "BuscarToolStripTextBox";
            this.BuscarToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.BuscarToolStripTextBox.TextChanged += new System.EventHandler(this.BuscarToolStripTextBox_TextChanged);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripButton.Image")));
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.EditToolStripButton.Text = "Modificar";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TotalesToolStripButton
            // 
            this.TotalesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("TotalesToolStripButton.Image")));
            this.TotalesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TotalesToolStripButton.Name = "TotalesToolStripButton";
            this.TotalesToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.TotalesToolStripButton.Text = "Totales";
            this.TotalesToolStripButton.Click += new System.EventHandler(this.TotalesToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.excelToolStripMenuItem,
            this.vistaPreliminarToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(82, 22);
            this.toolStripDropDownButton1.Text = "Reportes";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem1.Text = "PDF";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excelToolStripMenuItem.Image")));
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // vistaPreliminarToolStripMenuItem
            // 
            this.vistaPreliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vistaPreliminarToolStripMenuItem.Image")));
            this.vistaPreliminarToolStripMenuItem.Name = "vistaPreliminarToolStripMenuItem";
            this.vistaPreliminarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.vistaPreliminarToolStripMenuItem.Text = "Vista Preliminar";
            this.vistaPreliminarToolStripMenuItem.Click += new System.EventHandler(this.vistaPreliminarToolStripMenuItem_Click);
            // 
            // liquidacionesDataGridView
            // 
            this.liquidacionesDataGridView.AllowUserToAddRows = false;
            this.liquidacionesDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.liquidacionesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.liquidacionesDataGridView.AutoGenerateColumns = false;
            this.liquidacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liquidacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fecha,
            this.Categoria,
            this.NroLiquidacion,
            this.NroFactura,
            this.FechaPago,
            this.Banco,
            this.Pagado,
            this.id_empresa,
            this.Totales});
            this.liquidacionesDataGridView.DataSource = this.liquidacionesBindingSource;
            this.liquidacionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liquidacionesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.liquidacionesDataGridView.Name = "liquidacionesDataGridView";
            this.liquidacionesDataGridView.ReadOnly = true;
            this.liquidacionesDataGridView.Size = new System.Drawing.Size(854, 271);
            this.liquidacionesDataGridView.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 77;
            // 
            // NroLiquidacion
            // 
            this.NroLiquidacion.DataPropertyName = "NroLiquidacion";
            this.NroLiquidacion.HeaderText = "Nro.Liquidacion";
            this.NroLiquidacion.Name = "NroLiquidacion";
            this.NroLiquidacion.ReadOnly = true;
            // 
            // NroFactura
            // 
            this.NroFactura.DataPropertyName = "NroFactura";
            this.NroFactura.HeaderText = "Nro.Factura";
            this.NroFactura.Name = "NroFactura";
            this.NroFactura.ReadOnly = true;
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "Fecha Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            // 
            // Banco
            // 
            this.Banco.DataPropertyName = "Banco";
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            // 
            // Pagado
            // 
            this.Pagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Pagado.DataPropertyName = "Pagado";
            this.Pagado.HeaderText = "Pagado";
            this.Pagado.Name = "Pagado";
            this.Pagado.ReadOnly = true;
            this.Pagado.Width = 50;
            // 
            // id_empresa
            // 
            this.id_empresa.DataPropertyName = "id_empresa";
            this.id_empresa.DataSource = this.empresasBindingSource;
            this.id_empresa.DisplayMember = "Empresa";
            this.id_empresa.HeaderText = "Empresa";
            this.id_empresa.Name = "id_empresa";
            this.id_empresa.ReadOnly = true;
            this.id_empresa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_empresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_empresa.ValueMember = "Id";
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.dataSet1;
            // 
            // Totales
            // 
            this.Totales.DataPropertyName = "Totales";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Totales.DefaultCellStyle = dataGridViewCellStyle2;
            this.Totales.HeaderText = "Totales";
            this.Totales.Name = "Totales";
            this.Totales.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.liquidacionesDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Liquidaciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SinPagarRadioButton);
            this.groupBox2.Controls.Add(this.PagadasRadioButton);
            this.groupBox2.Controls.Add(this.TodasRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(4, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Por:";
            // 
            // SinPagarRadioButton
            // 
            this.SinPagarRadioButton.AutoSize = true;
            this.SinPagarRadioButton.Location = new System.Drawing.Point(160, 19);
            this.SinPagarRadioButton.Name = "SinPagarRadioButton";
            this.SinPagarRadioButton.Size = new System.Drawing.Size(71, 17);
            this.SinPagarRadioButton.TabIndex = 2;
            this.SinPagarRadioButton.Text = "Sin Pagar";
            this.SinPagarRadioButton.UseVisualStyleBackColor = true;
            this.SinPagarRadioButton.CheckedChanged += new System.EventHandler(this.SinPagarRadioButton_CheckedChanged);
            // 
            // PagadasRadioButton
            // 
            this.PagadasRadioButton.AutoSize = true;
            this.PagadasRadioButton.Location = new System.Drawing.Point(87, 19);
            this.PagadasRadioButton.Name = "PagadasRadioButton";
            this.PagadasRadioButton.Size = new System.Drawing.Size(67, 17);
            this.PagadasRadioButton.TabIndex = 1;
            this.PagadasRadioButton.Text = "Pagadas";
            this.PagadasRadioButton.UseVisualStyleBackColor = true;
            this.PagadasRadioButton.CheckedChanged += new System.EventHandler(this.PagadasRadioButton_CheckedChanged);
            // 
            // TodasRadioButton
            // 
            this.TodasRadioButton.AutoSize = true;
            this.TodasRadioButton.Checked = true;
            this.TodasRadioButton.Location = new System.Drawing.Point(26, 19);
            this.TodasRadioButton.Name = "TodasRadioButton";
            this.TodasRadioButton.Size = new System.Drawing.Size(55, 17);
            this.TodasRadioButton.TabIndex = 0;
            this.TodasRadioButton.TabStop = true;
            this.TodasRadioButton.Text = "Todas";
            this.TodasRadioButton.UseVisualStyleBackColor = true;
            this.TodasRadioButton.CheckedChanged += new System.EventHandler(this.TodasRadioButton_CheckedChanged);
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
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.liquidacionesBindingNavigator);
            this.Name = "FrmLiquidaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liquidaciones";
            this.Load += new System.EventHandler(this.FrmLiquidaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingNavigator)).EndInit();
            this.liquidacionesBindingNavigator.ResumeLayout(false);
            this.liquidacionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource liquidacionesBindingSource;
        private Data.DataSet1TableAdapters.LiquidacionesTableAdapter liquidacionesTableAdapter;
        private Data.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator liquidacionesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView liquidacionesDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox BuscarToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TotalesToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vistaPreliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton SinPagarRadioButton;
        private System.Windows.Forms.RadioButton PagadasRadioButton;
        private System.Windows.Forms.RadioButton TodasRadioButton;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private Data.DataSet1TableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pagado;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totales;
    }
}