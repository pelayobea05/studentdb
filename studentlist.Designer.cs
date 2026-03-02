namespace WinFormsApp14
{
    partial class studentlist
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
            txtBx1 = new TextBox();
            lblMasterlist = new Label();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            lblUpdate = new Label();
            lblFirstname = new Label();
            lblLastName = new Label();
            lblCourse = new Label();
            lblSection = new Label();
            lblAge = new Label();
            txtBx2 = new TextBox();
            txtBx3 = new TextBox();
            txtBx6 = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            lblId = new Label();
            txtBx7 = new TextBox();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBx1
            // 
            txtBx1.Location = new Point(74, 60);
            txtBx1.Name = "txtBx1";
            txtBx1.Size = new Size(243, 23);
            txtBx1.TabIndex = 0;
            // 
            // lblMasterlist
            // 
            lblMasterlist.AutoSize = true;
            lblMasterlist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMasterlist.Location = new Point(74, 27);
            lblMasterlist.Name = "lblMasterlist";
            lblMasterlist.Size = new Size(173, 21);
            lblMasterlist.TabIndex = 1;
            lblMasterlist.Text = "STUDENT MASTER LIST";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(323, 54);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 33);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(360, 268);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Location = new Point(523, 42);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(156, 15);
            lblUpdate.TabIndex = 4;
            lblUpdate.Text = "update student information:";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(454, 106);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(67, 15);
            lblFirstname.TabIndex = 5;
            lblFirstname.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(456, 136);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(65, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "LastNAme:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(474, 174);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(47, 15);
            lblCourse.TabIndex = 7;
            lblCourse.Text = "Course:";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Location = new Point(472, 205);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(49, 15);
            lblSection.TabIndex = 8;
            lblSection.Text = "Section:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(483, 238);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(29, 15);
            lblAge.TabIndex = 9;
            lblAge.Text = "age:";
            // 
            // txtBx2
            // 
            txtBx2.Location = new Point(527, 106);
            txtBx2.Name = "txtBx2";
            txtBx2.Size = new Size(243, 23);
            txtBx2.TabIndex = 10;
            // 
            // txtBx3
            // 
            txtBx3.Location = new Point(527, 133);
            txtBx3.Name = "txtBx3";
            txtBx3.Size = new Size(243, 23);
            txtBx3.TabIndex = 11;
            // 
            // txtBx6
            // 
            txtBx6.Location = new Point(527, 238);
            txtBx6.Name = "txtBx6";
            txtBx6.Size = new Size(243, 23);
            txtBx6.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(569, 267);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 30);
            btnSave.TabIndex = 15;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(569, 303);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 30);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE RECORD";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(483, 72);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 17;
            lblId.Text = "ID:";
            // 
            // txtBx7
            // 
            txtBx7.Location = new Point(527, 72);
            txtBx7.Name = "txtBx7";
            txtBx7.Size = new Size(243, 23);
            txtBx7.TabIndex = 18;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(523, 171);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(243, 23);
            cmbCourse.TabIndex = 19;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(527, 205);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(243, 23);
            cmbSection.TabIndex = 20;
            // 
            // studentlist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSection);
            Controls.Add(cmbCourse);
            Controls.Add(txtBx7);
            Controls.Add(lblId);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtBx6);
            Controls.Add(txtBx3);
            Controls.Add(txtBx2);
            Controls.Add(lblAge);
            Controls.Add(lblSection);
            Controls.Add(lblCourse);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstname);
            Controls.Add(lblUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(lblMasterlist);
            Controls.Add(txtBx1);
            Name = "studentlist";
            Text = "studentlist";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBx1;
        private Label lblMasterlist;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label lblUpdate;
        private Label lblFirstname;
        private Label lblLastName;
        private Label lblCourse;
        private Label lblSection;
        private Label lblAge;
        private TextBox txtBx2;
        private TextBox txtBx3;
        private TextBox txtBx6;
        private Button btnSave;
        private Button btnDelete;
        private Label lblId;
        private TextBox txtBx7;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
    }
}