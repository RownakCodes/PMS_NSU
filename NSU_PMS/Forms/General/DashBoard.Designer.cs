namespace NSU_PMS.Forms.General
{
    partial class DashBoard
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
            AddProductBtn = new Button();
            AddCategoryBtn = new Button();
            AddEmployeeBtn = new Button();
            ExitBtn = new Button();
            AddClientBtn = new Button();
            SalesBtn = new Button();
            SeeClientsBtn = new Button();
            SuspendLayout();
            // 
            // AddProductBtn
            // 
            AddProductBtn.Font = new Font("Lato", 14F);
            AddProductBtn.Location = new Point(22, 45);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(257, 57);
            AddProductBtn.TabIndex = 20;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.Font = new Font("Lato", 14F);
            AddCategoryBtn.Location = new Point(22, 146);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Size = new Size(257, 57);
            AddCategoryBtn.TabIndex = 21;
            AddCategoryBtn.Text = "Add Category";
            AddCategoryBtn.UseVisualStyleBackColor = true;
            AddCategoryBtn.Click += AddCategoryBtn_Click;
            // 
            // AddEmployeeBtn
            // 
            AddEmployeeBtn.Font = new Font("Lato", 14F);
            AddEmployeeBtn.Location = new Point(22, 249);
            AddEmployeeBtn.Name = "AddEmployeeBtn";
            AddEmployeeBtn.Size = new Size(257, 57);
            AddEmployeeBtn.TabIndex = 22;
            AddEmployeeBtn.Text = "Add Employee";
            AddEmployeeBtn.UseVisualStyleBackColor = true;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Font = new Font("Lato", 14F);
            ExitBtn.Location = new Point(22, 346);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(257, 57);
            ExitBtn.TabIndex = 23;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // AddClientBtn
            // 
            AddClientBtn.Font = new Font("Lato", 14F);
            AddClientBtn.Location = new Point(319, 45);
            AddClientBtn.Name = "AddClientBtn";
            AddClientBtn.Size = new Size(257, 57);
            AddClientBtn.TabIndex = 24;
            AddClientBtn.Text = "Add Client";
            AddClientBtn.UseVisualStyleBackColor = true;
            AddClientBtn.Click += AddClientBtn_Click;
            // 
            // SalesBtn
            // 
            SalesBtn.Font = new Font("Lato", 14F);
            SalesBtn.Location = new Point(319, 146);
            SalesBtn.Name = "SalesBtn";
            SalesBtn.Size = new Size(257, 57);
            SalesBtn.TabIndex = 25;
            SalesBtn.Text = "Sales";
            SalesBtn.UseVisualStyleBackColor = true;
            SalesBtn.Click += SalesBtn_Click;
            // 
            // SeeClientsBtn
            // 
            SeeClientsBtn.Font = new Font("Lato", 14F);
            SeeClientsBtn.Location = new Point(614, 45);
            SeeClientsBtn.Name = "SeeClientsBtn";
            SeeClientsBtn.Size = new Size(257, 57);
            SeeClientsBtn.TabIndex = 26;
            SeeClientsBtn.Text = "See Clients";
            SeeClientsBtn.UseVisualStyleBackColor = true;
            SeeClientsBtn.Click += SeeClientsBtn_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 450);
            Controls.Add(SeeClientsBtn);
            Controls.Add(SalesBtn);
            Controls.Add(AddClientBtn);
            Controls.Add(ExitBtn);
            Controls.Add(AddEmployeeBtn);
            Controls.Add(AddCategoryBtn);
            Controls.Add(AddProductBtn);
            Name = "DashBoard";
            Text = "DashBoard";
            FormClosed += DashBoard_FormClosed;
            Load += DashBoard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AddProductBtn;
        private Button AddCategoryBtn;
        private Button AddEmployeeBtn;
        private Button ExitBtn;
        private Button AddClientBtn;
        private Button SalesBtn;
        private Button SeeClientsBtn;
    }
}