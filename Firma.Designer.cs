
namespace Company
{
    partial class Company
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
            this.resurseListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // angajatiButton
            // 
            this.angajatiButton.Location = new System.Drawing.Point(42, 168);
            this.angajatiButton.Name = "angajatiButton";
            this.angajatiButton.Size = new System.Drawing.Size(75, 35);
            this.angajatiButton.TabIndex = 0;
            this.angajatiButton.Text = "Employees";
            this.angajatiButton.UseVisualStyleBackColor = true;
            this.angajatiButton.Click += new System.EventHandler(this.angajatiButton_Click);
            // 
            // pontajButton
            // 
            this.pontajButton.Location = new System.Drawing.Point(220, 166);
            this.pontajButton.Name = "pontajButton";
            this.pontajButton.Size = new System.Drawing.Size(75, 37);
            this.pontajButton.TabIndex = 1;
            this.pontajButton.Text = "Booking";
            this.pontajButton.UseVisualStyleBackColor = true;
            this.pontajButton.Click += new System.EventHandler(this.pontajButton_Click);
            // 
            // raportButton
            // 
            this.raportButton.Location = new System.Drawing.Point(393, 168);
            this.raportButton.Name = "raportButton";
            this.raportButton.Size = new System.Drawing.Size(75, 35);
            this.raportButton.TabIndex = 2;
            this.raportButton.Text = "Employee Report";
            this.raportButton.UseVisualStyleBackColor = true;
            this.raportButton.Click += new System.EventHandler(this.raportButton_Click);
            // 
            // resurseListView
            // 
            this.resurseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.resurseListView.HideSelection = false;
            this.resurseListView.Location = new System.Drawing.Point(42, 38);
            this.resurseListView.Name = "resurseListView";
            this.resurseListView.Size = new System.Drawing.Size(497, 103);
            this.resurseListView.TabIndex = 3;
            this.resurseListView.UseCompatibleStateImageBehavior = false;
            this.resurseListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employees Nr";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Night Hours";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Night Hours Cost";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Day Hours";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Day Hours Cost";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Cost";
            this.columnHeader6.Width = 80;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(393, 354);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 21);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Config";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 387);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.resurseListView);
            this.Controls.Add(this.raportButton);
            this.Controls.Add(this.pontajButton);
            this.Controls.Add(this.angajatiButton);
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Firma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button angajatiButton;
        private System.Windows.Forms.Button pontajButton;
        private System.Windows.Forms.Button raportButton;
        private System.Windows.Forms.ListView resurseListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button settingsButton;
    }
}

