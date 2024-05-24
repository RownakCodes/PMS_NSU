﻿namespace NSU_PMS.Forms.General
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
            label3 = new Label();
            SuspendLayout();
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.Transparent;
            AddProductBtn.FlatStyle = FlatStyle.Popup;
            AddProductBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold);
            AddProductBtn.Location = new Point(40, 99);
            AddProductBtn.Margin = new Padding(4, 3, 4, 3);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(257, 51);
            AddProductBtn.TabIndex = 20;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.FlatStyle = FlatStyle.Popup;
            AddCategoryBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold);
            AddCategoryBtn.Location = new Point(40, 200);
            AddCategoryBtn.Margin = new Padding(4, 3, 4, 3);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Size = new Size(257, 51);
            AddCategoryBtn.TabIndex = 21;
            AddCategoryBtn.Text = "Add Category";
            AddCategoryBtn.UseVisualStyleBackColor = true;
            AddCategoryBtn.Click += AddCategoryBtn_Click;
            // 
            // AddEmployeeBtn
            // 
            AddEmployeeBtn.FlatStyle = FlatStyle.Popup;
            AddEmployeeBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold);
            AddEmployeeBtn.Location = new Point(632, 200);
            AddEmployeeBtn.Margin = new Padding(4, 3, 4, 3);
            AddEmployeeBtn.Name = "AddEmployeeBtn";
            AddEmployeeBtn.Size = new Size(257, 51);
            AddEmployeeBtn.TabIndex = 22;
            AddEmployeeBtn.Text = "Add Employee";
            AddEmployeeBtn.UseVisualStyleBackColor = true;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.FlatStyle = FlatStyle.Popup;
            ExitBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold);
            ExitBtn.ForeColor = Color.IndianRed;
            ExitBtn.Location = new Point(337, 303);
            ExitBtn.Margin = new Padding(4, 3, 4, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(257, 51);
            ExitBtn.TabIndex = 23;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // AddClientBtn
            // 
            AddClientBtn.FlatStyle = FlatStyle.Popup;
            AddClientBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold);
            AddClientBtn.Location = new Point(337, 99);
            AddClientBtn.Margin = new Padding(4, 3, 4, 3);
            AddClientBtn.Name = "AddClientBtn";
            AddClientBtn.Size = new Size(257, 51);
            AddClientBtn.TabIndex = 24;
            AddClientBtn.Text = "Add Client";
            AddClientBtn.UseVisualStyleBackColor = true;
            AddClientBtn.Click += AddClientBtn_Click;
            // 
            // SalesBtn
            // 
            SalesBtn.FlatStyle = FlatStyle.Popup;
            SalesBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold);
            SalesBtn.Location = new Point(337, 200);
            SalesBtn.Margin = new Padding(4, 3, 4, 3);
            SalesBtn.Name = "SalesBtn";
            SalesBtn.Size = new Size(257, 51);
            SalesBtn.TabIndex = 25;
            SalesBtn.Text = "Sales";
            SalesBtn.UseVisualStyleBackColor = true;
            SalesBtn.Click += SalesBtn_Click;
            // 
            // SeeClientsBtn
            // 
            SeeClientsBtn.FlatStyle = FlatStyle.Popup;
            SeeClientsBtn.Font = new Font("Antipasto Pro DemiBold", 14.2499981F, FontStyle.Bold);
            SeeClientsBtn.Location = new Point(632, 99);
            SeeClientsBtn.Margin = new Padding(4, 3, 4, 3);
            SeeClientsBtn.Name = "SeeClientsBtn";
            SeeClientsBtn.Size = new Size(257, 51);
            SeeClientsBtn.TabIndex = 26;
            SeeClientsBtn.Text = "See Clients";
            SeeClientsBtn.UseVisualStyleBackColor = true;
            SeeClientsBtn.Click += SeeClientsBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(355, 17);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(211, 45);
            label3.TabIndex = 27;
            label3.Text = "Dash Board";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 410);
            Controls.Add(label3);
            Controls.Add(SeeClientsBtn);
            Controls.Add(SalesBtn);
            Controls.Add(AddClientBtn);
            Controls.Add(ExitBtn);
            Controls.Add(AddEmployeeBtn);
            Controls.Add(AddCategoryBtn);
            Controls.Add(AddProductBtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            FormClosed += DashBoard_FormClosed;
            Load += DashBoard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddProductBtn;
        private Button AddCategoryBtn;
        private Button AddEmployeeBtn;
        private Button ExitBtn;
        private Button AddClientBtn;
        private Button SalesBtn;
        private Button SeeClientsBtn;
        private Label label3;
    }
}