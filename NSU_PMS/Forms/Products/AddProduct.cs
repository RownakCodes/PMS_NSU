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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            ProductNameTxtBox.Text = "Hello World!";
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            double result;
            try
            {
                string boxContent = BoxContentTxtBox.Text;
                if (!double.TryParse(boxContent, out result))
                {
                    MessageBox.Show("Enter decimal value in Box Content");
                    return;
                }
                string stripSize = StripSizeTxtBox.Text;
                if (!double.TryParse(stripSize, out result))
                {
                    MessageBox.Show("Enter decimal value in Strip Size");
                    return;
                }
                string discount = DiscountTxtBox.Text;
                if (!double.TryParse(discount, out result))
                {
                    MessageBox.Show("Enter decimal value in Discount");
                    return;
                }
                string price = PriceTxtBox.Text;
                if (!double.TryParse(price, out result))
                {
                    MessageBox.Show("Enter decimal value in Price");
                    return;
                }
                string quantity = QuantityTxtBox.Text;
                if (!double.TryParse(quantity, out result))
                {
                    MessageBox.Show("Enter decimal value in Quantity");
                    return;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error", ex.Message);
            }
            finally { 
                this.Enabled = true; 
            }
        }
    }
}
