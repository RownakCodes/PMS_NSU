using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        WinformDbContext _winDB = new WinformDbContext();
        public AddProduct()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private async void AddProduct_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = await _winDB.Categories.ToListAsync();
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "ID";
            CategoryComboBox.SelectedIndex = -1;
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

                if (ListViewFunctions.CalculateColumnSum(DetailsListView, 1) != double.Parse(quantity))
                {
                    MessageBox.Show("Quantity doesn't match the details");
                    return;
                }




                string mid = "Prod-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999);
                await _winDB.Products.AddAsync(new Models.Product
                {
                    ID = mid,
                    Name = ProductNameTxtBox.Text,
                    Description = DescriptionTxtBox.Text,
                    Category = CategoryComboBox.SelectedValue.ToString(),
                    BoxContent = int.Parse(boxContent),
                    StripSize = int.Parse(stripSize),
                    Discount = double.Parse(discount),
                    Quantity = int.Parse(quantity),
                    Price = double.Parse(price),
                    TotalValuation = double.Parse(price) * int.Parse(quantity),
                    Status = "Active",
                    DateTime = DateTime.Now,
                });

                foreach (ListViewItem lv in DetailsListView.Items)
                {
                    await _winDB.ProductDetails.AddAsync(new Models.ProductDetail
                    {
                        ID = "ProdDetails-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999) + "-" + random.Next(10000, 99999),
                        ProductID = mid,
                        StripsLeft = int.Parse(lv.SubItems[0].Text),
                        MedicineLeft = int.Parse(lv.SubItems[1].Text),
                        ExpiryDate = DateTime.Parse(lv.SubItems[2].Text),
                        DateTime = DateTime.Now,
                        Status = "Active",
                    });
                }


                await _winDB.SaveChangesAsync();

                FormFunctions.ClearForm(this.Controls);
                MessageBox.Show("Product Added");
                DetailsListView.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
            finally
            {
                this.Enabled = true;
            }
        }
        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                string StripsLeft = Microsoft.VisualBasic.Interaction.InputBox("Enter Strips Left:", "Product Details", "");
                string MedicineLeft = Microsoft.VisualBasic.Interaction.InputBox("Enter Medicine Left:", "Product Details", "");
                string ExpiryDate = Microsoft.VisualBasic.Interaction.InputBox("Enter ExpireDate (dd/mm/yyyy):", "Product Details", "");
                DateTime date; double strips, meds;
                if (string.IsNullOrEmpty(StripsLeft) ||
                    string.IsNullOrEmpty(MedicineLeft) ||
                    string.IsNullOrEmpty(ExpiryDate) ||
                    DateTime.TryParse(ExpiryDate, out date) ||
                    double.TryParse(StripsLeft, out strips) ||
                    double.TryParse(MedicineLeft, out meds)
                    )
                {
                    ListViewItem newItem = new ListViewItem(new[]
                    {
                        StripsLeft, MedicineLeft, ExpiryDate
                    });

                    DetailsListView.Items.Add(newItem);
                }
                else
                {
                    MessageBox.Show("Enter all entries appropriately.");
                    this.Enabled = true;
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
            finally
            {
                this.Enabled = true;
                MessageBox.Show("Details Entered");
            }
        }

        private void DetailsListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem List in DetailsListView.SelectedItems)
                {
                    List.Remove();
                }
            }
        }

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.dashboard.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
