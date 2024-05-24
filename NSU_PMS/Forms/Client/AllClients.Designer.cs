namespace NSU_PMS.Forms.Client
{
    partial class AllClients
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
            DetailsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label9 = new Label();
            SuspendLayout();
            // 
            // DetailsListView
            // 
            DetailsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader4, columnHeader6 });
            DetailsListView.FullRowSelect = true;
            DetailsListView.GridLines = true;
            DetailsListView.Location = new Point(12, 92);
            DetailsListView.MultiSelect = false;
            DetailsListView.Name = "DetailsListView";
            DetailsListView.Size = new Size(1441, 346);
            DetailsListView.TabIndex = 23;
            DetailsListView.UseCompatibleStateImageBehavior = false;
            DetailsListView.View = View.Details;
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
            columnHeader3.Text = "Address";
            columnHeader3.Width = 330;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone";
            columnHeader5.Width = 220;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 220;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Comments";
            columnHeader6.Width = 220;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lato", 22F);
            label9.Location = new Point(12, 31);
            label9.Name = "label9";
            label9.Size = new Size(151, 36);
            label9.TabIndex = 24;
            label9.Text = "All Cleints";
            // 
            // AllClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 450);
            Controls.Add(label9);
            Controls.Add(DetailsListView);
            Name = "AllClients";
            Text = "AllClients";
            FormClosed += AllClients_FormClosed;
            Load += AllClients_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView DetailsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private Label label9;
    }
}