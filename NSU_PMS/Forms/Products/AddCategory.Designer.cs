namespace NSU_PMS.Forms.Products
{
    partial class AddCategory
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
            DescriptionTxtBox = new TextBox();
            label7 = new Label();
            label2 = new Label();
            CategoryTxtBox = new TextBox();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // DescriptionTxtBox
            // 
            DescriptionTxtBox.Font = new Font("Lato", 12F);
            DescriptionTxtBox.Location = new Point(12, 131);
            DescriptionTxtBox.Multiline = true;
            DescriptionTxtBox.Name = "DescriptionTxtBox";
            DescriptionTxtBox.Size = new Size(682, 168);
            DescriptionTxtBox.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 12F);
            label7.Location = new Point(12, 109);
            label7.Name = "label7";
            label7.Size = new Size(90, 19);
            label7.TabIndex = 19;
            label7.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 12F);
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 16;
            label2.Text = "Category";
            // 
            // CategoryTxtBox
            // 
            CategoryTxtBox.Font = new Font("Lato", 12F);
            CategoryTxtBox.Location = new Point(12, 52);
            CategoryTxtBox.Name = "CategoryTxtBox";
            CategoryTxtBox.Size = new Size(331, 27);
            CategoryTxtBox.TabIndex = 15;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Lato", 14F);
            SaveBtn.Location = new Point(565, 341);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(129, 57);
            SaveBtn.TabIndex = 21;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 410);
            Controls.Add(SaveBtn);
            Controls.Add(DescriptionTxtBox);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(CategoryTxtBox);
            Name = "AddCategory";
            Text = "AddCategory";
            FormClosed += AddCategory_FormClosed;
            Load += AddCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DescriptionTxtBox;
        private Label label7;
        private Label label2;
        private TextBox CategoryTxtBox;
        private Button SaveBtn;
    }
}