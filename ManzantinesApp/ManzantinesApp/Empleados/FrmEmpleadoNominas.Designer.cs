namespace ManzantinesApp.Empleados
{
    partial class FrmEmpleadoNominas
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
            this.NominasDataGridView = new System.Windows.Forms.DataGridView();
            this.anioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vvresumenNominaEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptDataSet = new ManzantinesApp.Data.RptDataSet();
            this.vv_resumenNominaEmpleadoTableAdapter = new ManzantinesApp.Data.RptDataSetTableAdapters.vv_resumenNominaEmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NominasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vvresumenNominaEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // NominasDataGridView
            // 
            this.NominasDataGridView.AllowUserToAddRows = false;
            this.NominasDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NominasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.NominasDataGridView.AutoGenerateColumns = false;
            this.NominasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NominasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anioDataGridViewTextBoxColumn,
            this.semanaDataGridViewTextBoxColumn,
            this.idempleadoDataGridViewTextBoxColumn,
            this.valorDDataGridViewTextBoxColumn,
            this.valorHDataGridViewTextBoxColumn,
            this.diasDataGridViewTextBoxColumn,
            this.horasDataGridViewTextBoxColumn,
            this.totalDiasDataGridViewTextBoxColumn,
            this.totalHorasDataGridViewTextBoxColumn,
            this.pagadoDataGridViewCheckBoxColumn});
            this.NominasDataGridView.DataSource = this.vvresumenNominaEmpleadoBindingSource;
            this.NominasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NominasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.NominasDataGridView.Name = "NominasDataGridView";
            this.NominasDataGridView.ReadOnly = true;
            this.NominasDataGridView.Size = new System.Drawing.Size(968, 375);
            this.NominasDataGridView.TabIndex = 0;
            // 
            // anioDataGridViewTextBoxColumn
            // 
            this.anioDataGridViewTextBoxColumn.DataPropertyName = "anio";
            this.anioDataGridViewTextBoxColumn.HeaderText = "Año";
            this.anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            this.anioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semanaDataGridViewTextBoxColumn
            // 
            this.semanaDataGridViewTextBoxColumn.DataPropertyName = "semana";
            this.semanaDataGridViewTextBoxColumn.HeaderText = "Semana";
            this.semanaDataGridViewTextBoxColumn.Name = "semanaDataGridViewTextBoxColumn";
            this.semanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            this.idempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idempleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorDDataGridViewTextBoxColumn
            // 
            this.valorDDataGridViewTextBoxColumn.DataPropertyName = "valorD";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorDDataGridViewTextBoxColumn.HeaderText = "€ Dias";
            this.valorDDataGridViewTextBoxColumn.Name = "valorDDataGridViewTextBoxColumn";
            this.valorDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorHDataGridViewTextBoxColumn
            // 
            this.valorHDataGridViewTextBoxColumn.DataPropertyName = "valorH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.valorHDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorHDataGridViewTextBoxColumn.HeaderText = "€ Horas";
            this.valorHDataGridViewTextBoxColumn.Name = "valorHDataGridViewTextBoxColumn";
            this.valorHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "Dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "Dias";
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            this.diasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horasDataGridViewTextBoxColumn
            // 
            this.horasDataGridViewTextBoxColumn.DataPropertyName = "Horas";
            this.horasDataGridViewTextBoxColumn.HeaderText = "Horas";
            this.horasDataGridViewTextBoxColumn.Name = "horasDataGridViewTextBoxColumn";
            this.horasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDiasDataGridViewTextBoxColumn
            // 
            this.totalDiasDataGridViewTextBoxColumn.DataPropertyName = "TotalDias";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.totalDiasDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalDiasDataGridViewTextBoxColumn.HeaderText = "Total Dias";
            this.totalDiasDataGridViewTextBoxColumn.Name = "totalDiasDataGridViewTextBoxColumn";
            this.totalDiasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalHorasDataGridViewTextBoxColumn
            // 
            this.totalHorasDataGridViewTextBoxColumn.DataPropertyName = "TotalHoras";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.totalHorasDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalHorasDataGridViewTextBoxColumn.HeaderText = "Total Horas";
            this.totalHorasDataGridViewTextBoxColumn.Name = "totalHorasDataGridViewTextBoxColumn";
            this.totalHorasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagadoDataGridViewCheckBoxColumn
            // 
            this.pagadoDataGridViewCheckBoxColumn.DataPropertyName = "pagado";
            this.pagadoDataGridViewCheckBoxColumn.FalseValue = "0";
            this.pagadoDataGridViewCheckBoxColumn.HeaderText = "Pagado";
            this.pagadoDataGridViewCheckBoxColumn.IndeterminateValue = "-1";
            this.pagadoDataGridViewCheckBoxColumn.Name = "pagadoDataGridViewCheckBoxColumn";
            this.pagadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pagadoDataGridViewCheckBoxColumn.TrueValue = "1";
            // 
            // vvresumenNominaEmpleadoBindingSource
            // 
            this.vvresumenNominaEmpleadoBindingSource.DataMember = "vv_resumenNominaEmpleado";
            this.vvresumenNominaEmpleadoBindingSource.DataSource = this.rptDataSet;
            // 
            // rptDataSet
            // 
            this.rptDataSet.DataSetName = "RptDataSet";
            this.rptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vv_resumenNominaEmpleadoTableAdapter
            // 
            this.vv_resumenNominaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEmpleadoNominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 375);
            this.Controls.Add(this.NominasDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpleadoNominas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empleado Nominas";
            this.Load += new System.EventHandler(this.FrmEmpleadoNominas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NominasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vvresumenNominaEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NominasDataGridView;
        private Data.RptDataSet rptDataSet;
        private System.Windows.Forms.BindingSource vvresumenNominaEmpleadoBindingSource;
        private Data.RptDataSetTableAdapters.vv_resumenNominaEmpleadoTableAdapter vv_resumenNominaEmpleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagadoDataGridViewCheckBoxColumn;
    }
}