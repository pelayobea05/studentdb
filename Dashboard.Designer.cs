namespace WinFormsApp14
{
    partial class Dashboard
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
            btnRegister = new Button();
            btnStudentlist = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(103, 160);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(273, 43);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "RESGISTER STUDENT";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnStudentlist
            // 
            btnStudentlist.Location = new Point(396, 160);
            btnStudentlist.Name = "btnStudentlist";
            btnStudentlist.Size = new Size(259, 43);
            btnStudentlist.TabIndex = 1;
            btnStudentlist.Text = "STUDENT LIST";
            btnStudentlist.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStudentlist);
            Controls.Add(btnRegister);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnStudentlist;
    }
}