namespace ManzantinesApp.Nomina
{
    partial class FrmNominaMes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.AnioToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MesToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.NominaDataGridView = new System.Windows.Forms.DataGridView();
            this.iddetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idencargadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semanaIniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semanaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesIniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vvNominasEmpleadosMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NominaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vvNominasEmpleadosMesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.AnioToolStripComboBox,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.MesToolStripComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1003, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "Año:";
            // 
            // AnioToolStripComboBox
            // 
            this.AnioToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnioToolStripComboBox.Name = "AnioToolStripComboBox";
            this.AnioToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.AnioToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.AnioToolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "Mes:";
            // 
            // MesToolStripComboBox
            // 
            this.MesToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MesToolStripComboBox.Name = "MesToolStripComboBox";
            this.MesToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.MesToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.MesToolStripComboBox_SelectedIndexChanged);
            // 
            // NominaDataGridView
            // 
            this.NominaDataGridView.AllowUserToAddRows = false;
            this.NominaDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NominaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.NominaDataGridView.AutoGenerateColumns = false;
            this.NominaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NominaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetDataGridViewTextBoxColumn,
            this.anioDataGridViewTextBoxColumn,
            this.semanaDataGridViewTextBoxColumn,
            this.Encargado,
            this.idencargadoDataGridViewTextBoxColumn,
            this.nroEmpleadoDataGridViewTextBoxColumn,
            this.cajaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.semanaIniDataGridViewTextBoxColumn,
            this.semanaFinDataGridViewTextBoxColumn,
            this.mesIniDataGridViewTextBoxColumn,
            this.totalDDataGridViewTextBoxColumn,
            this.totalHDataGridViewTextBoxColumn,
            this.valorDDataGridViewTextBoxColumn,
            this.valorHDataGridViewTextBoxColumn,
            this.TotalPago});
            this.NominaDataGridView.DataSource = this.vvNominasEmpleadosMesBindingSource;
            this.NominaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NominaDataGridView.Location = new System.Drawing.Point(0, 25);
            this.NominaDataGridView.Name = "NominaDataGridView";
            this.NominaDataGridView.ReadOnly = true;
            this.NominaDataGridView.Size = new System.Drawing.Size(1003, 378);
            this.NominaDataGridView.TabIndex = 2;
            // 
            // iddetDataGridViewTextBoxColumn
            // 
            this.iddetDataGridViewTextBoxColumn.DataPropertyName = "id_det";
            this.iddetDataGridViewTextBoxColumn.HeaderText = "id_det";
            this.iddetDataGridViewTextBoxColumn.Name = "iddetDataGridViewTextBoxColumn";
            this.iddetDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddetDataGridViewTextBoxColumn.Visible = false;
            // 
            // anioDataGridViewTextBoxColumn
            // 
            this.anioDataGridViewTextBoxColumn.DataPropertyName = "Anio";
            this.anioDataGridViewTextBoxColumn.HeaderText = "Anio";
            this.anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            this.anioDataGridViewTextBoxColumn.ReadOnly = true;
            this.anioDataGridViewTextBoxColumn.Visible = false;
            // 
            // semanaDataGridViewTextBoxColumn
            // 
            this.semanaDataGridViewTextBoxColumn.DataPropertyName = "Semana";
            this.semanaDataGridViewTextBoxColumn.HeaderText = "Semana";
            this.semanaDataGridViewTextBoxColumn.Name = "semanaDataGridViewTextBoxColumn";
            this.semanaDataGridViewTextBoxColumn.ReadOnly = true;
            this.semanaDataGridViewTextBoxColumn.Width = 80;
            // 
            // Encargado
            // 
            this.Encargado.DataPropertyName = "Encargado";
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
            this.Encargado.ReadOnly = true;
            // 
            // idencargadoDataGridViewTextBoxColumn
            // 
            this.idencargadoDataGridViewTextBoxColumn.DataPropertyName = "id_encargado";
            this.idencargadoDataGridViewTextBoxColumn.HeaderText = "id_encargado";
            this.idencargadoDataGridViewTextBoxColumn.Name = "idencargadoDataGridViewTextBoxColumn";
            this.idencargadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idencargadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nroEmpleadoDataGridViewTextBoxColumn
            // 
            this.nroEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Nro_Empleado";
            this.nroEmpleadoDataGridViewTextBoxColumn.HeaderText = "Nro.Empleado";
            this.nroEmpleadoDataGridViewTextBoxColumn.Name = "nroEmpleadoDataGridViewTextBoxColumn";
            this.nroEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroEmpleadoDataGridViewTextBoxColumn.Width = 80;
            // 
            // cajaDataGridViewTextBoxColumn
            // 
            this.cajaDataGridViewTextBoxColumn.DataPropertyName = "Caja";
            this.cajaDataGridViewTextBoxColumn.HeaderText = "Caja";
            this.cajaDataGridViewTextBoxColumn.Name = "cajaDataGridViewTextBoxColumn";
            this.cajaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cajaDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semanaIniDataGridViewTextBoxColumn
            // 
            this.semanaIniDataGridViewTextBoxColumn.DataPropertyName = "semanaIni";
            this.semanaIniDataGridViewTextBoxColumn.HeaderText = "semanaIni";
            this.semanaIniDataGridViewTextBoxColumn.Name = "semanaIniDataGridViewTextBoxColumn";
            this.semanaIniDataGridViewTextBoxColumn.ReadOnly = true;
            this.semanaIniDataGridViewTextBoxColumn.Visible = false;
            // 
            // semanaFinDataGridViewTextBoxColumn
            // 
            this.semanaFinDataGridViewTextBoxColumn.DataPropertyName = "semanaFin";
            this.semanaFinDataGridViewTextBoxColumn.HeaderText = "semanaFin";
            this.semanaFinDataGridViewTextBoxColumn.Name = "semanaFinDataGridViewTextBoxColumn";
            this.semanaFinDataGridViewTextBoxColumn.ReadOnly = true;
            this.semanaFinDataGridViewTextBoxColumn.Visible = false;
            // 
            // mesIniDataGridViewTextBoxColumn
            // 
            this.mesIniDataGridViewTextBoxColumn.DataPropertyName = "mesIni";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mesIniDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.mesIniDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.mesIniDataGridViewTextBoxColumn.Name = "mesIniDataGridViewTextBoxColumn";
            this.mesIniDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesIniDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalDDataGridViewTextBoxColumn
            // 
            this.totalDDataGridViewTextBoxColumn.DataPropertyName = "totalD";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalDDataGridViewTextBoxColumn.HeaderText = "Total Dias";
            this.totalDDataGridViewTextBoxColumn.Name = "totalDDataGridViewTextBoxColumn";
            this.totalDDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalHDataGridViewTextBoxColumn
            // 
            this.totalHDataGridViewTextBoxColumn.DataPropertyName = "totalH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalHDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalHDataGridViewTextBoxColumn.HeaderText = "Total Horas";
            this.totalHDataGridViewTextBoxColumn.Name = "totalHDataGridViewTextBoxColumn";
            this.totalHDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalHDataGridViewTextBoxColumn.Width = 80;
            // 
            // valorDDataGridViewTextBoxColumn
            // 
            this.valorDDataGridViewTextBoxColumn.DataPropertyName = "valorD";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.valorDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.valorDDataGridViewTextBoxColumn.HeaderText = "€ Dia";
            this.valorDDataGridViewTextBoxColumn.Name = "valorDDataGridViewTextBoxColumn";
            this.valorDDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDDataGridViewTextBoxColumn.Width = 65;
            // 
            // valorHDataGridViewTextBoxColumn
            // 
            this.valorHDataGridViewTextBoxColumn.DataPropertyName = "valorH";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.valorHDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorHDataGridViewTextBoxColumn.HeaderText = "€ Hora";
            this.valorHDataGridViewTextBoxColumn.Name = "valorHDataGridViewTextBoxColumn";
            this.valorHDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorHDataGridViewTextBoxColumn.Width = 65;
            // 
            // TotalPago
            // 
            this.TotalPago.DataPropertyName = "TotalPago";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.TotalPago.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalPago.HeaderText = "Total Pago";
            this.TotalPago.Name = "TotalPago";
            this.TotalPago.ReadOnly = true;
            this.TotalPago.Width = 80;
            // 
            // vvNominasEmpleadosMesBindingSource
            // 
            this.vvNominasEmpleadosMesBindingSource.DataSource = typeof(ManzantinesApp.DBContext.vv_NominasEmpleadosMes);
            // 
            // FrmNominaMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 403);
            this.Controls.Add(this.NominaDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmNominaMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nomina por Mes";
            this.Load += new System.EventHandler(this.FrmNominaMes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NominaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vvNominasEmpleadosMesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox MesToolStripComboBox;
        private System.Windows.Forms.DataGridView NominaDataGridView;
        private System.Windows.Forms.BindingSource vvNominasEmpleadosMesBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox AnioToolStripComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idencargadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semanaIniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semanaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesIniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPago;
    }
}