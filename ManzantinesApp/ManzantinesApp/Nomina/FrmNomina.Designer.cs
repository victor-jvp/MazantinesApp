namespace ManzantinesApp.Nomina
{
    partial class FrmNomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNomina));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NominaDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SemanaComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LunesDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LunesExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MartesDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MartesExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiercolesDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiercolesExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JuevesDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JuevesExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViernesDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViernesExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SabadoDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SabadoExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomingoDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomingoExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.AnioComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.TotalesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.TipoEmpleo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NominaDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NominaDataGridView
            // 
            this.NominaDataGridView.AllowUserToAddRows = false;
            this.NominaDataGridView.AllowUserToDeleteRows = false;
            this.NominaDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NominaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.NominaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NominaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NominaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Semana,
            this.id_empleado,
            this.Nro_empleado,
            this.Empleado,
            this.LunesDia,
            this.LunesExtra,
            this.MartesDia,
            this.MartesExtra,
            this.MiercolesDia,
            this.MiercolesExtra,
            this.JuevesDia,
            this.JuevesExtra,
            this.ViernesDia,
            this.ViernesExtra,
            this.SabadoDia,
            this.SabadoExtra,
            this.DomingoDia,
            this.DomingoExtra,
            this.TotalDia,
            this.TotalExtra});
            this.NominaDataGridView.Location = new System.Drawing.Point(0, 28);
            this.NominaDataGridView.MultiSelect = false;
            this.NominaDataGridView.Name = "NominaDataGridView";
            this.NominaDataGridView.ReadOnly = true;
            this.NominaDataGridView.RowHeadersVisible = false;
            this.NominaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.NominaDataGridView.Size = new System.Drawing.Size(1059, 329);
            this.NominaDataGridView.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.AnioComboBox,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.SemanaComboBox,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1059, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SemanaComboBox
            // 
            this.SemanaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SemanaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SemanaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemanaComboBox.Name = "SemanaComboBox";
            this.SemanaComboBox.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel1.Text = "Semana:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Semana
            // 
            this.Semana.DataPropertyName = "Semana";
            this.Semana.HeaderText = "Semana";
            this.Semana.Name = "Semana";
            this.Semana.ReadOnly = true;
            this.Semana.Visible = false;
            this.Semana.Width = 71;
            // 
            // id_empleado
            // 
            this.id_empleado.DataPropertyName = "id_empleado";
            this.id_empleado.HeaderText = "id_empleado";
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.ReadOnly = true;
            this.id_empleado.Visible = false;
            this.id_empleado.Width = 92;
            // 
            // Nro_empleado
            // 
            this.Nro_empleado.DataPropertyName = "Nro_empleado";
            this.Nro_empleado.HeaderText = "Nro. Empleado";
            this.Nro_empleado.Name = "Nro_empleado";
            this.Nro_empleado.ReadOnly = true;
            this.Nro_empleado.Width = 70;
            // 
            // Empleado
            // 
            this.Empleado.DataPropertyName = "Empleado";
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // LunesDia
            // 
            this.LunesDia.DataPropertyName = "LunesDia";
            this.LunesDia.HeaderText = "Dia";
            this.LunesDia.Name = "LunesDia";
            this.LunesDia.ReadOnly = true;
            this.LunesDia.Width = 48;
            // 
            // LunesExtra
            // 
            this.LunesExtra.DataPropertyName = "LunesExtra";
            this.LunesExtra.HeaderText = "Extra";
            this.LunesExtra.Name = "LunesExtra";
            this.LunesExtra.ReadOnly = true;
            this.LunesExtra.Width = 56;
            // 
            // MartesDia
            // 
            this.MartesDia.DataPropertyName = "MartesDia";
            this.MartesDia.HeaderText = "Dia";
            this.MartesDia.Name = "MartesDia";
            this.MartesDia.ReadOnly = true;
            this.MartesDia.Width = 48;
            // 
            // MartesExtra
            // 
            this.MartesExtra.DataPropertyName = "MartesExtra";
            this.MartesExtra.HeaderText = "Extra";
            this.MartesExtra.Name = "MartesExtra";
            this.MartesExtra.ReadOnly = true;
            this.MartesExtra.Width = 56;
            // 
            // MiercolesDia
            // 
            this.MiercolesDia.DataPropertyName = "MiercolesDia";
            this.MiercolesDia.HeaderText = "Dia";
            this.MiercolesDia.Name = "MiercolesDia";
            this.MiercolesDia.ReadOnly = true;
            this.MiercolesDia.Width = 48;
            // 
            // MiercolesExtra
            // 
            this.MiercolesExtra.DataPropertyName = "MiercolesExtra";
            this.MiercolesExtra.HeaderText = "Extra";
            this.MiercolesExtra.Name = "MiercolesExtra";
            this.MiercolesExtra.ReadOnly = true;
            this.MiercolesExtra.Width = 56;
            // 
            // JuevesDia
            // 
            this.JuevesDia.DataPropertyName = "JuevesDia";
            this.JuevesDia.HeaderText = "Dia";
            this.JuevesDia.Name = "JuevesDia";
            this.JuevesDia.ReadOnly = true;
            this.JuevesDia.Width = 48;
            // 
            // JuevesExtra
            // 
            this.JuevesExtra.DataPropertyName = "JuevesExtra";
            this.JuevesExtra.HeaderText = "Extra";
            this.JuevesExtra.Name = "JuevesExtra";
            this.JuevesExtra.ReadOnly = true;
            this.JuevesExtra.Width = 56;
            // 
            // ViernesDia
            // 
            this.ViernesDia.DataPropertyName = "ViernesDia";
            this.ViernesDia.HeaderText = "Dia";
            this.ViernesDia.Name = "ViernesDia";
            this.ViernesDia.ReadOnly = true;
            this.ViernesDia.Width = 48;
            // 
            // ViernesExtra
            // 
            this.ViernesExtra.DataPropertyName = "ViernesExtra";
            this.ViernesExtra.HeaderText = "Extra";
            this.ViernesExtra.Name = "ViernesExtra";
            this.ViernesExtra.ReadOnly = true;
            this.ViernesExtra.Width = 56;
            // 
            // SabadoDia
            // 
            this.SabadoDia.DataPropertyName = "SabadoDia";
            this.SabadoDia.HeaderText = "Dia";
            this.SabadoDia.Name = "SabadoDia";
            this.SabadoDia.ReadOnly = true;
            this.SabadoDia.Width = 48;
            // 
            // SabadoExtra
            // 
            this.SabadoExtra.DataPropertyName = "SabadoExtra";
            this.SabadoExtra.HeaderText = "Extra";
            this.SabadoExtra.Name = "SabadoExtra";
            this.SabadoExtra.ReadOnly = true;
            this.SabadoExtra.Width = 56;
            // 
            // DomingoDia
            // 
            this.DomingoDia.DataPropertyName = "DomingoDia";
            this.DomingoDia.HeaderText = "Dia";
            this.DomingoDia.Name = "DomingoDia";
            this.DomingoDia.ReadOnly = true;
            this.DomingoDia.Width = 48;
            // 
            // DomingoExtra
            // 
            this.DomingoExtra.DataPropertyName = "DomingoExtra";
            this.DomingoExtra.HeaderText = "Extra";
            this.DomingoExtra.Name = "DomingoExtra";
            this.DomingoExtra.ReadOnly = true;
            this.DomingoExtra.Width = 56;
            // 
            // TotalDia
            // 
            this.TotalDia.DataPropertyName = "TotalDia";
            this.TotalDia.HeaderText = "Dia";
            this.TotalDia.Name = "TotalDia";
            this.TotalDia.ReadOnly = true;
            this.TotalDia.Width = 48;
            // 
            // TotalExtra
            // 
            this.TotalExtra.DataPropertyName = "TotalExtra";
            this.TotalExtra.HeaderText = "Extra";
            this.TotalExtra.Name = "TotalExtra";
            this.TotalExtra.ReadOnly = true;
            this.TotalExtra.Width = 56;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "Año:";
            // 
            // AnioComboBox
            // 
            this.AnioComboBox.Name = "AnioComboBox";
            this.AnioComboBox.Size = new System.Drawing.Size(80, 25);
            // 
            // TotalesDataGridView
            // 
            this.TotalesDataGridView.AllowUserToAddRows = false;
            this.TotalesDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TotalesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TotalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoEmpleo,
            this.Dias,
            this.Extras,
            this.Total});
            this.TotalesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.TotalesDataGridView.Name = "TotalesDataGridView";
            this.TotalesDataGridView.ReadOnly = true;
            this.TotalesDataGridView.RowHeadersVisible = false;
            this.TotalesDataGridView.Size = new System.Drawing.Size(482, 162);
            this.TotalesDataGridView.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.TotalesDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(7, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 181);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton1.Text = "&Guardar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(108, 22);
            this.toolStripButton2.Text = "&Cargar Nomina";
            // 
            // TipoEmpleo
            // 
            this.TipoEmpleo.HeaderText = "Empleo";
            this.TipoEmpleo.Name = "TipoEmpleo";
            this.TipoEmpleo.ReadOnly = true;
            this.TipoEmpleo.Width = 150;
            // 
            // Dias
            // 
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            // 
            // Extras
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Extras.DefaultCellStyle = dataGridViewCellStyle3;
            this.Extras.HeaderText = "Extras";
            this.Extras.Name = "Extras";
            this.Extras.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FrmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NominaDataGridView);
            this.Name = "FrmNomina";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.FrmNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NominaDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView NominaDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox SemanaComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn LunesDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn LunesExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MartesDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MartesExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiercolesDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiercolesExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn JuevesDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn JuevesExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViernesDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViernesExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SabadoDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SabadoExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomingoDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomingoExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalExtra;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox AnioComboBox;
        private System.Windows.Forms.DataGridView TotalesDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmpleo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}