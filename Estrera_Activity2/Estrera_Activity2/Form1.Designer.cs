namespace Estrera_Activity2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.sbtBtn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Information";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDisplay.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(492, 43);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(310, 33);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "All Submitted Entries";
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(87, 93);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(208, 26);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(87, 137);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(207, 26);
            this.txtMiddleName.TabIndex = 3;
            this.txtMiddleName.Text = "Middle Name";
            this.txtMiddleName.TextChanged += new System.EventHandler(this.txtMiddleName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(87, 183);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(207, 26);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // numAge
            // 
            this.numAge.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAge.Location = new System.Drawing.Point(136, 226);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(158, 26);
            this.numAge.TabIndex = 5;
            this.numAge.ValueChanged += new System.EventHandler(this.numAge_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(86, 276);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 26);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "Email Address";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(86, 324);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(208, 26);
            this.txtCourse.TabIndex = 7;
            this.txtCourse.Text = "Course";
            this.txtCourse.TextChanged += new System.EventHandler(this.txtCourse_TextChanged);
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBoxDisplay.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDisplay.Location = new System.Drawing.Point(498, 84);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.Size = new System.Drawing.Size(308, 265);
            this.richTextBoxDisplay.TabIndex = 8;
            this.richTextBoxDisplay.Text = "";
            this.richTextBoxDisplay.TextChanged += new System.EventHandler(this.richTextBoxDisplay_TextChanged);
            // 
            // sbtBtn
            // 
            this.sbtBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sbtBtn.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtBtn.Location = new System.Drawing.Point(136, 371);
            this.sbtBtn.Name = "sbtBtn";
            this.sbtBtn.Size = new System.Drawing.Size(85, 33);
            this.sbtBtn.TabIndex = 9;
            this.sbtBtn.Text = "Submit";
            this.sbtBtn.UseVisualStyleBackColor = false;
            this.sbtBtn.Click += new System.EventHandler(this.sbtBtn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(497, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 34);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(599, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(82, 229);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(51, 23);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 527);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.sbtBtn);
            this.Controls.Add(this.richTextBoxDisplay);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTRERA_ACTIVITY2";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.Button sbtBtn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAge;
    }
}


