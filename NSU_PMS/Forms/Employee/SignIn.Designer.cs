namespace NSU_PMS.Forms.Employee
{
    partial class SignIn
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
            label5 = new Label();
            PassTxtBox = new TextBox();
            label2 = new Label();
            EmailTxtBox = new TextBox();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 12F);
            label5.Location = new Point(232, 199);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 16;
            label5.Text = "Password";
            // 
            // PassTxtBox
            // 
            PassTxtBox.Font = new Font("Lato", 12F);
            PassTxtBox.Location = new Point(232, 221);
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.PasswordChar = '*';
            PassTxtBox.Size = new Size(331, 27);
            PassTxtBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 12F);
            label2.Location = new Point(232, 127);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 14;
            label2.Text = "Email";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Font = new Font("Lato", 12F);
            EmailTxtBox.Location = new Point(232, 149);
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(331, 27);
            EmailTxtBox.TabIndex = 13;
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Lato", 14F);
            LoginBtn.Location = new Point(320, 312);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(129, 57);
            LoginBtn.TabIndex = 19;
            LoginBtn.Text = "Log In";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginBtn);
            Controls.Add(label5);
            Controls.Add(PassTxtBox);
            Controls.Add(label2);
            Controls.Add(EmailTxtBox);
            Name = "SignIn";
            Text = "SignIn";
            FormClosed += SignIn_FormClosed;
            Load += SignIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox PassTxtBox;
        private Label label2;
        private TextBox EmailTxtBox;
        private Button LoginBtn;
    }
}