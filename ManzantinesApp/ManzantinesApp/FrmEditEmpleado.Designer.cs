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
            System.Windows.Forms.Label id_empleoLabel;
            System.Windows.Forms.Label id_fincaLabel;
            System.Windows.Forms.Label id_encargadoLabel;
            System.Windows.Forms.Label id_casaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditEmpleado));
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.trabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajadoresTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.TrabajadoresTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.nro_empleadoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_empresaComboBox = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_empleoComboBox = new System.Windows.Forms.ComboBox();
            this.empleosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_fincaComboBox = new System.Windows.Forms.ComboBox();
            this.fincasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_encargadoComboBox = new System.Windows.Forms.ComboBox();
            this.empleosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.id_casaComboBox = new System.Windows.Forms.ComboBox();
            this.casasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.empresasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EmpresasTableAdapter();
            this.fincasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.FincasTableAdapter();
            this.empleosTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EmpleosTableAdapter();
            this.casasTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.CasasTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            nro_empleadoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            id_empresaLabel = new System.Windows.Forms.Label();
            id_empleoLabel = new System.Windows.Forms.Label();
            id_fincaLabel = new System.Windows.Forms.Label();
            id_encargadoLabel = new System.Windows.Forms.Label();
            id_casaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fincasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casasBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            id_empresaLabel.Location = new System.Drawing.Point(41, 170);
            id_empresaLabel.Name = "id_empresaLabel";
            id_empresaLabel.Size = new System.Drawing.Size(51, 13);
            id_empresaLabel.TabIndex = 8;
            id_empresaLabel.Text = "Empresa:";
            // 
            // id_empleoLabel
            // 
            id_empleoLabel.AutoSize = true;
            id_empleoLabel.Location = new System.Drawing.Point(270, 170);
            id_empleoLabel.Name = "id_empleoLabel";
            id_empleoLabel.Size = new System.Drawing.Size(45, 13);
            id_empleoLabel.TabIndex = 14;
            id_empleoLabel.Text = "Empleo:";
            // 
            // id_fincaLabel
            // 
            id_fincaLabel.AutoSize = true;
            id_fincaLabel.Location = new System.Drawing.Point(56, 197);
            id_fincaLabel.Name = "id_fincaLabel";
            id_fincaLabel.Size = new System.Drawing.Size(36, 13);
            id_fincaLabel.TabIndex = 10;
            id_fincaLabel.Text = "Finca:";
            // 
            // id_encargadoLabel
            // 
            id_encargadoLabel.AutoSize = true;
            id_encargadoLabel.Location = new System.Drawing.Point(253, 197);
            id_encargadoLabel.Name = "id_encargadoLabel";
            id_encargadoLabel.Size = new System.Drawing.Size(62, 13);
            id_encargadoLabel.TabIndex = 16;
            id_encargadoLabel.Text = "Encargado:";
            // 
            // id_casaLabel
            // 
            id_casaLabel.AutoSize = true;
            id_casaLabel.Location = new System.Drawing.Point(58, 224);
            id_casaLabel.Name = "id_casaLabel";
            id_casaLabel.Size = new System.Drawing.Size(34, 13);
            id_casaLabel.TabIndex = 12;
            id_casaLabel.Text = "Casa:";
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
            this.tableAdapterManager.FincasTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = this.trabajadoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(360, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // id_empresaComboBox
            // 
            this.id_empresaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_empresaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trabajadoresBindingSource, "id_empresa", true));
            this.id_empresaComboBox.DataSource = this.empresasBindingSource;
            this.id_empresaComboBox.DisplayMember = "Empresa";
            this.id_empresaComboBox.FormattingEnabled = true;
            this.id_empresaComboBox.Location = new System.Drawing.Point(98, 167);
            this.id_empresaComboBox.Name = "id_empresaComboBox";
            this.id_empresaComboBox.Size = new System.Drawing.Size(140, 21);
            this.id_empresaComboBox.TabIndex = 9;
            this.id_empresaComboBox.ValueMember = "Id";
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.dataSet1;
            // 
            // id_empleoComboBox
            // 
            this.id_empleoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_empleoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_empleoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trabajadoresBindingSource, "id_empleo", true));
            this.id_empleoComboBox.DataSource = this.empleosBindingSource;
            this.id_empleoComboBox.DisplayMember = "Empleo";
            this.id_empleoComboBox.FormattingEnabled = true;
            this.id_empleoComboBox.Location = new System.Drawing.Point(321, 167);
            this.id_empleoComboBox.Name = "id_empleoComboBox";
            this.id_empleoComboBox.Size = new System.Drawing.Size(140, 21);
            this.id_empleoComboBox.TabIndex = 15;
            this.id_empleoComboBox.ValueMember = "Id";
            // 
            // empleosBindingSource
            // 
            this.empleosBindingSource.DataMember = "Empleos";
            this.empleosBindingSource.DataSource = this.dataSet1;
            // 
            // id_fincaComboBox
            // 
            this.id_fincaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_fincaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_fincaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trabajadoresBindingSource, "id_finca", true));
            this.id_fincaComboBox.DataSource = this.fincasBindingSource;
            this.id_fincaComboBox.DisplayMember = "Finca";
            this.id_fincaComboBox.FormattingEnabled = true;
            this.id_fincaComboBox.Location = new System.Drawing.Point(98, 194);
            this.id_fincaComboBox.Name = "id_fincaComboBox";
            this.id_fincaComboBox.Size = new System.Drawing.Size(140, 21);
            this.id_fincaComboBox.TabIndex = 11;
            this.id_fincaComboBox.ValueMember = "Id";
            // 
            // fincasBindingSource
            // 
            this.fincasBindingSource.DataMember = "Fincas";
            this.fincasBindingSource.DataSource = this.dataSet1;
            // 
            // id_encargadoComboBox
            // 
            this.id_encargadoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_encargadoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_encargadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trabajadoresBindingSource, "id_encargado", true));
            this.id_encargadoComboBox.DataSource = this.empleosBindingSource1;
            this.id_encargadoComboBox.DisplayMember = "Empleo";
            this.id_encargadoComboBox.FormattingEnabled = true;
            this.id_encargadoComboBox.Location = new System.Drawing.Point(321, 194);
            this.id_encargadoComboBox.Name = "id_encargadoComboBox";
            this.id_encargadoComboBox.Size = new System.Drawing.Size(140, 21);
            this.id_encargadoComboBox.TabIndex = 17;
            this.id_encargadoComboBox.ValueMember = "Id";
            // 
            // empleosBindingSource1
            // 
            this.empleosBindingSource1.DataMember = "Empleos";
            this.empleosBindingSource1.DataSource = this.dataSet1;
            // 
            // id_casaComboBox
            // 
            this.id_casaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_casaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_casaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trabajadoresBindingSource, "id_casa", true));
            this.id_casaComboBox.DataSource = this.casasBindingSource;
            this.id_casaComboBox.DisplayMember = "Casa";
            this.id_casaComboBox.FormattingEnabled = true;
            this.id_casaComboBox.Location = new System.Drawing.Point(98, 221);
            this.id_casaComboBox.Name = "id_casaComboBox";
            this.id_casaComboBox.Size = new System.Drawing.Size(140, 21);
            this.id_casaComboBox.TabIndex = 13;
            this.id_casaComboBox.ValueMember = "Id";
            // 
            // casasBindingSource
            // 
            this.casasBindingSource.DataMember = "Casas";
            this.casasBindingSource.DataSource = this.dataSet1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // fincasTableAdapter
            // 
            this.fincasTableAdapter.ClearBeforeFill = true;
            // 
            // empleosTableAdapter
            // 
            this.empleosTableAdapter.ClearBeforeFill = true;
            // 
            // casasTableAdapter
            // 
            this.casasTableAdapter.ClearBeforeFill = true;
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
            // FrmEditEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(id_casaLabel);
            this.Controls.Add(this.id_casaComboBox);
            this.Controls.Add(id_encargadoLabel);
            this.Controls.Add(this.id_encargadoComboBox);
            this.Controls.Add(id_fincaLabel);
            this.Controls.Add(this.id_fincaComboBox);
            this.Controls.Add(id_empleoLabel);
            this.Controls.Add(this.id_empleoComboBox);
            this.Controls.Add(id_empresaLabel);
            this.Controls.Add(this.id_empresaComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fincasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casasBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox id_empresaComboBox;
        private System.Windows.Forms.ComboBox id_empleoComboBox;
        private System.Windows.Forms.ComboBox id_fincaComboBox;
        private System.Windows.Forms.ComboBox id_encargadoComboBox;
        private System.Windows.Forms.ComboBox id_casaComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private Data.DataSet1TableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.BindingSource fincasBindingSource;
        private Data.DataSet1TableAdapters.FincasTableAdapter fincasTableAdapter;
        private System.Windows.Forms.BindingSource empleosBindingSource;
        private Data.DataSet1TableAdapters.EmpleosTableAdapter empleosTableAdapter;
        private System.Windows.Forms.BindingSource casasBindingSource;
        private Data.DataSet1TableAdapters.CasasTableAdapter casasTableAdapter;
        private System.Windows.Forms.BindingSource empleosBindingSource1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}