
namespace Company
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.costOraLabel = new System.Windows.Forms.Label();
            this.numeFirmaLabel = new System.Windows.Forms.Label();
            this.numeFirmaTextBox = new System.Windows.Forms.TextBox();
            this.costOreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.costOreNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // costOraLabel
            // 
            this.costOraLabel.AutoSize = true;
            this.costOraLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.costOraLabel.Location = new System.Drawing.Point(12, 53);
            this.costOraLabel.Name = "costOraLabel";
            this.costOraLabel.Size = new System.Drawing.Size(61, 13);
            this.costOraLabel.TabIndex = 0;
            this.costOraLabel.Text = "Hourly Cost";
            // 
            // numeFirmaLabel
            // 
            this.numeFirmaLabel.AutoSize = true;
            this.numeFirmaLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numeFirmaLabel.Location = new System.Drawing.Point(12, 24);
            this.numeFirmaLabel.Name = "numeFirmaLabel";
            this.numeFirmaLabel.Size = new System.Drawing.Size(82, 13);
            this.numeFirmaLabel.TabIndex = 1;
            this.numeFirmaLabel.Text = "Company Name";
            this.numeFirmaLabel.Click += new System.EventHandler(this.numeFirmaLabel_Click);
            // 
            // numeFirmaTextBox
            // 
            this.numeFirmaTextBox.Location = new System.Drawing.Point(110, 24);
            this.numeFirmaTextBox.Name = "numeFirmaTextBox";
            this.numeFirmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeFirmaTextBox.TabIndex = 2;
            // 
            // costOreNumericUpDown
            // 
            this.costOreNumericUpDown.Location = new System.Drawing.Point(110, 51);
            this.costOreNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.costOreNumericUpDown.Name = "costOreNumericUpDown";
            this.costOreNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.costOreNumericUpDown.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Khaki;
            this.saveButton.Location = new System.Drawing.Point(110, 77);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 352);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.costOreNumericUpDown);
            this.Controls.Add(this.numeFirmaTextBox);
            this.Controls.Add(this.numeFirmaLabel);
            this.Controls.Add(this.costOraLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costOreNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label costOraLabel;
        private System.Windows.Forms.Label numeFirmaLabel;
        private System.Windows.Forms.TextBox numeFirmaTextBox;
        private System.Windows.Forms.NumericUpDown costOreNumericUpDown;
        private System.Windows.Forms.Button saveButton;
    }
}