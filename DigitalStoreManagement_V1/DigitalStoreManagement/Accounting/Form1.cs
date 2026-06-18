using System;
using System.Drawing;
using System.Windows.Forms;
using DigitalStoreWarehouse.Entities;
using DigitalStoreManagement.Accounting;

namespace AccountingProject
{
    public partial class Form1 : Form
    {
        // سبد خرید
        private ShoppingCart myCart = new ShoppingCart();

        // کنترل‌ها
        private ComboBox cmbProducts;
        private ListBox listBox1;
        private Button btnStore;
        private Button btnInvoice;
        private Button btnRemove;
        private Button btnShowInvoice;
        private TextBox txtDiscount;
        private Label lblDiscount;
        private Label lblTitle;

        public Form1()
        {
            InitializeMyControls();
            LoadProducts();
        }

        private void InitializeMyControls()
        {
            // عنوان
            lblTitle = new Label();
            lblTitle.Text = "مدیریت فروشگاه دیجیتال";
            lblTitle.Location = new Point(200, 20);
            lblTitle.Size = new Size(300, 30);
            lblTitle.Font = new Font("Tahoma", 16, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // کامبوباکس محصولات
            cmbProducts = new ComboBox();
            cmbProducts.Location = new Point(50, 80);
            cmbProducts.Size = new Size(200, 28);
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;

            // دکمه افزودن به سبد
            btnStore = new Button();
            btnStore.Text = "افزودن به سبد";
            btnStore.Location = new Point(50, 120);
            btnStore.Size = new Size(200, 35);
            btnStore.BackColor = Color.LightGreen;
            btnStore.Click += BtnStore_Click;

            // لیست سبد خرید
            listBox1 = new ListBox();
            listBox1.Location = new Point(50, 170);
            listBox1.Size = new Size(300, 250);
            listBox1.Font = new Font("Tahoma", 10);

            // دکمه حذف از سبد
            btnRemove = new Button();
            btnRemove.Text = "حذف از سبد";
            btnRemove.Location = new Point(50, 430);
            btnRemove.Size = new Size(140, 35);
            btnRemove.BackColor = Color.LightCoral;
            btnRemove.Click += BtnRemove_Click;

            // دکمه نمایش فاکتور معمولی
            btnShowInvoice = new Button();
            btnShowInvoice.Text = "نمایش فاکتور";
            btnShowInvoice.Location = new Point(200, 430);
            btnShowInvoice.Size = new Size(150, 35);
            btnShowInvoice.BackColor = Color.LightBlue;
            btnShowInvoice.Click += BtnShowInvoice_Click;

            // برچسب تخفیف
            lblDiscount = new Label();
            lblDiscount.Text = "درصد تخفیف:";
            lblDiscount.Location = new Point(400, 80);
            lblDiscount.Size = new Size(80, 25);

            // تکست باکس تخفیف
            txtDiscount = new TextBox();
            txtDiscount.Text = "0";
            txtDiscount.Location = new Point(490, 80);
            txtDiscount.Size = new Size(100, 25);

            // دکمه فاکتور با تخفیف
            btnInvoice = new Button();
            btnInvoice.Text = "فاکتور با تخفیف";
            btnInvoice.Location = new Point(400, 120);
            btnInvoice.Size = new Size(190, 35);
            btnInvoice.BackColor = Color.LightYellow;
            btnInvoice.Click += BtnInvoice_Click;

            // اضافه کردن کنترل‌ها به فرم
            this.Controls.Add(lblTitle);
            this.Controls.Add(cmbProducts);
            this.Controls.Add(btnStore);
            this.Controls.Add(listBox1);
            this.Controls.Add(btnRemove);
            this.Controls.Add(btnShowInvoice);
            this.Controls.Add(lblDiscount);
            this.Controls.Add(txtDiscount);
            this.Controls.Add(btnInvoice);

            // تنظیمات فرم
            this.Text = "سیستم مدیریت فروشگاه دیجیتال";
            this.Size = new Size(650, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadProducts()
        {
            cmbProducts.Items.Clear();
            cmbProducts.Items.Add(new Product { Name = "لپ تاپ", Price = 35000000m });
            cmbProducts.Items.Add(new Product { Name = "موس", Price = 750000m });
            cmbProducts.Items.Add(new Product { Name = "کیبورد", Price = 1500000m });
            cmbProducts.Items.Add(new Product { Name = "مانیتور", Price = 12000000m });
            cmbProducts.Items.Add(new Product { Name = "هدفون", Price = 800000m });
            cmbProducts.Items.Add(new Product { Name = "اسپیکر", Price = 2500000m });

            cmbProducts.DisplayMember = "Name";
            if (cmbProducts.Items.Count > 0)
                cmbProducts.SelectedIndex = 0;
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem == null)
            {
                MessageBox.Show("لطفاً یک محصول را انتخاب کنید.", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product selectedProduct = cmbProducts.SelectedItem as Product;

            if (selectedProduct != null)
            {
                myCart.AddToCart(selectedProduct);
                listBox1.Items.Add($"{selectedProduct.Name} - {selectedProduct.Price:N0} تومان");
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("لطفاً یک کالا را از لیست انتخاب کنید.", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = listBox1.SelectedIndex;
            myCart.Items.RemoveAt(index);
            listBox1.Items.RemoveAt(index);
        }

        private void BtnShowInvoice_Click(object sender, EventArgs e)
        {
            if (myCart.Items.Count == 0)
            {
                MessageBox.Show("سبد خرید خالی است.", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = 0;
            foreach (var item in myCart.Items)
            {
                total += item.Price;
            }

            string invoiceText = "=== فاکتور خرید ===\r\n\r\n";
            foreach (var item in myCart.Items)
            {
                invoiceText += $"{item.Name}: {item.Price:N0} تومان\r\n";
            }
            invoiceText += $"\r\nجمع کل: {total:N0} تومان";

            MessageBox.Show(invoiceText, "فاکتور خرید",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            if (myCart.Items.Count == 0)
            {
                MessageBox.Show("سبد خرید خالی است.", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDiscount.Text, out decimal discountPercent))
            {
                MessageBox.Show("لطفاً یک عدد معتبر وارد کنید.", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (discountPercent < 0 || discountPercent > 100)
            {
                MessageBox.Show("تخفیف باید بین 0 تا 100 باشد.", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = 0;
            foreach (var item in myCart.Items)
            {
                total += item.Price;
            }

            decimal discountAmount = total * discountPercent / 100;
            decimal finalTotal = total - discountAmount;

            string invoiceText = "=== فاکتور با تخفیف ===\r\n\r\n";
            foreach (var item in myCart.Items)
            {
                invoiceText += $"{item.Name}: {item.Price:N0} تومان\r\n";
            }
            invoiceText += $"\r\nجمع کل: {total:N0} تومان";
            invoiceText += $"\r\nتخفیف ({discountPercent}%): {discountAmount:N0} تومان";
            invoiceText += $"\r\nمبلغ قابل پرداخت: {finalTotal:N0} تومان";

            MessageBox.Show(invoiceText, "فاکتور با تخفیف",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(946, 624);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}