
namespace Firma
{
    partial class Firma
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
            this.angajatiButton = new System.Windows.Forms.Button();
            this.pontajButton = new System.Windows.Forms.Button();
            this.raportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // angajatiButton
            // 
            this.angajatiButton.Location = new System.Drawing.Point(453, 38);
            this.angajatiButton.Name = "angajatiButton";
            this.angajatiButton.Size = new System.Drawing.Size(75, 35);
            this.angajatiButton.TabIndex = 0;
            this.angajatiButton.Text = "Angajati";
            this.angajatiButton.UseVisualStyleBackColor = true;
            this.angajatiButton.Click += new System.EventHandler(this.angajatiButton_Click);
            // 
            // pontajButton
            // 
            this.pontajButton.Location = new System.Drawing.Point(453, 96);
            this.pontajButton.Name = "pontajButton";
            this.pontajButton.Size = new System.Drawing.Size(75, 37);
            this.pontajButton.TabIndex = 1;
            this.pontajButton.Text = "Pontaj";
            this.pontajButton.UseVisualStyleBackColor = true;
            this.pontajButton.Click += new System.EventHandler(this.pontajButton_Click);
            // 
            // raportButton
            // 
            this.raportButton.Location = new System.Drawing.Point(453, 158);
            this.raportButton.Name = "raportButton";
            this.raportButton.Size = new System.Drawing.Size(75, 36);
            this.raportButton.TabIndex = 2;
            this.raportButton.Text = "Raport Angajat";
            this.raportButton.UseVisualStyleBackColor = true;
            this.raportButton.Click += new System.EventHandler(this.raportButton_Click);
            // 
            // Firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 366);
            this.Controls.Add(this.raportButton);
            this.Controls.Add(this.pontajButton);
            this.Controls.Add(this.angajatiButton);
            this.Name = "Firma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button angajatiButton;
        private System.Windows.Forms.Button pontajButton;
        private System.Windows.Forms.Button raportButton;
    }
}

