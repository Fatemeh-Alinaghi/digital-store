using DigitalStoreManagement.Enums;
using DigitalStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using DigitalStoreWarehouse.Forms;
using DigitalStoreManagement.Accounting;
using AccountingProject;





namespace DigitalStoreManagement
{

    public partial class MainForm : Form

    {
        private List<DigitalProduct> products = new List<DigitalProduct>();

        public MainForm()
        {
            InitializeComponent();




            
            cmbCategory.Items.Add("موبایل");
            cmbCategory.Items.Add("لپ تاپ");
            cmbCategory.Items.Add("تبلت");
            cmbCategory.Items.Add("هدفون");
            cmbCategory.Items.Add("لوازم جانبی");

            LoadProducts();

        }
       
        private void LoadProducts()
        {
            if (!File.Exists("products.txt"))
                return;

            StreamReader reader = new StreamReader("products.txt");

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string[] data = line.Split(',');

                DigitalProduct product = new DigitalProduct();

                product.Id = Convert.ToInt32(data[0]);
                product.Name = data[1];
                product.Price = Convert.ToDecimal(data[2]);

                products.Add(product);

                lstProducts.Items.Add(product.GetInfo());
            }

            reader.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(txtProductName.Text == "")
            {
                MessageBox.Show("نام کالا را وارد کنید");
                return;
            }


            if (txtPrice.Text == "")
            {
                MessageBox.Show("قیمت کالا را وارد کنید");
                return;
            }


            if(cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("دسته بندی را وارد کنید");
                return;
            }


            DigitalProduct product = new DigitalProduct();

            product.Id = lstProducts.Items.Count + 1;
            product.Name = txtProductName.Text;

            try
            {
                product.Price = Convert.ToDecimal(txtPrice.Text);
            }
            catch
            {
                MessageBox.Show("قیمت باید عدد باشد");

                return;
            }

            product.StorageType = (CategoryType)cmbCategory.SelectedIndex;

            products.Add(product);
            lstProducts.Items.Add(product.GetInfo());

           

            txtProductName.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1;

            txtProductName.Focus();
            
        }


        private void btnCountProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show( $"تعداد کالاها: {products.Count}");
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;

            foreach (DigitalProduct product in products)
            {
                if (product.Name.ToLower().Contains(searchName.ToLower()))
                {
                    MessageBox.Show(
                        $"کالا پیدا شد\nنام: {product.Name}\nقیمت: {product.Price}"
                    );

                    return;
                }
            }

            MessageBox.Show("کالا پیدا نشد");
        }

        

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex == -1)
            {
                MessageBox.Show("ابتدا یک کالا را انتخاب کنید");
                return;
            }

            int index = lstProducts.SelectedIndex;

            products.RemoveAt(index);
            lstProducts.Items.RemoveAt(index);

            MessageBox.Show("کالا حذف شد");
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex == -1)
            {
                MessageBox.Show("ابتدا یک کالا را انتخاب کنید");
                return;
            }

            int index = lstProducts.SelectedIndex;

            DigitalProduct product = products[index];

            product.Name = txtProductName.Text;

            try
            {
                product.Price = Convert.ToDecimal(txtPrice.Text);
            }
            catch
            {
                MessageBox.Show("قیمت باید عدد باشد");

                return;
            }


            lstProducts.Items[index] = product.GetInfo();

            MessageBox.Show("کالا ویرایش شد");
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex == -1)
                return;

            int index = lstProducts.SelectedIndex;

            txtProductName.Text = products[index].Name;
            txtPrice.Text = products[index].Price.ToString();
        }

        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("products.txt");

            foreach (DigitalProduct product in products)
            {
                writer.WriteLine(
                    $"{product.Id},{product.Name},{product.Price}"
                );
            }

            writer.Close();

            MessageBox.Show("اطلاعات ذخیره شد");
        }

        private void grpProductInfo_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void chkAutoSave_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseForm frm = new WarehouseForm();
            frm.ShowDialog();
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {

            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void grpModules_Enter(object sender, EventArgs e)
        {

        }

        private void rdoNew_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
