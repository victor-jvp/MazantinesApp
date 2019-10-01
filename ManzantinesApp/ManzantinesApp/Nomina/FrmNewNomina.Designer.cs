namespace ManzantinesApp.Nomina
{
    partial class FrmNewNomina
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
            this.label1 = new System.Windows.Forms.Label();
            this.SemanaComboBox = new System.Windows.Forms.ComboBox();
            this.AnioComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EncargadoComboBox = new System.Windows.Forms.ComboBox();
            this.encargadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.encargadosTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.EncargadosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.FaltantesRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.encargadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semana:";
            // 
            // SemanaComboBox
            // 
            this.SemanaComboBox.FormattingEnabled = true;
            this.SemanaComboBox.Location = new System.Drawing.Point(90, 38);
            this.SemanaComboBox.Name = "SemanaComboBox";
            this.SemanaComboBox.Size = new System.Drawing.Size(99, 21);
            this.SemanaComboBox.TabIndex = 1;
            // 
            // AnioComboBox
            // 
            this.AnioComboBox.FormattingEnabled = true;
            this.AnioComboBox.Location = new System.Drawing.Point(90, 11);
            this.AnioComboBox.Name = "AnioComboBox";
            this.AnioComboBox.Size = new System.Drawing.Size(99, 21);
            this.AnioComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EncargadoComboBox
            // 
            this.EncargadoComboBox.DataSource = this.encargadosBindingSource;
            this.EncargadoComboBox.DisplayMember = "Encargado";
            this.EncargadoComboBox.FormattingEnabled = true;
            this.EncargadoComboBox.Location = new System.Drawing.Point(90, 65);
            this.EncargadoComboBox.Name = "EncargadoComboBox";
            this.EncargadoComboBox.Size = new System.Drawing.Size(140, 21);
            this.EncargadoComboBox.TabIndex = 5;
            this.EncargadoComboBox.ValueMember = "Id";
            // 
            // encargadosBindingSource
            // 
            this.encargadosBindingSource.DataMember = "Encargados";
            this.encargadosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Encargado:";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(257, 29);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 37);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Crear Nomina";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // encargadosTableAdapter
            // 
            this.encargadosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FaltantesRadioButton);
            this.groupBox1.Controls.Add(this.TodosRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 47);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajadores";
            // 
            // TodosRadioButton
            // 
            this.TodosRadioButton.AutoSize = true;
            this.TodosRadioButton.Checked = true;
            this.TodosRadioButton.Location = new System.Drawing.Point(13, 17);
            this.TodosRadioButton.Name = "TodosRadioButton";
            this.TodosRadioButton.Size = new System.Drawing.Size(55, 17);
            this.TodosRadioButton.TabIndex = 0;
            this.TodosRadioButton.TabStop = true;
            this.TodosRadioButton.Text = "Todos";
            this.TodosRadioButton.UseVisualStyleBackColor = true;
            // 
            // FaltantesRadioButton
            // 
            this.FaltantesRadioButton.AutoSize = true;
            this.FaltantesRadioButton.Location = new System.Drawing.Point(109, 17);
            this.FaltantesRadioButton.Name = "FaltantesRadioButton";
            this.FaltantesRadioButton.Size = new System.Drawing.Size(125, 17);
            this.FaltantesRadioButton.TabIndex = 1;
            this.FaltantesRadioButton.Text = "Faltantes por Nomina";
            this.FaltantesRadioButton.UseVisualStyleBackColor = true;
            // 
            // FrmNewNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 160);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.EncargadoComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnioComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SemanaComboBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Nomina";
            this.Load += new System.EventHandler(this.FrmNewNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.encargadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SemanaComboBox;
        private System.Windows.Forms.ComboBox AnioComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EncargadoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateButton;
        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource encargadosBindingSource;
        private Data.DataSet1TableAdapters.EncargadosTableAdapter encargadosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FaltantesRadioButton;
        private System.Windows.Forms.RadioButton TodosRadioButton;
    }
}