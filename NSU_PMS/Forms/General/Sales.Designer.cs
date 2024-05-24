namespace NSU_PMS.Forms.General
{
    partial class Sales
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
            label9 = new Label();
            CategoryComboBox = new ComboBox();
            DetailsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            Client = new Label();
            ClientComboBox = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            QuantityTxtBox = new TextBox();
            label2 = new Label();
            ProductNameComboBox = new ComboBox();
            label3 = new Label();
            TotalTxtBox = new TextBox();
            label5 = new Label();
            DiscountTxtBox = new TextBox();
            label6 = new Label();
            GrandTotalTxtBox = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ComentTxtBox = new Label();
            ClientInfoTxtBox = new TextBox();
            SalesBtn = new Button();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lato", 12F);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(73, 19);
            label9.TabIndex = 20;
            label9.Text = "Category";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(14, 31);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(253, 23);
            CategoryComboBox.TabIndex = 19;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // DetailsListView
            // 
            DetailsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader4 });
            DetailsListView.FullRowSelect = true;
            DetailsListView.GridLines = true;
            DetailsListView.Location = new Point(12, 280);
            DetailsListView.MultiSelect = false;
            DetailsListView.Name = "DetailsListView";
            DetailsListView.Size = new Size(781, 187);
            DetailsListView.TabIndex = 22;
            DetailsListView.UseCompatibleStateImageBehavior = false;
            DetailsListView.View = View.Details;
            DetailsListView.KeyDown += DetailsListView_KeyDown;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantity";
            columnHeader3.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Discount";
            columnHeader5.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            columnHeader4.Width = 110;
            // 
            // Client
            // 
            Client.AutoSize = true;
            Client.Font = new Font("Lato", 12F, FontStyle.Bold);
            Client.Location = new Point(350, 9);
            Client.Name = "Client";
            Client.Size = new Size(52, 19);
            Client.TabIndex = 24;
            Client.Text = "Client";
            // 
            // ClientComboBox
            // 
            ClientComboBox.FormattingEnabled = true;
            ClientComboBox.Location = new Point(352, 31);
            ClientComboBox.Name = "ClientComboBox";
            ClientComboBox.Size = new Size(253, 23);
            ClientComboBox.TabIndex = 23;
            ClientComboBox.SelectedIndexChanged += ClientComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Lato", 14F);
            button1.Location = new Point(16, 209);
            button1.Name = "button1";
            button1.Size = new Size(198, 30);
            button1.TabIndex = 25;
            button1.Text = "Add Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 12F);
            label4.Location = new Point(16, 134);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 27;
            label4.Text = "Quantity";
            // 
            // QuantityTxtBox
            // 
            QuantityTxtBox.Font = new Font("Lato", 12F);
            QuantityTxtBox.Location = new Point(16, 156);
            QuantityTxtBox.Name = "QuantityTxtBox";
            QuantityTxtBox.Size = new Size(253, 27);
            QuantityTxtBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 12F);
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 29;
            label2.Text = "Product Name";
            // 
            // ProductNameComboBox
            // 
            ProductNameComboBox.FormattingEnabled = true;
            ProductNameComboBox.Location = new Point(16, 98);
            ProductNameComboBox.Name = "ProductNameComboBox";
            ProductNameComboBox.Size = new Size(253, 23);
            ProductNameComboBox.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 12F);
            label3.Location = new Point(491, 497);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 32;
            label3.Text = "Total";
            // 
            // TotalTxtBox
            // 
            TotalTxtBox.Font = new Font("Lato", 12F);
            TotalTxtBox.Location = new Point(540, 489);
            TotalTxtBox.Name = "TotalTxtBox";
            TotalTxtBox.ReadOnly = true;
            TotalTxtBox.Size = new Size(253, 27);
            TotalTxtBox.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 12F);
            label5.Location = new Point(462, 530);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 34;
            label5.Text = "Discount";
            // 
            // DiscountTxtBox
            // 
            DiscountTxtBox.Font = new Font("Lato", 12F);
            DiscountTxtBox.Location = new Point(540, 522);
            DiscountTxtBox.Name = "DiscountTxtBox";
            DiscountTxtBox.ReadOnly = true;
            DiscountTxtBox.Size = new Size(253, 27);
            DiscountTxtBox.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 16F, FontStyle.Bold);
            label6.Location = new Point(404, 585);
            label6.Name = "label6";
            label6.Size = new Size(130, 27);
            label6.TabIndex = 36;
            label6.Text = "Grand Total";
            // 
            // GrandTotalTxtBox
            // 
            GrandTotalTxtBox.Font = new Font("Lato", 16F, FontStyle.Bold);
            GrandTotalTxtBox.Location = new Point(540, 579);
            GrandTotalTxtBox.Name = "GrandTotalTxtBox";
            GrandTotalTxtBox.ReadOnly = true;
            GrandTotalTxtBox.Size = new Size(253, 33);
            GrandTotalTxtBox.TabIndex = 35;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ComentTxtBox
            // 
            ComentTxtBox.AutoSize = true;
            ComentTxtBox.Font = new Font("Lato", 12F);
            ComentTxtBox.Location = new Point(350, 76);
            ComentTxtBox.Name = "ComentTxtBox";
            ComentTxtBox.Size = new Size(82, 19);
            ComentTxtBox.TabIndex = 38;
            ComentTxtBox.Text = "Client Info";
            // 
            // ClientInfoTxtBox
            // 
            ClientInfoTxtBox.Font = new Font("Lato", 12F);
            ClientInfoTxtBox.Location = new Point(350, 98);
            ClientInfoTxtBox.Multiline = true;
            ClientInfoTxtBox.Name = "ClientInfoTxtBox";
            ClientInfoTxtBox.ReadOnly = true;
            ClientInfoTxtBox.Size = new Size(331, 93);
            ClientInfoTxtBox.TabIndex = 37;
            // 
            // SalesBtn
            // 
            SalesBtn.Font = new Font("Lato", 14F);
            SalesBtn.Location = new Point(640, 641);
            SalesBtn.Name = "SalesBtn";
            SalesBtn.Size = new Size(153, 49);
            SalesBtn.TabIndex = 39;
            SalesBtn.Text = "Confirm";
            SalesBtn.UseVisualStyleBackColor = true;
            SalesBtn.Click += SalesBtn_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 702);
            Controls.Add(SalesBtn);
            Controls.Add(ComentTxtBox);
            Controls.Add(ClientInfoTxtBox);
            Controls.Add(label6);
            Controls.Add(GrandTotalTxtBox);
            Controls.Add(label5);
            Controls.Add(DiscountTxtBox);
            Controls.Add(label3);
            Controls.Add(TotalTxtBox);
            Controls.Add(ProductNameComboBox);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(QuantityTxtBox);
            Controls.Add(button1);
            Controls.Add(Client);
            Controls.Add(ClientComboBox);
            Controls.Add(DetailsListView);
            Controls.Add(label9);
            Controls.Add(CategoryComboBox);
            Name = "Sales";
            Text = "Sales";
            FormClosed += Sales_FormClosed;
            Load += Sales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private ComboBox CategoryComboBox;
        private ListView DetailsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label Client;
        private ComboBox ClientComboBox;
        private Button button1;
        private Label label4;
        private TextBox QuantityTxtBox;
        private Label label2;
        private ComboBox ProductNameComboBox;
        private Label label3;
        private TextBox TotalTxtBox;
        private Label label5;
        private TextBox DiscountTxtBox;
        private Label label6;
        private TextBox GrandTotalTxtBox;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label ComentTxtBox;
        private TextBox ClientInfoTxtBox;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button SalesBtn;
    }
}