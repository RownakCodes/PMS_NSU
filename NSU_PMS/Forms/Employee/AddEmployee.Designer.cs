namespace NSU_PMS.Forms.Employee
{
    partial class AddEmployee
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
            NameTxtBox = new TextBox();
            label1 = new Label();
            EmailTxtBox = new TextBox();
            label2 = new Label();
            NidTxtBox = new TextBox();
            label3 = new Label();
            PhoneTxtBox = new TextBox();
            label4 = new Label();
            PassTxtBox = new TextBox();
            label5 = new Label();
            SalaryTxtBox = new TextBox();
            label6 = new Label();
            AddressTxtBox = new TextBox();
            label7 = new Label();
            SaveBtn = new Button();
            CommentsTxtBox = new TextBox();
            ComentTxtBox = new Label();
            SuspendLayout();
            // 
            // NameTxtBox
            // 
            NameTxtBox.Font = new Font("Lato", 12F);
            NameTxtBox.Location = new Point(12, 41);
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.Size = new Size(331, 27);
            NameTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 12F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Font = new Font("Lato", 12F);
            EmailTxtBox.Location = new Point(371, 41);
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(331, 27);
            EmailTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 12F);
            label2.Location = new Point(371, 19);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // NidTxtBox
            // 
            NidTxtBox.Font = new Font("Lato", 12F);
            NidTxtBox.Location = new Point(12, 113);
            NidTxtBox.Name = "NidTxtBox";
            NidTxtBox.Size = new Size(331, 27);
            NidTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 12F);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 8;
            label3.Text = "NID";
            // 
            // PhoneTxtBox
            // 
            PhoneTxtBox.Font = new Font("Lato", 12F);
            PhoneTxtBox.Location = new Point(757, 113);
            PhoneTxtBox.Name = "PhoneTxtBox";
            PhoneTxtBox.Size = new Size(331, 27);
            PhoneTxtBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 12F);
            label4.Location = new Point(757, 91);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 10;
            label4.Text = "Phone";
            // 
            // PassTxtBox
            // 
            PassTxtBox.Font = new Font("Lato", 12F);
            PassTxtBox.Location = new Point(371, 113);
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.Size = new Size(331, 27);
            PassTxtBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 12F);
            label5.Location = new Point(371, 91);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 12;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // SalaryTxtBox
            // 
            SalaryTxtBox.Font = new Font("Lato", 12F);
            SalaryTxtBox.Location = new Point(757, 41);
            SalaryTxtBox.Name = "SalaryTxtBox";
            SalaryTxtBox.Size = new Size(331, 27);
            SalaryTxtBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 12F);
            label6.Location = new Point(757, 19);
            label6.Name = "label6";
            label6.Size = new Size(51, 19);
            label6.TabIndex = 14;
            label6.Text = "Salary";
            // 
            // AddressTxtBox
            // 
            AddressTxtBox.Font = new Font("Lato", 12F);
            AddressTxtBox.Location = new Point(12, 182);
            AddressTxtBox.Multiline = true;
            AddressTxtBox.Name = "AddressTxtBox";
            AddressTxtBox.Size = new Size(331, 93);
            AddressTxtBox.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 12F);
            label7.Location = new Point(12, 160);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 17;
            label7.Text = "Address";
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Lato", 14F);
            SaveBtn.Location = new Point(959, 218);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(129, 57);
            SaveBtn.TabIndex = 18;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CommentsTxtBox
            // 
            CommentsTxtBox.Font = new Font("Lato", 12F);
            CommentsTxtBox.Location = new Point(371, 182);
            CommentsTxtBox.Multiline = true;
            CommentsTxtBox.Name = "CommentsTxtBox";
            CommentsTxtBox.Size = new Size(331, 93);
            CommentsTxtBox.TabIndex = 19;
            // 
            // ComentTxtBox
            // 
            ComentTxtBox.AutoSize = true;
            ComentTxtBox.Font = new Font("Lato", 12F);
            ComentTxtBox.Location = new Point(371, 160);
            ComentTxtBox.Name = "ComentTxtBox";
            ComentTxtBox.Size = new Size(85, 19);
            ComentTxtBox.TabIndex = 20;
            ComentTxtBox.Text = "Comments";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 323);
            Controls.Add(ComentTxtBox);
            Controls.Add(CommentsTxtBox);
            Controls.Add(SaveBtn);
            Controls.Add(label7);
            Controls.Add(AddressTxtBox);
            Controls.Add(label6);
            Controls.Add(SalaryTxtBox);
            Controls.Add(label5);
            Controls.Add(PassTxtBox);
            Controls.Add(label4);
            Controls.Add(PhoneTxtBox);
            Controls.Add(label3);
            Controls.Add(NidTxtBox);
            Controls.Add(label2);
            Controls.Add(EmailTxtBox);
            Controls.Add(label1);
            Controls.Add(NameTxtBox);
            Name = "AddEmployee";
            Text = "AddEmployee";
            FormClosed += AddEmployee_FormClosed;
            Load += AddEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTxtBox;
        private Label label1;
        private TextBox EmailTxtBox;
        private Label label2;
        private TextBox NidTxtBox;
        private Label label3;
        private TextBox PhoneTxtBox;
        private Label label4;
        private TextBox PassTxtBox;
        private Label label5;
        private TextBox SalaryTxtBox;
        private Label label6;
        private TextBox AddressTxtBox;
        private Label label7;
        private Button SaveBtn;
        private TextBox CommentsTxtBox;
        private Label ComentTxtBox;
    }
}