
namespace Company
{
    partial class Employees
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
            this.numeLabel = new System.Windows.Forms.Label();
            this.numeBox = new System.Windows.Forms.TextBox();
            this.prenumeBox = new System.Windows.Forms.TextBox();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.dataNasteriiLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.telefonBox = new System.Windows.Forms.TextBox();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.angajatiListView = new System.Windows.Forms.ListView();
            this.IdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrenumeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelefonHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StergeButton = new System.Windows.Forms.Button();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.Location = new System.Drawing.Point(28, 36);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(57, 13);
            this.numeLabel.TabIndex = 0;
            this.numeLabel.Text = "First Name";
            this.numeLabel.Click += new System.EventHandler(this.numeLabel_Click);
            // 
            // numeBox
            // 
            this.numeBox.Location = new System.Drawing.Point(109, 29);
            this.numeBox.Name = "numeBox";
            this.numeBox.Size = new System.Drawing.Size(174, 20);
            this.numeBox.TabIndex = 1;
            // 
            // prenumeBox
            // 
            this.prenumeBox.Location = new System.Drawing.Point(109, 55);
            this.prenumeBox.Name = "prenumeBox";
            this.prenumeBox.Size = new System.Drawing.Size(174, 20);
            this.prenumeBox.TabIndex = 3;
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.Location = new System.Drawing.Point(27, 62);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(58, 13);
            this.prenumeLabel.TabIndex = 2;
            this.prenumeLabel.Text = "Last Name";
            // 
            // dataNasteriiLabel
            // 
            this.dataNasteriiLabel.AutoSize = true;
            this.dataNasteriiLabel.Location = new System.Drawing.Point(31, 88);
            this.dataNasteriiLabel.Name = "dataNasteriiLabel";
            this.dataNasteriiLabel.Size = new System.Drawing.Size(54, 13);
            this.dataNasteriiLabel.TabIndex = 4;
            this.dataNasteriiLabel.Text = "Birth Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(48, 112);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(37, 17);
            this.telefonLabel.TabIndex = 6;
            this.telefonLabel.Text = "Phone";
            this.telefonLabel.UseCompatibleTextRendering = true;
            // 
            // telefonBox
            // 
            this.telefonBox.Location = new System.Drawing.Point(109, 107);
            this.telefonBox.Name = "telefonBox";
            this.telefonBox.Size = new System.Drawing.Size(174, 20);
            this.telefonBox.TabIndex = 7;
            // 
            // adaugaButton
            // 
            this.adaugaButton.Location = new System.Drawing.Point(557, 29);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(80, 37);
            this.adaugaButton.TabIndex = 8;
            this.adaugaButton.Text = "Add";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // angajatiListView
            // 
            this.angajatiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.NumeHeader,
            this.PrenumeHeader,
            this.DataHeader,
            this.TelefonHeader});
            this.angajatiListView.FullRowSelect = true;
            this.angajatiListView.GridLines = true;
            this.angajatiListView.HideSelection = false;
            this.angajatiListView.Location = new System.Drawing.Point(30, 178);
            this.angajatiListView.Name = "angajatiListView";
            this.angajatiListView.Size = new System.Drawing.Size(649, 239);
            this.angajatiListView.TabIndex = 9;
            this.angajatiListView.UseCompatibleStateImageBehavior = false;
            this.angajatiListView.View = System.Windows.Forms.View.Details;
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "Id";
            // 
            // NumeHeader
            // 
            this.NumeHeader.Text = "First Name";
            this.NumeHeader.Width = 170;
            // 
            // PrenumeHeader
            // 
            this.PrenumeHeader.Text = "Last Name";
            this.PrenumeHeader.Width = 170;
            // 
            // DataHeader
            // 
            this.DataHeader.Text = "Birth Date";
            this.DataHeader.Width = 170;
            // 
            // TelefonHeader
            // 
            this.TelefonHeader.Text = "Phone";
            this.TelefonHeader.Width = 170;
            // 
            // StergeButton
            // 
            this.StergeButton.Location = new System.Drawing.Point(557, 92);
            this.StergeButton.Name = "StergeButton";
            this.StergeButton.Size = new System.Drawing.Size(80, 37);
            this.StergeButton.TabIndex = 10;
            this.StergeButton.Text = "Delete";
            this.StergeButton.UseVisualStyleBackColor = true;
            this.StergeButton.Click += new System.EventHandler(this.StergeButton_Click);
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.Location = new System.Drawing.Point(349, 29);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.idNumericUpDown.TabIndex = 11;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(327, 32);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 13);
            this.idLabel.TabIndex = 12;
            this.idLabel.Text = "Id";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.StergeButton);
            this.Controls.Add(this.angajatiListView);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.telefonBox);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataNasteriiLabel);
            this.Controls.Add(this.prenumeBox);
            this.Controls.Add(this.prenumeLabel);
            this.Controls.Add(this.numeBox);
            this.Controls.Add(this.numeLabel);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Angajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.TextBox numeBox;
        private System.Windows.Forms.TextBox prenumeBox;
        private System.Windows.Forms.Label prenumeLabel;
        private System.Windows.Forms.Label dataNasteriiLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.TextBox telefonBox;
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.ListView angajatiListView;
        private System.Windows.Forms.ColumnHeader NumeHeader;
        private System.Windows.Forms.ColumnHeader PrenumeHeader;
        private System.Windows.Forms.ColumnHeader DataHeader;
        private System.Windows.Forms.ColumnHeader TelefonHeader;
        private System.Windows.Forms.Button StergeButton;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ColumnHeader IdHeader;
    }
}