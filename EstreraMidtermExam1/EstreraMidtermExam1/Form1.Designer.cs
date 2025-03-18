namespace EstreraMidtermExam1
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
            txtVote1 = new TextBox();
            txtVote2 = new TextBox();
            txtVote3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtVote1
            // 
            txtVote1.Location = new Point(97, 107);
            txtVote1.Name = "txtVote1";
            txtVote1.Size = new Size(100, 23);
            txtVote1.TabIndex = 0;
            // 
            // txtVote2
            // 
            txtVote2.Location = new Point(97, 155);
            txtVote2.Name = "txtVote2";
            txtVote2.Size = new Size(100, 23);
            txtVote2.TabIndex = 1;
            // 
            // txtVote3
            // 
            txtVote3.Location = new Point(97, 202);
            txtVote3.Name = "txtVote3";
            txtVote3.Size = new Size(100, 23);
            txtVote3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 11.25F);
            label1.Location = new Point(25, 107);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "VOTE 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 11.25F);
            label2.Location = new Point(25, 155);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "VOTE 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 11.25F);
            label3.Location = new Point(25, 203);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "VOTE 3:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Location = new Point(105, 231);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 6;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 11.25F);
            label4.Location = new Point(229, 106);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "RESULT:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(229, 139);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 26);
            lblResult.TabIndex = 8;
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(427, 334);
            Controls.Add(lblResult);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtVote3);
            Controls.Add(txtVote2);
            Controls.Add(txtVote1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVote1;
        private TextBox txtVote2;
        private TextBox txtVote3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label lblResult;
    }
}
