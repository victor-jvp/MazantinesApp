namespace ManzantinesApp.Reports
{
    partial class FrmPreviewNomina
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.EfectivoRadioButton = new System.Windows.Forms.RadioButton();
            this.BancoRadioButton = new System.Windows.Forms.RadioButton();
            this.FiltrarCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 30);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 420);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // EfectivoRadioButton
            // 
            this.EfectivoRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EfectivoRadioButton.AutoSize = true;
            this.EfectivoRadioButton.Checked = true;
            this.EfectivoRadioButton.Enabled = false;
            this.EfectivoRadioButton.Location = new System.Drawing.Point(662, 7);
            this.EfectivoRadioButton.Name = "EfectivoRadioButton";
            this.EfectivoRadioButton.Size = new System.Drawing.Size(64, 17);
            this.EfectivoRadioButton.TabIndex = 2;
            this.EfectivoRadioButton.TabStop = true;
            this.EfectivoRadioButton.Text = "Efectivo";
            this.EfectivoRadioButton.UseVisualStyleBackColor = true;
            // 
            // BancoRadioButton
            // 
            this.BancoRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BancoRadioButton.AutoSize = true;
            this.BancoRadioButton.Enabled = false;
            this.BancoRadioButton.Location = new System.Drawing.Point(732, 7);
            this.BancoRadioButton.Name = "BancoRadioButton";
            this.BancoRadioButton.Size = new System.Drawing.Size(56, 17);
            this.BancoRadioButton.TabIndex = 3;
            this.BancoRadioButton.Text = "Banco";
            this.BancoRadioButton.UseVisualStyleBackColor = true;
            // 
            // FiltrarCheckBox
            // 
            this.FiltrarCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrarCheckBox.AutoSize = true;
            this.FiltrarCheckBox.Location = new System.Drawing.Point(602, 7);
            this.FiltrarCheckBox.Name = "FiltrarCheckBox";
            this.FiltrarCheckBox.Size = new System.Drawing.Size(54, 17);
            this.FiltrarCheckBox.TabIndex = 4;
            this.FiltrarCheckBox.Text = "Filtrar:";
            this.FiltrarCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrmPreviewNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FiltrarCheckBox);
            this.Controls.Add(this.BancoRadioButton);
            this.Controls.Add(this.EfectivoRadioButton);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FrmPreviewNomina";
            this.Text = "Vista Preliminar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPreviewCrystal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton EfectivoRadioButton;
        private System.Windows.Forms.RadioButton BancoRadioButton;
        private System.Windows.Forms.CheckBox FiltrarCheckBox;
    }
}