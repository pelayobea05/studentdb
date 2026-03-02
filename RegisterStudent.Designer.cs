namespace WinFormsApp14
{
    partial class RegisterStudent
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
            lblInformation = new Label();
            lblfisrtname = new Label();
            lblLastname = new Label();
            lblCourse = new Label();
            lblSection = new Label();
            lblAge = new Label();
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            txtBox3 = new TextBox();
            btnSave = new Button();
            cmbBox1 = new ComboBox();
            cmbBox2 = new ComboBox();
            SuspendLayout();
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInformation.Location = new Point(208, 62);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(258, 21);
            lblInformation.TabIndex = 0;
            lblInformation.Text = "REGISTER STUDENT INFORMATION";
            // 
            // lblfisrtname
            // 
            lblfisrtname.AutoSize = true;
            lblfisrtname.Location = new Point(187, 138);
            lblfisrtname.Name = "lblfisrtname";
            lblfisrtname.Size = new Size(76, 15);
            lblfisrtname.TabIndex = 1;
            lblfisrtname.Text = "FIRST NAME:";
            lblfisrtname.Click += label2_Click;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(187, 169);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(66, 15);
            lblLastname.TabIndex = 2;
            lblLastname.Text = "Last Name:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(187, 200);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(47, 15);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Course:";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Location = new Point(187, 227);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(49, 15);
            lblSection.TabIndex = 4;
            lblSection.Text = "Section:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(187, 260);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age:";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(288, 135);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(226, 23);
            txtBox1.TabIndex = 6;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(288, 164);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(226, 23);
            txtBox2.TabIndex = 7;
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(288, 260);
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(226, 23);
            txtBox3.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(348, 299);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 31);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbBox1
            // 
            cmbBox1.AutoCompleteCustomSource.AddRange(new string[] { "ACT ", "HM", "BSOA" });
            cmbBox1.FormattingEnabled = true;
            cmbBox1.Location = new Point(288, 193);
            cmbBox1.Name = "cmbBox1";
            cmbBox1.Size = new Size(226, 23);
            cmbBox1.TabIndex = 12;
            // 
            // cmbBox2
            // 
            cmbBox2.AutoCompleteCustomSource.AddRange(new string[] { "ACT 1A", "ACT 1B", "ACT 1C", "ACT 1D", "ACT 1E" });
            cmbBox2.FormattingEnabled = true;
            cmbBox2.Location = new Point(288, 227);
            cmbBox2.Name = "cmbBox2";
            cmbBox2.Size = new Size(226, 23);
            cmbBox2.TabIndex = 13;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbBox2);
            Controls.Add(cmbBox1);
            Controls.Add(btnSave);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(lblAge);
            Controls.Add(lblSection);
            Controls.Add(lblCourse);
            Controls.Add(lblLastname);
            Controls.Add(lblfisrtname);
            Controls.Add(lblInformation);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            Load += RegisterStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformation;
        private Label lblfisrtname;
        private Label lblLastname;
        private Label lblCourse;
        private Label lblSection;
        private Label lblAge;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private TextBox txtBox3;
        private Button btnSave;
        private ComboBox cmbBox1;
        private ComboBox cmbBox2;
    }
}