
namespace Company
{
    partial class EmployeeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeReport));
            this.angajatComboBox = new System.Windows.Forms.ComboBox();
            this.angajatLabel = new System.Windows.Forms.Label();
            this.raportDataGridView = new System.Windows.Forms.DataGridView();
            this.raportButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.oreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // angajatComboBox
            // 
            this.angajatComboBox.FormattingEnabled = true;
            this.angajatComboBox.Location = new System.Drawing.Point(81, 28);
            this.angajatComboBox.Name = "angajatComboBox";
            this.angajatComboBox.Size = new System.Drawing.Size(121, 21);
            this.angajatComboBox.TabIndex = 0;
            // 
            // angajatLabel
            // 
            this.angajatLabel.AutoSize = true;
            this.angajatLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.angajatLabel.Location = new System.Drawing.Point(23, 31);
            this.angajatLabel.Name = "angajatLabel";
            this.angajatLabel.Size = new System.Drawing.Size(53, 13);
            this.angajatLabel.TabIndex = 1;
            this.angajatLabel.Text = "Employee";
            // 
            // raportDataGridView
            // 
            this.raportDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.raportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raportDataGridView.Location = new System.Drawing.Point(41, 141);
            this.raportDataGridView.Name = "raportDataGridView";
            this.raportDataGridView.Size = new System.Drawing.Size(724, 256);
            this.raportDataGridView.TabIndex = 2;
            // 
            // raportButton
            // 
            this.raportButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.raportButton.Location = new System.Drawing.Point(690, 28);
            this.raportButton.Name = "raportButton";
            this.raportButton.Size = new System.Drawing.Size(75, 34);
            this.raportButton.TabIndex = 3;
            this.raportButton.Text = "Generate Report";
            this.raportButton.UseVisualStyleBackColor = false;
            this.raportButton.Click += new System.EventHandler(this.raportButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Location = new System.Drawing.Point(208, 36);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(62, 13);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total Hours";
            // 
            // oreLabel
            // 
            this.oreLabel.AutoSize = true;
            this.oreLabel.Location = new System.Drawing.Point(276, 36);
            this.oreLabel.Name = "oreLabel";
            this.oreLabel.Size = new System.Drawing.Size(0, 13);
            this.oreLabel.TabIndex = 5;
            // 
            // EmployeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.oreLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.raportButton);
            this.Controls.Add(this.raportDataGridView);
            this.Controls.Add(this.angajatLabel);
            this.Controls.Add(this.angajatComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Report";
            this.Load += new System.EventHandler(this.RaportAngajat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox angajatComboBox;
        private System.Windows.Forms.Label angajatLabel;
        private System.Windows.Forms.DataGridView raportDataGridView;
        private System.Windows.Forms.Button raportButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label oreLabel;
    }
}