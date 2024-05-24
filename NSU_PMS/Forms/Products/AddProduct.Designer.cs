namespace NSU_PMS.Forms.Products
{
    partial class AddProduct
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
            SaveBtn = new Button();
            ProductNameTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BoxContentTxtBox = new TextBox();
            label3 = new Label();
            StripSizeTxtBox = new TextBox();
            label4 = new Label();
            QuantityTxtBox = new TextBox();
            label5 = new Label();
            DiscountTxtBox = new TextBox();
            label6 = new Label();
            PriceTxtBox = new TextBox();
            label7 = new Label();
            DescriptionTxtBox = new TextBox();
            CategoryComboBox = new ComboBox();
            label9 = new Label();
            button1 = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            DetailsListView = new ListView();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Lato", 14F);
            SaveBtn.Location = new Point(963, 505);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(129, 57);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ProductNameTxtBox
            // 
            ProductNameTxtBox.Font = new Font("Lato", 12F);
            ProductNameTxtBox.Location = new Point(30, 62);
            ProductNameTxtBox.Name = "ProductNameTxtBox";
            ProductNameTxtBox.Size = new Size(331, 27);
            ProductNameTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 12F);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 12F);
            label2.Location = new Point(381, 40);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 4;
            label2.Text = "Box Content";
            // 
            // BoxContentTxtBox
            // 
            BoxContentTxtBox.Font = new Font("Lato", 12F);
            BoxContentTxtBox.Location = new Point(381, 62);
            BoxContentTxtBox.Name = "BoxContentTxtBox";
            BoxContentTxtBox.Size = new Size(331, 27);
            BoxContentTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 12F);
            label3.Location = new Point(732, 40);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 6;
            label3.Text = "Strip Size";
            // 
            // StripSizeTxtBox
            // 
            StripSizeTxtBox.Font = new Font("Lato", 12F);
            StripSizeTxtBox.Location = new Point(732, 62);
            StripSizeTxtBox.Name = "StripSizeTxtBox";
            StripSizeTxtBox.Size = new Size(331, 27);
            StripSizeTxtBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 12F);
            label4.Location = new Point(30, 260);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // QuantityTxtBox
            // 
            QuantityTxtBox.Font = new Font("Lato", 12F);
            QuantityTxtBox.Location = new Point(30, 282);
            QuantityTxtBox.Name = "QuantityTxtBox";
            QuantityTxtBox.Size = new Size(331, 27);
            QuantityTxtBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 12F);
            label5.Location = new Point(30, 119);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 10;
            label5.Text = "Discount";
            // 
            // DiscountTxtBox
            // 
            DiscountTxtBox.Font = new Font("Lato", 12F);
            DiscountTxtBox.Location = new Point(30, 141);
            DiscountTxtBox.Name = "DiscountTxtBox";
            DiscountTxtBox.Size = new Size(331, 27);
            DiscountTxtBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 12F);
            label6.Location = new Point(30, 190);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.Font = new Font("Lato", 12F);
            PriceTxtBox.Location = new Point(30, 212);
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.Size = new Size(331, 27);
            PriceTxtBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 12F);
            label7.Location = new Point(381, 119);
            label7.Name = "label7";
            label7.Size = new Size(90, 19);
            label7.TabIndex = 13;
            label7.Text = "Description";
            // 
            // DescriptionTxtBox
            // 
            DescriptionTxtBox.Font = new Font("Lato", 12F);
            DescriptionTxtBox.Location = new Point(381, 141);
            DescriptionTxtBox.Multiline = true;
            DescriptionTxtBox.Name = "DescriptionTxtBox";
            DescriptionTxtBox.Size = new Size(682, 168);
            DescriptionTxtBox.TabIndex = 14;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(840, 377);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(253, 23);
            CategoryComboBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lato", 12F, FontStyle.Bold);
            label9.Location = new Point(838, 355);
            label9.Name = "label9";
            label9.Size = new Size(76, 19);
            label9.TabIndex = 18;
            label9.Text = "Category";
            // 
            // button1
            // 
            button1.Font = new Font("Lato", 14F);
            button1.Location = new Point(18, 344);
            button1.Name = "button1";
            button1.Size = new Size(248, 30);
            button1.TabIndex = 20;
            button1.Text = "Add Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Strip size";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Medicine Left";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Expiry Date";
            columnHeader3.Width = 220;
            // 
            // DetailsListView
            // 
            DetailsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            DetailsListView.FullRowSelect = true;
            DetailsListView.GridLines = true;
            DetailsListView.Location = new Point(18, 380);
            DetailsListView.MultiSelect = false;
            DetailsListView.Name = "DetailsListView";
            DetailsListView.Size = new Size(671, 187);
            DetailsListView.TabIndex = 21;
            DetailsListView.UseCompatibleStateImageBehavior = false;
            DetailsListView.View = View.Details;
            DetailsListView.KeyDown += DetailsListView_KeyDown;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 666);
            Controls.Add(DetailsListView);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(CategoryComboBox);
            Controls.Add(DescriptionTxtBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PriceTxtBox);
            Controls.Add(label5);
            Controls.Add(DiscountTxtBox);
            Controls.Add(label4);
            Controls.Add(QuantityTxtBox);
            Controls.Add(label3);
            Controls.Add(StripSizeTxtBox);
            Controls.Add(label2);
            Controls.Add(BoxContentTxtBox);
            Controls.Add(label1);
            Controls.Add(ProductNameTxtBox);
            Controls.Add(SaveBtn);
            Name = "AddProduct";
            Text = "AddProduct";
            FormClosed += AddProduct_FormClosed;
            Load += AddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBtn;
        private TextBox ProductNameTxtBox;
        private Label label1;
        private Label label2;
        private TextBox BoxContentTxtBox;
        private Label label3;
        private TextBox StripSizeTxtBox;
        private Label label4;
        private TextBox QuantityTxtBox;
        private Label label5;
        private TextBox DiscountTxtBox;
        private Label label6;
        private TextBox PriceTxtBox;
        private Label label7;
        private TextBox DescriptionTxtBox;
        private ComboBox CategoryComboBox;
        private Label label9;
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView DetailsListView;
    }
}