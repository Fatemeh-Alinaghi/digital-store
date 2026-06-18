namespace DigitalStoreManagement
{
    partial class MainForm
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.chkAutoSave = new System.Windows.Forms.CheckBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnAccounting = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnCountProducts = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnSaveProducts = new System.Windows.Forms.Button();
            this.rdoNew = new System.Windows.Forms.RadioButton();
            this.rdoUsed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProductInfo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grpModules = new System.Windows.Forms.GroupBox();
            this.grpProductInfo.SuspendLayout();
            this.grpModules.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblProductName.Location = new System.Drawing.Point(402, 23);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductName.Size = new System.Drawing.Size(77, 21);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = ": نام کالا";
            this.lblProductName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtProductName.Location = new System.Drawing.Point(145, 20);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.MinimumSize = new System.Drawing.Size(202, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(202, 28);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPrice.Location = new System.Drawing.Point(413, 63);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(65, 21);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = ": قیمت";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrice.Location = new System.Drawing.Point(145, 56);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.MaximumSize = new System.Drawing.Size(202, 30);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(202, 28);
            this.txtPrice.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCategory.Location = new System.Drawing.Point(371, 100);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCategory.Size = new System.Drawing.Size(107, 21);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = ":دسته بندی";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(145, 92);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategory.MaximumSize = new System.Drawing.Size(202, 0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(202, 29);
            this.cmbCategory.TabIndex = 6;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkAutoSave.Location = new System.Drawing.Point(308, 223);
            this.chkAutoSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAutoSave.Size = new System.Drawing.Size(170, 22);
            this.chkAutoSave.TabIndex = 7;
            this.chkAutoSave.Text = "ذخیره خودکار اطلاعات ";
            this.chkAutoSave.UseVisualStyleBackColor = true;
            this.chkAutoSave.CheckedChanged += new System.EventHandler(this.chkAutoSave_CheckedChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(195, 382);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 45);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "ثبت کالا";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblProducts.ForeColor = System.Drawing.Color.Navy;
            this.lblProducts.Location = new System.Drawing.Point(195, 440);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProducts.Size = new System.Drawing.Size(196, 24);
            this.lblProducts.TabIndex = 9;
            this.lblProducts.Text = " : کالاهای ثبت شده";
            this.lblProducts.Click += new System.EventHandler(this.lblProducts_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.BackColor = System.Drawing.Color.White;
            this.lstProducts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 24;
            this.lstProducts.Location = new System.Drawing.Point(195, 468);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstProducts.Size = new System.Drawing.Size(600, 172);
            this.lstProducts.TabIndex = 10;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // btnAccounting
            // 
            this.btnAccounting.AutoSize = true;
            this.btnAccounting.BackColor = System.Drawing.Color.SlateGray;
            this.btnAccounting.FlatAppearance.BorderSize = 0;
            this.btnAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounting.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAccounting.ForeColor = System.Drawing.Color.White;
            this.btnAccounting.Location = new System.Drawing.Point(257, 28);
            this.btnAccounting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Size = new System.Drawing.Size(153, 55);
            this.btnAccounting.TabIndex = 11;
            this.btnAccounting.Text = "بخش حسابداری";
            this.btnAccounting.UseVisualStyleBackColor = false;
            this.btnAccounting.Click += new System.EventHandler(this.btnAccounting_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BackColor = System.Drawing.Color.SlateGray;
            this.btnWarehouse.FlatAppearance.BorderSize = 0;
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnWarehouse.ForeColor = System.Drawing.Color.White;
            this.btnWarehouse.Location = new System.Drawing.Point(81, 28);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(153, 55);
            this.btnWarehouse.TabIndex = 12;
            this.btnWarehouse.Text = "بخش انبارداری";
            this.btnWarehouse.UseVisualStyleBackColor = false;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnCountProducts
            // 
            this.btnCountProducts.BackColor = System.Drawing.Color.DarkGray;
            this.btnCountProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCountProducts.FlatAppearance.BorderSize = 0;
            this.btnCountProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountProducts.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCountProducts.ForeColor = System.Drawing.Color.White;
            this.btnCountProducts.Location = new System.Drawing.Point(585, 382);
            this.btnCountProducts.Name = "btnCountProducts";
            this.btnCountProducts.Size = new System.Drawing.Size(120, 45);
            this.btnCountProducts.TabIndex = 13;
            this.btnCountProducts.Text = "تعداد کالاها";
            this.btnCountProducts.UseVisualStyleBackColor = false;
            this.btnCountProducts.Click += new System.EventHandler(this.btnCountProducts_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = true;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(385, 333);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(248, 35);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSearch.Location = new System.Drawing.Point(252, 338);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSearch.Size = new System.Drawing.Size(127, 21);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = ":جستجوی کالا";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(654, 333);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(455, 382);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(120, 45);
            this.btnDeleteProduct.TabIndex = 17;
            this.btnDeleteProduct.Text = "حذف کالا";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(325, 382);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(120, 45);
            this.btnEditProduct.TabIndex = 18;
            this.btnEditProduct.Text = " ویرایش کالا";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.AutoSize = true;
            this.btnSaveProducts.BackColor = System.Drawing.Color.SlateGray;
            this.btnSaveProducts.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSaveProducts.FlatAppearance.BorderSize = 0;
            this.btnSaveProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProducts.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveProducts.ForeColor = System.Drawing.Color.White;
            this.btnSaveProducts.Location = new System.Drawing.Point(715, 382);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Size = new System.Drawing.Size(127, 45);
            this.btnSaveProducts.TabIndex = 19;
            this.btnSaveProducts.Text = "ذخیره اطلاعات";
            this.btnSaveProducts.UseVisualStyleBackColor = false;
            this.btnSaveProducts.Click += new System.EventHandler(this.btnSaveProducts_Click);
            // 
            // rdoNew
            // 
            this.rdoNew.AutoSize = true;
            this.rdoNew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoNew.Location = new System.Drawing.Point(400, 163);
            this.rdoNew.Name = "rdoNew";
            this.rdoNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoNew.Size = new System.Drawing.Size(78, 22);
            this.rdoNew.TabIndex = 20;
            this.rdoNew.TabStop = true;
            this.rdoNew.Text = "کالای نو";
            this.rdoNew.UseVisualStyleBackColor = true;
            this.rdoNew.CheckedChanged += new System.EventHandler(this.rdoNew_CheckedChanged);
            // 
            // rdoUsed
            // 
            this.rdoUsed.AutoSize = true;
            this.rdoUsed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoUsed.Location = new System.Drawing.Point(261, 163);
            this.rdoUsed.Name = "rdoUsed";
            this.rdoUsed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoUsed.Size = new System.Drawing.Size(110, 22);
            this.rdoUsed.TabIndex = 21;
            this.rdoUsed.TabStop = true;
            this.rdoUsed.Text = "کالای کارکرده";
            this.rdoUsed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(341, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 49);
            this.label1.TabIndex = 22;
            this.label1.Text = "سیستم مدیریت فروشگاه لوازم دیجیتال";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpProductInfo
            // 
            this.grpProductInfo.Controls.Add(this.panel1);
            this.grpProductInfo.Controls.Add(this.label2);
            this.grpProductInfo.Controls.Add(this.lblProductName);
            this.grpProductInfo.Controls.Add(this.lblPrice);
            this.grpProductInfo.Controls.Add(this.rdoUsed);
            this.grpProductInfo.Controls.Add(this.lblCategory);
            this.grpProductInfo.Controls.Add(this.rdoNew);
            this.grpProductInfo.Controls.Add(this.txtProductName);
            this.grpProductInfo.Controls.Add(this.txtPrice);
            this.grpProductInfo.Controls.Add(this.cmbCategory);
            this.grpProductInfo.Controls.Add(this.chkAutoSave);
            this.grpProductInfo.Location = new System.Drawing.Point(136, 52);
            this.grpProductInfo.Name = "grpProductInfo";
            this.grpProductInfo.Size = new System.Drawing.Size(729, 253);
            this.grpProductInfo.TabIndex = 24;
            this.grpProductInfo.TabStop = false;
            this.grpProductInfo.Text = "اطلاعات کالا";
            this.grpProductInfo.Enter += new System.EventHandler(this.grpProductInfo_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 70);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(371, 139);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = ":وضعیت کالا";
            // 
            // grpModules
            // 
            this.grpModules.Controls.Add(this.btnWarehouse);
            this.grpModules.Controls.Add(this.btnAccounting);
            this.grpModules.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpModules.Location = new System.Drawing.Point(252, 693);
            this.grpModules.Name = "grpModules";
            this.grpModules.Size = new System.Drawing.Size(500, 90);
            this.grpModules.TabIndex = 25;
            this.grpModules.TabStop = false;
            this.grpModules.Text = "بخش های سیستم";
            this.grpModules.Enter += new System.EventHandler(this.grpModules_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 795);
            this.Controls.Add(this.grpModules);
            this.Controls.Add(this.grpProductInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveProducts);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCountProducts);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(530, 328);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت فروشگاه لوازم دیجیتال";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BackColorChanged += new System.EventHandler(this.MainForm_BackColorChanged);
            this.grpProductInfo.ResumeLayout(false);
            this.grpProductInfo.PerformLayout();
            this.grpModules.ResumeLayout(false);
            this.grpModules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.CheckBox chkAutoSave;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnAccounting;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnCountProducts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnSaveProducts;
        private System.Windows.Forms.RadioButton rdoNew;
        private System.Windows.Forms.RadioButton rdoUsed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProductInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpModules;
        private System.Windows.Forms.Panel panel1;
    }
}

