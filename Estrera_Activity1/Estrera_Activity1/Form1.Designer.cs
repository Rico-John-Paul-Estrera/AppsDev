namespace Estrera_Activity1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            txtEmail = new TextBox();
            txtCourse = new TextBox();
            btnSubmit = new Button();
            txtFamilyName = new TextBox();
            lstEntries = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Book Antiqua", 9.75F);
            txtFirstName.Location = new Point(47, 113);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(169, 24);
            txtFirstName.TabIndex = 0;
            txtFirstName.Text = "First Name";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Book Antiqua", 9.75F);
            txtMiddleName.Location = new Point(47, 157);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(169, 24);
            txtMiddleName.TabIndex = 1;
            txtMiddleName.Text = "Middle Name";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Book Antiqua", 9.75F);
            txtAge.Location = new Point(47, 240);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(169, 24);
            txtAge.TabIndex = 3;
            txtAge.Text = "Email Address";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Book Antiqua", 9.75F);
            txtEmail.Location = new Point(47, 285);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(169, 24);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "Age";
            // 
            // txtCourse
            // 
            txtCourse.Font = new Font("Book Antiqua", 9.75F);
            txtCourse.Location = new Point(47, 325);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(169, 24);
            txtCourse.TabIndex = 5;
            txtCourse.Text = "Course";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.MenuHighlight;
            btnSubmit.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ControlLightLight;
            btnSubmit.Location = new Point(82, 357);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(86, 29);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtFamilyName
            // 
            txtFamilyName.Font = new Font("Book Antiqua", 9.75F);
            txtFamilyName.Location = new Point(47, 197);
            txtFamilyName.Name = "txtFamilyName";
            txtFamilyName.Size = new Size(169, 24);
            txtFamilyName.TabIndex = 8;
            txtFamilyName.Text = "Family Name";
            // 
            // lstEntries
            // 
            lstEntries.Font = new Font("Book Antiqua", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstEntries.ForeColor = SystemColors.Desktop;
            lstEntries.FormattingEnabled = true;
            lstEntries.ItemHeight = 20;
            lstEntries.Location = new Point(361, 119);
            lstEntries.Name = "lstEntries";
            lstEntries.Size = new Size(271, 224);
            lstEntries.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 18F, FontStyle.Bold);
            label1.Location = new Point(40, 72);
            label1.Name = "label1";
            label1.Size = new Size(268, 28);
            label1.TabIndex = 10;
            label1.Text = "Enter Your Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 18F, FontStyle.Bold);
            label2.Location = new Point(360, 72);
            label2.Name = "label2";
            label2.Size = new Size(254, 28);
            label2.TabIndex = 11;
            label2.Text = "All Submitted Entries";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(673, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstEntries);
            Controls.Add(txtFamilyName);
            Controls.Add(btnSubmit);
            Controls.Add(txtCourse);
            Controls.Add(txtEmail);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ESTRERA_ACTIVITY1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private TextBox txtEmail;
        private TextBox txtCourse;
        private Button btnSubmit;
        private TextBox txtFamilyName;
        private ListBox lstEntries;
        private Label label1;
        private Label label2;
    }
}
