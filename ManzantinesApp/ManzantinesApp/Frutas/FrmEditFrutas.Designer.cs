namespace ManzantinesApp.Frutas
{
    partial class FrmEditFrutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditFrutas));
            this.FrutaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VariedadDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_fruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frutas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VariedadDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrutaTextBox
            // 
            this.FrutaTextBox.Location = new System.Drawing.Point(50, 28);
            this.FrutaTextBox.Name = "FrutaTextBox";
            this.FrutaTextBox.Size = new System.Drawing.Size(243, 20);
            this.FrutaTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fruta:";
            // 
            // VariedadDataGridView
            // 
            this.VariedadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VariedadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_fruta,
            this.Variedad,
            this.Frutas,
            this.DeletedAt});
            this.VariedadDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariedadDataGridView.Location = new System.Drawing.Point(3, 16);
            this.VariedadDataGridView.Name = "VariedadDataGridView";
            this.VariedadDataGridView.Size = new System.Drawing.Size(290, 146);
            this.VariedadDataGridView.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VariedadDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variedades";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(315, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton1.Text = "Guardar";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Id_fruta
            // 
            this.Id_fruta.DataPropertyName = "Id_fruta";
            this.Id_fruta.HeaderText = "Id_fruta";
            this.Id_fruta.Name = "Id_fruta";
            this.Id_fruta.Visible = false;
            // 
            // Variedad
            // 
            this.Variedad.DataPropertyName = "Variedad";
            this.Variedad.HeaderText = "Variedad";
            this.Variedad.Name = "Variedad";
            // 
            // Frutas
            // 
            this.Frutas.DataPropertyName = "Frutas";
            this.Frutas.HeaderText = "Frutas";
            this.Frutas.Name = "Frutas";
            this.Frutas.Visible = false;
            // 
            // DeletedAt
            // 
            this.DeletedAt.DataPropertyName = "DeletedAt";
            this.DeletedAt.HeaderText = "DeletedAt";
            this.DeletedAt.Name = "DeletedAt";
            this.DeletedAt.Visible = false;
            // 
            // FrmEditFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 231);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FrutaTextBox);
            this.Name = "FrmEditFrutas";
            this.Text = "Fruta";
            this.Load += new System.EventHandler(this.FrmEditFrutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VariedadDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FrutaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView VariedadDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_fruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedAt;
    }
}