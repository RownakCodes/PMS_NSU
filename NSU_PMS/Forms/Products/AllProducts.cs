using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSU_PMS.Forms.Products
{
    public partial class AllProducts : Form
    {
        public AllProducts()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        WinformDbContext _windb = new WinformDbContext();
        private async void AllProducts_Load(object sender, EventArgs e)
        {
            var prods = await (
                        from p in _windb.Products
                        join c in _windb.Categories on p.Category equals c.ID
                        select new
                        {
                            Product = p,
                            CategoryName = c.Name
                        }
                    ).ToListAsync();
            int quantity = 0; double price = 0;

            foreach (var prod in prods)
            {

                ListViewItem newItem = new ListViewItem(new[]
                {
                        prod.Product.ID, prod.Product.Name, prod.Product.Description, prod.CategoryName,
                        prod.Product.BoxContent.ToString(), prod.Product.StripSize.ToString(), prod.Product.Discount.ToString("F2"),
                        prod.Product.Quantity.ToString(), prod.Product.Price.ToString("F2"), prod.Product.Status
                });

                DetailsListView.Items.Add(newItem);

                quantity += prod.Product.Quantity;
                price += prod.Product.Price* prod.Product.Quantity;


            }

            TotalQuantityTxtBox.Text = quantity.ToString("F2");
            TotalPriceTxtBox.Text = price.ToString("F2");
        }

        private void AllProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.dashboard.Show();
        }

    }
}
