namespace ManzantinesApp.Nomina
{
    partial class FrmLoadNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadNomina));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CargarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.NominasDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuevaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.NominasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NominasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NominasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(593, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CargarToolStripButton,
            this.toolStripSeparator3,
            this.NuevaToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(593, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CargarToolStripButton
            // 
            this.CargarToolStripButton.Image = global::ManzantinesApp.Properties.Resources.if_01_Pencil_2064476;
            this.CargarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CargarToolStripButton.Name = "CargarToolStripButton";
            this.CargarToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.CargarToolStripButton.Text = "Cargar";
            this.CargarToolStripButton.Click += new System.EventHandler(this.CargarToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // NominasDataGridView
            // 
            this.NominasDataGridView.AllowUserToAddRows = false;
            this.NominasDataGridView.AllowUserToDeleteRows = false;
            this.NominasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NominasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Anio,
            this.semana,
            this.id_encargado,
            this.estado});
            this.NominasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NominasDataGridView.Location = new System.Drawing.Point(0, 25);
            this.NominasDataGridView.Name = "NominasDataGridView";
            this.NominasDataGridView.ReadOnly = true;
            this.NominasDataGridView.Size = new System.Drawing.Size(593, 403);
            this.NominasDataGridView.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_cab";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Anio
            // 
            this.Anio.DataPropertyName = "anio";
            this.Anio.HeaderText = "Año";
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            // 
            // semana
            // 
            this.semana.DataPropertyName = "semana";
            this.semana.HeaderText = "Semana";
            this.semana.Name = "semana";
            this.semana.ReadOnly = true;
            // 
            // id_encargado
            // 
            this.id_encargado.DataPropertyName = "encargado";
            this.id_encargado.HeaderText = "Encargado";
            this.id_encargado.Name = "id_encargado";
            this.id_encargado.ReadOnly = true;
            this.id_encargado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_encargado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NuevaToolStripButton
            // 
            this.NuevaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevaToolStripButton.Image")));
            this.NuevaToolStripButton.Name = "NuevaToolStripButton";
            this.NuevaToolStripButton.RightToLeftAutoMirrorImage = true;
            this.NuevaToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.NuevaToolStripButton.Text = "Nueva";
            this.NuevaToolStripButton.Click += new System.EventHandler(this.NuevaToolStripButton_Click);
            // 
            // FrmLoadNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.NominasDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmLoadNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Nominas";
            this.Load += new System.EventHandler(this.FrmLoadNomina_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NominasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NominasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView NominasDataGridView;
        private System.Windows.Forms.ToolStripButton CargarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.ToolStripButton NuevaToolStripButton;
        private System.Windows.Forms.BindingSource NominasBindingSource;
    }
}