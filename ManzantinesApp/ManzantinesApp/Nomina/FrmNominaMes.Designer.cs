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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MesToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.NominaDataGridView = new System.Windows.Forms.DataGridView();
            this.vv_NominasEmpleadosMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NominaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vv_NominasEmpleadosMesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.MesToolStripComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            this.NominaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NominaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NominaDataGridView.Location = new System.Drawing.Point(0, 25);
            this.NominaDataGridView.Name = "NominaDataGridView";
            this.NominaDataGridView.ReadOnly = true;
            this.NominaDataGridView.Size = new System.Drawing.Size(669, 378);
            this.NominaDataGridView.TabIndex = 2;
            // 
            // FrmNominaMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 403);
            this.Controls.Add(this.NominaDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmNominaMes";
            this.Text = "Nomina por Mes";
            this.Load += new System.EventHandler(this.FrmNominaMes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NominaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vv_NominasEmpleadosMesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox MesToolStripComboBox;
        private System.Windows.Forms.DataGridView NominaDataGridView;
        private System.Windows.Forms.BindingSource vv_NominasEmpleadosMesBindingSource;
    }
}