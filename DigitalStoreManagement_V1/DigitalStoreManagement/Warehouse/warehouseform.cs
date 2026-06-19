using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalStoreWarehouse.Forms
{
    public partial class WarehouseForm : Form
    {
        // UI controls
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button btnShow;
        private ListBox lstInfo;
        private CheckBox chkLowStock;
        private ComboBox cmbCategory;
        private RadioButton rbNew;
        private RadioButton rbUsed;
        private Label lblName;
        private Label lblPrice;
        private Label lblStock;
        private Label label1;
        private Label lblCategory;

        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.chkLowStock = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbUsed = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(547, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(547, 209);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(547, 131);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(200, 22);
            this.txtStock.TabIndex = 5;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Navy;
            this.btnShow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(567, 419);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(180, 41);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "نمایش اطلاعات";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // lstInfo
            // 
            this.lstInfo.BackColor = System.Drawing.Color.White;
            this.lstInfo.ItemHeight = 16;
            this.lstInfo.Location = new System.Drawing.Point(375, 476);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstInfo.Size = new System.Drawing.Size(372, 100);
            this.lstInfo.TabIndex = 12;
            // 
            // chkLowStock
            // 
            this.chkLowStock.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkLowStock.Location = new System.Drawing.Point(547, 367);
            this.chkLowStock.Name = "chkLowStock";
            this.chkLowStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLowStock.Size = new System.Drawing.Size(200, 46);
            this.chkLowStock.TabIndex = 11;
            this.chkLowStock.Text = "فقط موجودی کم";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] {
            "لپ‌تاپ",
            "تبلت",
            "گوشی موبایل",
            "هدفون",
            "ساعت هوشمند",
            "لوازم جانبی"});
            this.cmbCategory.Location = new System.Drawing.Point(544, 286);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbCategory.TabIndex = 8;
            // 
            // rbNew
            // 
            this.rbNew.Checked = true;
            this.rbNew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbNew.Location = new System.Drawing.Point(547, 325);
            this.rbNew.Name = "rbNew";
            this.rbNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbNew.Size = new System.Drawing.Size(67, 36);
            this.rbNew.TabIndex = 9;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "نو";
            // 
            // rbUsed
            // 
            this.rbUsed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbUsed.Location = new System.Drawing.Point(628, 325);
            this.rbUsed.Name = "rbUsed";
            this.rbUsed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbUsed.Size = new System.Drawing.Size(119, 36);
            this.rbUsed.TabIndex = 10;
            this.rbUsed.Text = "کارکرده";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Location = new System.Drawing.Point(567, 18);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(180, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام کالا :";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPrice.Location = new System.Drawing.Point(652, 173);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(95, 34);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "قیمت:";
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStock.Location = new System.Drawing.Point(619, 95);
            this.lblStock.Name = "lblStock";
            this.lblStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStock.Size = new System.Drawing.Size(128, 33);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "موجودی:";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCategory.Location = new System.Drawing.Point(655, 248);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCategory.Size = new System.Drawing.Size(95, 35);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "دسته:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "مدیریت انبار فروشگاه";
            // 
            // WarehouseForm
            // 
            this.ClientSize = new System.Drawing.Size(782, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.rbNew);
            this.Controls.Add(this.rbUsed);
            this.Controls.Add(this.chkLowStock);
            this.Controls.Add(this.lstInfo);
            this.Name = "WarehouseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انبار فروشگاه لوازم دیجیتال";
            this.Load += new System.EventHandler(this.WarehouseForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // button click event: read data from UI and add to listbox
        private void BtnShow_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string price = txtPrice.Text;
            string stock = txtStock.Text;
            string category = cmbCategory.SelectedItem?.ToString() ?? "";
            string type = rbNew.Checked ? "نو" : "کارکرده";

            string result = string.Format("نام: {0} | قیمت: {1} | موجودی: {2} | دسته: {3} | وضعیت: {4}",
                name, price, stock, category, type);

            lstInfo.Items.Add(result);
        }

        // remaining event handlers (empty, just for design)
        private void lblPrice_Click(object sender, EventArgs e) { }
        private void lblStock_Click(object sender, EventArgs e) { }
        private void txtStock_TextChanged(object sender, EventArgs e) { }
        private void WarehouseForm_Load(object sender, EventArgs e) { }
        private void rbUsed_CheckedChanged(object sender, EventArgs e) { }
        private void rbNew_CheckedChanged(object sender, EventArgs e) { }
        private void chkLowStock_CheckedChanged(object sender, EventArgs e) { }
        private void lstInfo_SelectedIndexChanged(object sender, EventArgs e) { }

        private void WarehouseForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}