
namespace Company
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.AdaugaButton = new System.Windows.Forms.Button();
            this.StergeButton = new System.Windows.Forms.Button();
            this.dataMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.angajatiComboBox = new System.Windows.Forms.ComboBox();
            this.AngajatLabel = new System.Windows.Forms.Label();
            this.Orelabel = new System.Windows.Forms.Label();
            this.OrenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.turaNoaptecheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OrenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdaugaButton
            // 
            this.AdaugaButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AdaugaButton.Location = new System.Drawing.Point(689, 40);
            this.AdaugaButton.Name = "AdaugaButton";
            this.AdaugaButton.Size = new System.Drawing.Size(75, 38);
            this.AdaugaButton.TabIndex = 0;
            this.AdaugaButton.Text = "Add";
            this.AdaugaButton.UseVisualStyleBackColor = false;
            this.AdaugaButton.Click += new System.EventHandler(this.AdaugaButton_Click);
            // 
            // StergeButton
            // 
            this.StergeButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StergeButton.Location = new System.Drawing.Point(689, 163);
            this.StergeButton.Name = "StergeButton";
            this.StergeButton.Size = new System.Drawing.Size(75, 39);
            this.StergeButton.TabIndex = 1;
            this.StergeButton.Text = "Delete";
            this.StergeButton.UseVisualStyleBackColor = false;
            this.StergeButton.Click += new System.EventHandler(this.StergeButton_Click);
            // 
            // dataMonthCalendar
            // 
            this.dataMonthCalendar.Location = new System.Drawing.Point(71, 40);
            this.dataMonthCalendar.MaxSelectionCount = 1;
            this.dataMonthCalendar.Name = "dataMonthCalendar";
            this.dataMonthCalendar.TabIndex = 2;
            // 
            // angajatiComboBox
            // 
            this.angajatiComboBox.FormattingEnabled = true;
            this.angajatiComboBox.Location = new System.Drawing.Point(71, 6);
            this.angajatiComboBox.Name = "angajatiComboBox";
            this.angajatiComboBox.Size = new System.Drawing.Size(227, 21);
            this.angajatiComboBox.TabIndex = 3;
            // 
            // AngajatLabel
            // 
            this.AngajatLabel.AutoSize = true;
            this.AngajatLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AngajatLabel.Location = new System.Drawing.Point(12, 9);
            this.AngajatLabel.Name = "AngajatLabel";
            this.AngajatLabel.Size = new System.Drawing.Size(53, 13);
            this.AngajatLabel.TabIndex = 4;
            this.AngajatLabel.Text = "Employee";
            // 
            // Orelabel
            // 
            this.Orelabel.AutoSize = true;
            this.Orelabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Orelabel.Location = new System.Drawing.Point(22, 214);
            this.Orelabel.Name = "Orelabel";
            this.Orelabel.Size = new System.Drawing.Size(35, 13);
            this.Orelabel.TabIndex = 5;
            this.Orelabel.Text = "Hours";
            // 
            // OrenumericUpDown
            // 
            this.OrenumericUpDown.Location = new System.Drawing.Point(71, 212);
            this.OrenumericUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.OrenumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OrenumericUpDown.Name = "OrenumericUpDown";
            this.OrenumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.OrenumericUpDown.TabIndex = 6;
            this.OrenumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // turaNoaptecheckBox
            // 
            this.turaNoaptecheckBox.AutoSize = true;
            this.turaNoaptecheckBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.turaNoaptecheckBox.Location = new System.Drawing.Point(145, 215);
            this.turaNoaptecheckBox.Name = "turaNoaptecheckBox";
            this.turaNoaptecheckBox.Size = new System.Drawing.Size(75, 17);
            this.turaNoaptecheckBox.TabIndex = 7;
            this.turaNoaptecheckBox.Text = "Night Shift";
            this.turaNoaptecheckBox.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(25, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(739, 249);
            this.dataGridView1.TabIndex = 8;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(790, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.turaNoaptecheckBox);
            this.Controls.Add(this.OrenumericUpDown);
            this.Controls.Add(this.Orelabel);
            this.Controls.Add(this.AngajatLabel);
            this.Controls.Add(this.angajatiComboBox);
            this.Controls.Add(this.dataMonthCalendar);
            this.Controls.Add(this.StergeButton);
            this.Controls.Add(this.AdaugaButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Pontaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdaugaButton;
        private System.Windows.Forms.Button StergeButton;
        private System.Windows.Forms.MonthCalendar dataMonthCalendar;
        private System.Windows.Forms.ComboBox angajatiComboBox;
        private System.Windows.Forms.Label AngajatLabel;
        private System.Windows.Forms.Label Orelabel;
        private System.Windows.Forms.NumericUpDown OrenumericUpDown;
        private System.Windows.Forms.CheckBox turaNoaptecheckBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}