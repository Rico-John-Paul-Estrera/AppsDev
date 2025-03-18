namespace EstreraMidtermExam2
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
            txtSideA = new TextBox();
            txtSideB = new TextBox();
            txtSideC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCheck = new Button();
            label4 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtSideA
            // 
            txtSideA.Location = new Point(99, 81);
            txtSideA.Name = "txtSideA";
            txtSideA.Size = new Size(100, 23);
            txtSideA.TabIndex = 0;
            // 
            // txtSideB
            // 
            txtSideB.Location = new Point(99, 137);
            txtSideB.Name = "txtSideB";
            txtSideB.Size = new Size(100, 23);
            txtSideB.TabIndex = 1;
            // 
            // txtSideC
            // 
            txtSideC.Location = new Point(99, 185);
            txtSideC.Name = "txtSideC";
            txtSideC.Size = new Size(100, 23);
            txtSideC.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 84);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 137);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 193);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(108, 214);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "SUBMIT";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 84);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 7;
            label4.Text = "RESULT:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(245, 125);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(10, 15);
            lblResult.TabIndex = 8;
            lblResult.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(427, 334);
            Controls.Add(lblResult);
            Controls.Add(label4);
            Controls.Add(btnCheck);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSideC);
            Controls.Add(txtSideB);
            Controls.Add(txtSideA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSideA;
        private TextBox txtSideB;
        private TextBox txtSideC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCheck;
        private Label label4;
        private Label lblResult;
    }
}
