using NSU_PMS.Forms.Client;
using NSU_PMS.Forms.Employee;
using NSU_PMS.Forms.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSU_PMS.Forms.General
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            this.Hide();
            addProduct.Show();

        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            this.Hide();
            addCategory.Show();
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            this.Hide();
            addEmployee.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Global.signin.Close();
            this.Close();
        }

        public void dosth()
        {

        }


        private void DashBoard_Load(object sender, EventArgs e)
        {
            dosth();
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            AddClient cl = new AddClient();
            cl.Show();
            this.Hide();
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            s.Show();
            this.Hide();
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            Global.signin.Close();

        }

        private void SeeClientsBtn_Click(object sender, EventArgs e)
        {
            AllClients allClients = new AllClients();
            allClients.Show();
            this.Hide();
        }
    }
}
