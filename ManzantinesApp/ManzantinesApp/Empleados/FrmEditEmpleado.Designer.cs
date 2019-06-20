namespace ManzantinesApp
{
    partial class FrmEditEmpleado
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
            System.Windows.Forms.Label nro_empleadoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label id_empresaLabel;
            System.Windows.Forms.Label fincaLabel;
            System.Windows.Forms.Label nroCasaLabel;
            System.Windows.Forms.Label cCCLabel;
            System.Windows.Forms.Label cajaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditEmpleado));
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.trabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajadoresTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.TrabajadoresTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.trabajadores_EmpleosTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.Trabajadores_EmpleosTableAdapter();
            this.casasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.CasasTableAdapter();
            this.empleosTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EmpleosTableAdapter();
            this.empresasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EmpresasTableAdapter();
            this.encargadosTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EncargadosTableAdapter();
            this.fincasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.FincasTableAdapter();
            this.nro_empleadoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.id_empresaComboBox = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PictureOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.encargadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fincasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fincaComboBox = new System.Windows.Forms.ComboBox();
            this.casasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nroCasaComboBox = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.QuitarFototoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.foto2PictureBox = new System.Windows.Forms.PictureBox();
            this.trabajadores_EmpleosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajadores_EmpleosDataGridView = new System.Windows.Forms.DataGridView();
            this.Id_empleo_trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empleo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.QuitarEmpleoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cCCTextBox = new System.Windows.Forms.TextBox();
            this.cajaTextBox = new System.Windows.Forms.TextBox();
            nro_empleadoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            id_empresaLabel = new System.Windows.Forms.Label();
            fincaLabel = new System.Windows.Forms.Label();
            nroCasaLabel = new System.Windows.Forms.Label();
            cCCLabel = new System.Windows.Forms.Label();
            cajaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encargadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fincasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casasBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadores_EmpleosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadores_EmpleosDataGridView)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nro_empleadoLabel
            // 
            nro_empleadoLabel.AutoSize = true;
            nro_empleadoLabel.Location = new System.Drawing.Point(16, 34);
            nro_empleadoLabel.Name = "nro_empleadoLabel";
            nro_empleadoLabel.Size = new System.Drawing.Size(76, 13);
            nro_empleadoLabel.TabIndex = 0;
            nro_empleadoLabel.Text = "Nro empleado:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(45, 72);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(40, 98);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 6;
            apellidosLabel.Text = "Apellidos:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(40, 124);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 8;
            telefonoLabel.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(323, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 13);
            label1.TabIndex = 19;
            label1.Text = "Foto:";
            // 
            // id_empresaLabel
            // 
            id_empresaLabel.AutoSize = true;
            id_empresaLabel.Location = new System.Drawing.Point(275, 206);
            id_empresaLabel.Name = "id_empresaLabel";
            id_empresaLabel.Size = new System.Drawing.Size(51, 13);
            id_empresaLabel.TabIndex = 12;
            id_empresaLabel.Text = "Empresa:";
            // 
            // fincaLabel
            // 
            fincaLabel.AutoSize = true;
            fincaLabel.Location = new System.Drawing.Point(290, 233);
            fincaLabel.Name = "fincaLabel";
            fincaLabel.Size = new System.Drawing.Size(36, 13);
            fincaLabel.TabIndex = 14;
            fincaLabel.Text = "Finca:";
            // 
            // nroCasaLabel
            // 
            nroCasaLabel.AutoSize = true;
            nroCasaLabel.Location = new System.Drawing.Point(272, 260);
            nroCasaLabel.Name = "nroCasaLabel";
            nroCasaLabel.Size = new System.Drawing.Size(54, 13);
            nroCasaLabel.TabIndex = 16;
            nroCasaLabel.Text = "Nro Casa:";
            // 
            // cCCLabel
            // 
            cCCLabel.AutoSize = true;
            cCCLabel.Location = new System.Drawing.Point(61, 150);
            cCCLabel.Name = "cCCLabel";
            cCCLabel.Size = new System.Drawing.Size(31, 13);
            cCCLabel.TabIndex = 10;
            cCCLabel.Text = "CCC:";
            // 
            // cajaLabel
            // 
            cajaLabel.AutoSize = true;
            cajaLabel.Location = new System.Drawing.Point(216, 34);
            cajaLabel.Name = "cajaLabel";
            cajaLabel.Size = new System.Drawing.Size(31, 13);
            cajaLabel.TabIndex = 2;
            cajaLabel.Text = "Caja:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trabajadoresBindingSource
            // 
            this.trabajadoresBindingSource.DataMember = "Trabajadores";
            this.trabajadoresBindingSource.DataSource = this.dataSet1;
            // 
            // trabajadoresTableAdapter
            // 
            this.trabajadoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsientosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasasTableAdapter = this.casasTableAdapter;
            this.tableAdapterManager.DiasSemanaTableAdapter = null;
            this.tableAdapterManager.EmpleosPagosTableAdapter = null;
            this.tableAdapterManager.EmpleosTableAdapter = this.empleosTableAdapter;
            this.tableAdapterManager.EmpresasTableAdapter = this.empresasTableAdapter;
            this.tableAdapterManager.EncargadosTableAdapter = this.encargadosTableAdapter;
            this.tableAdapterManager.FincasTableAdapter = this.fincasTableAdapter;
            this.tableAdapterManager.LiquidacionesTableAdapter = null;
            this.tableAdapterManager.NominasCabTableAdapter = null;
            this.tableAdapterManager.NominasDetTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Trabajadores_EmpleosTableAdapter = this.trabajadores_EmpleosTableAdapter;
            this.tableAdapterManager.TrabajadoresTableAdapter = this.trabajadoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // trabajadores_EmpleosTableAdapter
            // 
            this.trabajadores_EmpleosTableAdapter.ClearBeforeFill = true;
            // 
            // casasTableAdapter
            // 
            this.casasTableAdapter.ClearBeforeFill = true;
            // 
            // empleosTableAdapter
            // 
            this.empleosTableAdapter.ClearBeforeFill = true;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // encargadosTableAdapter
            // 
            this.encargadosTableAdapter.ClearBeforeFill = true;
            // 
            // fincasTableAdapter
            // 
            this.fincasTableAdapter.ClearBeforeFill = true;
            // 
            // nro_empleadoTextBox
            // 
            this.nro_empleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabajadoresBindingSource, "Nro_empleado", true));
            this.nro_empleadoTextBox.Location = new System.Drawing.Point(98, 31);
            this.nro_empleadoTextBox.Name = "nro_empleadoTextBox";
            this.nro_empleadoTextBox.Size = new System.Drawing.Size(68, 20);
            this.nro_empleadoTextBox.TabIndex = 1;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabajadoresBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(98, 69);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(236, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabajadoresBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(98, 95);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(236, 20);
            this.apellidosTextBox.TabIndex = 7;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabajadoresBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(98, 121);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(121, 20);
            this.telefonoTextBox.TabIndex = 9;
            // 
            // id_empresaComboBox
            // 
            this.id_empresaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_empresaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trabajadoresBindingSource, "id_empresa", true));
            this.id_empresaComboBox.DataSource = this.empresasBindingSource;
            this.id_empresaComboBox.DisplayMember = "Empresa";
            this.id_empresaComboBox.FormattingEnabled = true;
            this.id_empresaComboBox.Location = new System.Drawing.Point(332, 203);
            this.id_empresaComboBox.Name = "id_empresaComboBox";
            this.id_empresaComboBox.Size = new System.Drawing.Size(140, 21);
            this.id_empresaComboBox.TabIndex = 13;
            this.id_empresaComboBox.ValueMember = "Id";
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.AllowNew = false;
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.dataSet1;
            // 
            // PictureOpenFileDialog
            // 
            this.PictureOpenFileDialog.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton1.Text = "&Guardar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // encargadosBindingSource
            // 
            this.encargadosBindingSource.AllowNew = false;
            this.encargadosBindingSource.DataMember = "Encargados";
            this.encargadosBindingSource.DataSource = this.dataSet1;
            // 
            // empleosBindingSource
            // 
            this.empleosBindingSource.AllowNew = false;
            this.empleosBindingSource.DataMember = "Empleos";
            this.empleosBindingSource.DataSource = this.dataSet1;
            // 
            // fincasBindingSource
            // 
            this.fincasBindingSource.AllowNew = false;
            this.fincasBindingSource.DataMember = "Fincas";
            this.fincasBindingSource.DataSource = this.dataSet1;
            // 
            // fincaComboBox
            // 
            this.fincaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fincaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fincaComboBox.DataSource = this.fincasBindingSource;
            this.fincaComboBox.DisplayMember = "Finca";
            this.fincaComboBox.FormattingEnabled = true;
            this.fincaComboBox.Location = new System.Drawing.Point(332, 230);
            this.fincaComboBox.Name = "fincaComboBox";
            this.fincaComboBox.Size = new System.Drawing.Size(140, 21);
            this.fincaComboBox.TabIndex = 15;
            this.fincaComboBox.ValueMember = "Id";
            this.fincaComboBox.SelectedIndexChanged += new System.EventHandler(this.fincaComboBox_SelectedIndexChanged);
            // 
            // casasBindingSource
            // 
            this.casasBindingSource.DataMember = "id_finca";
            this.casasBindingSource.DataSource = this.fincasBindingSource;
            // 
            // nroCasaComboBox
            // 
            this.nroCasaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nroCasaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nroCasaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trabajadoresBindingSource, "id_casa", true));
            this.nroCasaComboBox.DataSource = this.casasBindingSource;
            this.nroCasaComboBox.DisplayMember = "NroCasa";
            this.nroCasaComboBox.FormattingEnabled = true;
            this.nroCasaComboBox.Location = new System.Drawing.Point(332, 257);
            this.nroCasaComboBox.Name = "nroCasaComboBox";
            this.nroCasaComboBox.Size = new System.Drawing.Size(140, 21);
            this.nroCasaComboBox.TabIndex = 17;
            this.nroCasaComboBox.ValueMember = "Id";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuitarFototoolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(372, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(99, 25);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // QuitarFototoolStripButton
            // 
            this.QuitarFototoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("QuitarFototoolStripButton.Image")));
            this.QuitarFototoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuitarFototoolStripButton.Name = "QuitarFototoolStripButton";
            this.QuitarFototoolStripButton.Size = new System.Drawing.Size(87, 22);
            this.QuitarFototoolStripButton.Text = "Quitar Foto";
            this.QuitarFototoolStripButton.Click += new System.EventHandler(this.QuitarFototoolStripButton_Click);
            // 
            // foto2PictureBox
            // 
            this.foto2PictureBox.BackColor = System.Drawing.Color.White;
            this.foto2PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foto2PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foto2PictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.trabajadoresBindingSource, "foto2", true));
            this.foto2PictureBox.Location = new System.Drawing.Point(372, 31);
            this.foto2PictureBox.Name = "foto2PictureBox";
            this.foto2PictureBox.Size = new System.Drawing.Size(100, 123);
            this.foto2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto2PictureBox.TabIndex = 25;
            this.foto2PictureBox.TabStop = false;
            this.foto2PictureBox.Click += new System.EventHandler(this.foto2PictureBox_Click);
            // 
            // trabajadores_EmpleosBindingSource
            // 
            this.trabajadores_EmpleosBindingSource.AllowNew = true;
            this.trabajadores_EmpleosBindingSource.DataMember = "fk_id_trabajador";
            this.trabajadores_EmpleosBindingSource.DataSource = this.trabajadoresBindingSource;
            // 
            // trabajadores_EmpleosDataGridView
            // 
            this.trabajadores_EmpleosDataGridView.AutoGenerateColumns = false;
            this.trabajadores_EmpleosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trabajadores_EmpleosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_empleo_trabajador,
            this.id_trabajador,
            this.id_empleo});
            this.trabajadores_EmpleosDataGridView.DataSource = this.trabajadores_EmpleosBindingSource;
            this.trabajadores_EmpleosDataGridView.Location = new System.Drawing.Point(12, 183);
            this.trabajadores_EmpleosDataGridView.Name = "trabajadores_EmpleosDataGridView";
            this.trabajadores_EmpleosDataGridView.RowHeadersWidth = 31;
            this.trabajadores_EmpleosDataGridView.Size = new System.Drawing.Size(238, 135);
            this.trabajadores_EmpleosDataGridView.TabIndex = 18;
            this.trabajadores_EmpleosDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.trabajadores_EmpleosDataGridView_CellValidating);
            // 
            // Id_empleo_trabajador
            // 
            this.Id_empleo_trabajador.DataPropertyName = "Id";
            this.Id_empleo_trabajador.HeaderText = "Id";
            this.Id_empleo_trabajador.Name = "Id_empleo_trabajador";
            this.Id_empleo_trabajador.ReadOnly = true;
            this.Id_empleo_trabajador.Visible = false;
            // 
            // id_trabajador
            // 
            this.id_trabajador.DataPropertyName = "id_trabajador";
            this.id_trabajador.HeaderText = "id_trabajador";
            this.id_trabajador.Name = "id_trabajador";
            this.id_trabajador.Visible = false;
            // 
            // id_empleo
            // 
            this.id_empleo.DataPropertyName = "id_empleo";
            this.id_empleo.DataSource = this.empleosBindingSource;
            this.id_empleo.DisplayMember = "Empleo";
            this.id_empleo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.id_empleo.HeaderText = "Empleo";
            this.id_empleo.Name = "id_empleo";
            this.id_empleo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_empleo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_empleo.ValueMember = "Id";
            this.id_empleo.Width = 175;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuitarEmpleoToolStripButton});
            this.toolStrip3.Location = new System.Drawing.Point(253, 294);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(115, 25);
            this.toolStrip3.TabIndex = 21;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // QuitarEmpleoToolStripButton
            // 
            this.QuitarEmpleoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("QuitarEmpleoToolStripButton.Image")));
            this.QuitarEmpleoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuitarEmpleoToolStripButton.Name = "QuitarEmpleoToolStripButton";
            this.QuitarEmpleoToolStripButton.Size = new System.Drawing.Size(103, 22);
            this.QuitarEmpleoToolStripButton.Text = "Quitar Empleo";
            this.QuitarEmpleoToolStripButton.Click += new System.EventHandler(this.QuitarEmpleoToolStripButton_Click);
            // 
            // cCCTextBox
            // 
            this.cCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabajadoresBindingSource, "CCC", true));
            this.cCCTextBox.Location = new System.Drawing.Point(98, 147);
            this.cCCTextBox.Name = "cCCTextBox";
            this.cCCTextBox.Size = new System.Drawing.Size(121, 20);
            this.cCCTextBox.TabIndex = 11;
            // 
            // cajaTextBox
            // 
            this.cajaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabajadoresBindingSource, "Caja", true));
            this.cajaTextBox.Location = new System.Drawing.Point(253, 31);
            this.cajaTextBox.Name = "cajaTextBox";
            this.cajaTextBox.Size = new System.Drawing.Size(56, 20);
            this.cajaTextBox.TabIndex = 3;
            // 
            // FrmEditEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 321);
            this.Controls.Add(cajaLabel);
            this.Controls.Add(this.cajaTextBox);
            this.Controls.Add(cCCLabel);
            this.Controls.Add(this.cCCTextBox);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.trabajadores_EmpleosDataGridView);
            this.Controls.Add(this.foto2PictureBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(nroCasaLabel);
            this.Controls.Add(this.nroCasaComboBox);
            this.Controls.Add(fincaLabel);
            this.Controls.Add(this.fincaComboBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(id_empresaLabel);
            this.Controls.Add(this.id_empresaComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(nro_empleadoLabel);
            this.Controls.Add(this.nro_empleadoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FrmEditEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FrmEditEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encargadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fincasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casasBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadores_EmpleosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadores_EmpleosDataGridView)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource trabajadoresBindingSource;
        private Data.DataSet1TableAdapters.TrabajadoresTableAdapter trabajadoresTableAdapter;
        private Data.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nro_empleadoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.ComboBox id_empresaComboBox;
        private System.Windows.Forms.OpenFileDialog PictureOpenFileDialog;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private Data.DataSet1TableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource encargadosBindingSource;
        private Data.DataSet1TableAdapters.EncargadosTableAdapter encargadosTableAdapter;
        private System.Windows.Forms.BindingSource empleosBindingSource;
        private Data.DataSet1TableAdapters.EmpleosTableAdapter empleosTableAdapter;
        private System.Windows.Forms.BindingSource fincasBindingSource;
        private Data.DataSet1TableAdapters.FincasTableAdapter fincasTableAdapter;
        private System.Windows.Forms.ComboBox fincaComboBox;
        private System.Windows.Forms.BindingSource casasBindingSource;
        private Data.DataSet1TableAdapters.CasasTableAdapter casasTableAdapter;
        private System.Windows.Forms.ComboBox nroCasaComboBox;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton QuitarFototoolStripButton;
        private System.Windows.Forms.PictureBox foto2PictureBox;
        private System.Windows.Forms.BindingSource trabajadores_EmpleosBindingSource;
        private Data.DataSet1TableAdapters.Trabajadores_EmpleosTableAdapter trabajadores_EmpleosTableAdapter;
        private System.Windows.Forms.DataGridView trabajadores_EmpleosDataGridView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_empleo_trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_trabajador;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_empleo;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton QuitarEmpleoToolStripButton;
        private System.Windows.Forms.TextBox cCCTextBox;
        private System.Windows.Forms.TextBox cajaTextBox;
    }
}