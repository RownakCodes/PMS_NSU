namespace NSU_PMS.Forms.Client
{
    partial class AddClient
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
            ComentTxtBox = new Label();
            CommentsTxtBox = new TextBox();
            SaveBtn = new Button();
            label7 = new Label();
            AddressTxtBox = new TextBox();
            label4 = new Label();
            PhoneTxtBox = new TextBox();
            label2 = new Label();
            EmailTxtBox = new TextBox();
            label1 = new Label();
            NameTxtBox = new TextBox();
            SuspendLayout();
            // 
            // ComentTxtBox
            // 
            ComentTxtBox.AutoSize = true;
            ComentTxtBox.Font = new Font("Lato", 12F);
            ComentTxtBox.Location = new Point(371, 81);
            ComentTxtBox.Name = "ComentTxtBox";
            ComentTxtBox.Size = new Size(85, 19);
            ComentTxtBox.TabIndex = 37;
            ComentTxtBox.Text = "Comments";
            // 
            // CommentsTxtBox
            // 
            CommentsTxtBox.Font = new Font("Lato", 12F);
            CommentsTxtBox.Location = new Point(371, 103);
            CommentsTxtBox.Multiline = true;
            CommentsTxtBox.Name = "CommentsTxtBox";
            CommentsTxtBox.Size = new Size(331, 93);
            CommentsTxtBox.TabIndex = 36;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Lato", 14F);
            SaveBtn.Location = new Point(959, 139);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(129, 57);
            SaveBtn.TabIndex = 35;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 12F);
            label7.Location = new Point(12, 81);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 34;
            label7.Text = "Address";
            // 
            // AddressTxtBox
            // 
            AddressTxtBox.Font = new Font("Lato", 12F);
            AddressTxtBox.Location = new Point(12, 103);
            AddressTxtBox.Multiline = true;
            AddressTxtBox.Name = "AddressTxtBox";
            AddressTxtBox.Size = new Size(331, 93);
            AddressTxtBox.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 12F);
            label4.Location = new Point(757, 9);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 28;
            label4.Text = "Phone";
            // 
            // PhoneTxtBox
            // 
            PhoneTxtBox.Font = new Font("Lato", 12F);
            PhoneTxtBox.Location = new Point(757, 31);
            PhoneTxtBox.Name = "PhoneTxtBox";
            PhoneTxtBox.Size = new Size(331, 27);
            PhoneTxtBox.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 12F);
            label2.Location = new Point(371, 9);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 24;
            label2.Text = "Email";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Font = new Font("Lato", 12F);
            EmailTxtBox.Location = new Point(371, 31);
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(331, 27);
            EmailTxtBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 22;
            label1.Text = "Name";
            // 
            // NameTxtBox
            // 
            NameTxtBox.Font = new Font("Lato", 12F);
            NameTxtBox.Location = new Point(12, 31);
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.Size = new Size(331, 27);
            NameTxtBox.TabIndex = 21;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 218);
            Controls.Add(ComentTxtBox);
            Controls.Add(CommentsTxtBox);
            Controls.Add(SaveBtn);
            Controls.Add(label7);
            Controls.Add(AddressTxtBox);
            Controls.Add(label4);
            Controls.Add(PhoneTxtBox);
            Controls.Add(label2);
            Controls.Add(EmailTxtBox);
            Controls.Add(label1);
            Controls.Add(NameTxtBox);
            Name = "AddClient";
            Text = "AddClient";
            FormClosed += AddClient_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ComentTxtBox;
        private TextBox CommentsTxtBox;
        private Button SaveBtn;
        private Label label7;
        private TextBox AddressTxtBox;
        private Label label4;
        private TextBox PhoneTxtBox;
        private Label label2;
        private TextBox EmailTxtBox;
        private Label label1;
        private TextBox NameTxtBox;
    }
}