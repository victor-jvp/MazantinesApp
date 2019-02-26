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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            nro_empleadoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            id_empresaLabel = new System.Windows.Forms.Label();
            fincaLabel = new System.Windows.Forms.Label();
            nroCasaLabel = new System.Windows.Forms.Label();
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
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(40, 98);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 4;
            apellidosLabel.Text = "Apellidos:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(40, 124);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 6;
            telefonoLabel.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(323, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 13);
            label1.TabIndex = 18;
            label1.Text = "Foto:";
            // 
            // id_empresaLabel
            // 
            id_empresaLabel.AutoSize = true;
            id_empresaLabel.Location = new System.Drawing.Point(263, 160);
            id_empresaLabel.Name = "id_empresaLabel";
            id_empresaLabel.Size = new System.Drawing.Size(51, 13);
            id_empresaLabel.TabIndex = 8;
            id_empresaLabel.Text = "Empresa:";
            // 
            // fincaLabel
            // 
            fincaLabel.AutoSize = true;
            fincaLabel.Location = new System.Drawing.Point(278, 187);
            fincaLabel.Name = "fincaLabel";
            fincaLabel.Size = new System.Drawing.Size(36, 13);
            fincaLabel.TabIndex = 20;
            fincaLabel.Text = "Finca:";
            // 
            // nroCasaLabel
            // 
            nroCasaLabel.AutoSize = true;
            nroCasaLabel.Location = new System.Drawing.Point(260, 214);
            nroCasaLabel.Name = "nroCasaLabel";
            nroCasaLabel.Size = new System.Drawing.Size(54, 13);
            nroCasaLabel.TabIndex = 21;
            nroCasaLabel.Text = "Nro Casa:";
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
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasasTableAdapter = null;
            this.tableAdapterManager.EmpleosTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EncargadosTableAdapter = null;
            this.tableAdapterManager.FincasTableAdapter = null;
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
            this.nombreTextBox.TabIndex = 3;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabajadoresBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(98, 95);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(236, 20);
            this.apellidosTextBox.TabIndex = 5;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabajadoresBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(98, 121);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(121, 20);
            this.telefonoTextBox.TabIndex = 7;
            // 
            // id_empresaComboBox
            // 
            this.id_empresaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_empresaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trabajadoresBindingSource, "id_empresa", true));
            this.id_empresaComboBox.DataSource = this.empresasBindingSource;
            this.id_empresaComboBox.DisplayMember = "Empresa";
            this.id_empresaComboBox.FormattingEnabled = true;
            this.id_empresaComboBox.Location = new System.Drawing.Point(320, 157);
            this.id_empresaComboBox.Name = "id_empresaComboBox";
            this.id_empresaComboBox.Size = new System.Drawing.Size(140, 21);
            this.id_empresaComboBox.TabIndex = 9;
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
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 19;
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
            this.fincaComboBox.Location = new System.Drawing.Point(320, 184);
            this.fincaComboBox.Name = "fincaComboBox";
            this.fincaComboBox.Size = new System.Drawing.Size(140, 21);
            this.fincaComboBox.TabIndex = 21;
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
            this.nroCasaComboBox.Location = new System.Drawing.Point(320, 211);
            this.nroCasaComboBox.Name = "nroCasaComboBox";
            this.nroCasaComboBox.Size = new System.Drawing.Size(140, 21);
            this.nroCasaComboBox.TabIndex = 22;
            this.nroCasaComboBox.ValueMember = "Id";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuitarFototoolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(358, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(99, 25);
            this.toolStrip2.TabIndex = 24;
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
            this.foto2PictureBox.Location = new System.Drawing.Point(360, 28);
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
            this.trabajadores_EmpleosBindingSource.DataMember = "id_trabajador";
            this.trabajadores_EmpleosBindingSource.DataSource = this.trabajadoresBindingSource;
            // 
            // trabajadores_EmpleosDataGridView
            // 
            this.trabajadores_EmpleosDataGridView.AutoGenerateColumns = false;
            this.trabajadores_EmpleosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trabajadores_EmpleosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.trabajadores_EmpleosDataGridView.DataSource = this.trabajadores_EmpleosBindingSource;
            this.trabajadores_EmpleosDataGridView.Location = new System.Drawing.Point(12, 147);
            this.trabajadores_EmpleosDataGridView.Name = "trabajadores_EmpleosDataGridView";
            this.trabajadores_EmpleosDataGridView.Size = new System.Drawing.Size(242, 122);
            this.trabajadores_EmpleosDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_trabajador";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_trabajador";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_empleo";
            this.dataGridViewTextBoxColumn3.DataSource = this.empleosBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Empleo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Empleo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // FrmEditEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 292);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}